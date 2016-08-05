using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Yugen.Tools.Web.Scraper;

namespace VideoTitleGetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "定数"
        /// <summary>型番を示す正規表現</summary>
        Regex _itemCode = new Regex(
            @"([a-z]+-?\d+)",
            RegexOptions.Singleline | RegexOptions.IgnoreCase);
        #endregion

        #region "イベント"
        /// <summary>フォーム初期化</summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            clearItems();
            slbStatus.Text = "覚悟完了";
        }

        /// <summary>ドラッグされた</summary>
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //ドラッグされたデータ形式がファイルのときはコピー。それ以外は受け付けない
            e.Effect =
                e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;     //ファイル以外は受け付けない
        }

        /// <summary>ドロップされた</summary>
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            clearItems();

            // ドロップされたファイルのパスを取得
            string fullPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            // パス情報を表示
            putFileInfo(fullPath);

            // 型番プルダウン表示
            putItemCodeCombo(
                getItemCodes(Path.GetFileNameWithoutExtension(fullPath)));
        }

        /// <summary>ファイル名候補が選択された</summary>
        private void lstSearched_SelectedIndexChanged(object sender, EventArgs e)
        {
            //空行が選択されている場合は何もしない
            if (lstSearched.SelectedItem == null) return;

            txtRenFile.Text = lstSearched.SelectedItem.ToString().Trim();
        }

        /// <summary>ファイル名候補一覧をシマシマにする</summary>
        private void lstSearched_DrawItem(object sender, DrawItemEventArgs e)
        {
            //中身が空なら何もしない
            if (e.Index == -1) return;

            e.DrawBackground();

            if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)
            {
                if (e.Index % 2 == 1)
                {
                    e.Graphics.FillRectangle(
                        new SolidBrush(SystemColors.Info),
                        new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                    );
                }
            }

            e.Graphics.DrawString(
                lstSearched.Items[e.Index].ToString(),
                e.Font,
                new SolidBrush(lstSearched.ForeColor),
                new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
            );

            e.DrawFocusRectangle();
        }


        /// <summary>検索ボタンが押された</summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        /// <summary>リネームボタンが押された</summary>
        private void btnRename_Click(object sender, EventArgs e)
        {
            rename();
        }

        /// <summary>型番候補欄でキーが押された</summary>
        private void cmbItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        /// <summary>変更後ファイル名欄でキーが押された</summary>
        private void txtRenFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rename();
            }
        }
        #endregion

        #region "サブルーチン"
        /// <summary>コントロール内容初期化</summary>
        private void clearItems()
        {
            txtFileName.Text = "";
            txtFilePath.Text = "";
            txtRenFile.Text = "";
            lblRenExt.Text = "";

            cmbItemCode.Items.Clear();
            cmbItemCode.Text = "";

            lstSearched.Items.Clear();
        }

        /// <summary>ファイル情報を表示</summary>
        private void putFileInfo(string fullPath)
        {
            txtFilePath.Text = Path.GetDirectoryName(fullPath);
            txtFileName.Text = Path.GetFileName(fullPath);
            lblRenExt.Text = Path.GetExtension(fullPath);
        }

        /// <summary>型番プルダウン表示</summary>
        private void putItemCodeCombo(List<string> itemCodes)
        {
            //プルダウンのクリア
            cmbItemCode.Items.Clear();
            cmbItemCode.Text = "";

            foreach (var item in itemCodes)
            {
                cmbItemCode.Items.Add(item);
            }

            if (cmbItemCode.Items.Count > 0)
            {
                cmbItemCode.Text = cmbItemCode.Items[0].ToString();
            }
        }

        /// <summary>ファイル名から型番候補を抽出</summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>型番候補一覧</returns>
        private List<string> getItemCodes(string filename)
        {
            var retVal = new List<string>();
            var mc = _itemCode.Matches(filename);

            foreach (Match m in mc)
            {
                retVal.Add(m.Value);
            }

            // 最下行にファイル名そのものを載せる
            if (mc.Count > 0) retVal.Add("--------------------");
            retVal.Add(filename);

            return retVal;
        }

        /// <summary>検索</summary>
        private void search()
        {
            //型番欄が空なら何もしない
            if (cmbItemCode.Text == "") return;

            //マウスカーソルを砂時計にする
            var preCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //NyaaTorrentから検索結果を取得
            var list = selectScraper().GetFilenames(cmbItemCode.Text);
            var sortedList = list.Distinct().OrderBy(s => s);

            //型番候補コンボボックスにセット
            lstSearched.Items.Clear();
            foreach (var line in sortedList)
            {
                lstSearched.Items.Add(line);
            }

            slbStatus.Text = string.Format(
                "{0:#,##0} 件 (重複排除前 {1:#,##0} 件)",
                lstSearched.Items.Count, list.Count);

            //マウスカーソルを元に戻す
            Cursor.Current = preCursor;
        }

        private IScraper selectScraper()
        {
            if (rbtSearchNyaa.Checked) return new NyaaTorrentScraper();
            if (rbtSearchGoogle.Checked) return new GoogleScraper();
            //if (rbtSearchH_Era.Checked) return new hEraScraper();

            //デフォルト
            return new NyaaTorrentScraper();
        }

        private void rename()
        {
            try
            {
                var fr = Path.Combine(txtFilePath.Text, txtFileName.Text);
                var to = Path.Combine(
                    txtFilePath.Text,
                    txtRenFile.Text + lblRenExt.Text
                );

                if (to.Trim() == "") return;

                System.IO.File.Move(fr, to);
                clearItems();
                slbStatus.Text = "ファイル名の変更が完了しました";
            }
            catch (Exception e)
            {
                slbStatus.Text = string.Format("ファイル名の変更に失敗しました({0})", e.Message);
            }
        }
        #endregion

    }
}
