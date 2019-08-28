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

        #region "イベント"
        /// <summary>フォーム初期化</summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            clearItems();

            // バージョン番号取得
            this.Text += " v" + Application.ProductVersion;

            slbStatus.Text = "リネームしたいファイルをウインドウにドラッグ＆ドロップしてください";
        }

        /// <summary>ファイルがドラッグされた</summary>
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            // フォルダー・ファイルじゃない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            string[] dragged = (string[])e.Data.GetData(DataFormats.FileDrop);

            // 複数選択されている・全く選択されていない
            if (dragged.Length != 1)
                return;

            // ファイルにだけ反応する
            if (System.IO.File.Exists(dragged[0]))
                e.Effect = DragDropEffects.Copy;
        }

        /// <summary>ドロップされた</summary>
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            clearItems();

            // ドロップされたファイルのパスを取得
            string fullPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            // パス情報を表示
            putFileInfo(fullPath);

            // 型番プルダウン表示
            putItemCodeCombo(
                getItemCodes(Path.GetFileNameWithoutExtension(fullPath)));

            slbStatus.Text = "型番候補を確認し、検索先を選んで、「検索」ボタンを押してください";
        }

        /// <summary>ファイル名候補が選択された</summary>
        private void lstSearched_SelectedIndexChanged(object sender, EventArgs e)
        {
            //空行が選択されている場合は何もしない
            if (lstSearched.SelectedItem == null) return;

            txtRenFile.Text = lstSearched.SelectedItem.ToString().Trim();
            btnRename.Enabled = true;
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

        /// <summary>型番候補欄の内容が変わった</summary>
        private void cmbItemCode_TextChanged(object sender, EventArgs e)
        {
            // 型番候補欄が入力済みの時だけ検索ボタンを押せる
            btnSearch.Enabled = (cmbItemCode.Text.Length > 0);
        }

        /// <summary>変更後ファイル名欄でキーが押された</summary>
        private void txtRenFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rename();
            }
        }

        /// <summary>変更後ファイル名欄が変更された</summary>
        private void txtRenFile_TextChanged(object sender, EventArgs e)
        {
            // 型番候補欄が入力済みの時だけ検索ボタンを押せる
            btnRename.Enabled = (txtRenFile.Text.Length > 0);
        }
        #endregion

        #region "サブルーチン"
        /// <summary>コントロール内容初期化</summary>
        private void clearItems()
        {
            // ファイル名情報
            txtFileName.Text = "";
            txtFilePath.Text = "";

            // 型番候補
            cmbItemCode.Items.Clear();
            cmbItemCode.Text = "";
            btnSearch.Enabled = false;

            // ファイル名候補
            lstSearched.Items.Clear();

            // 変更後ファイル名
            txtRenFile.Text = "";
            lblRenExt.Text = "";
            btnRename.Enabled = false;
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
            var retVal = new List<string>();        //一覧全体

            /// <summary>型番を示す正規表現</summary>
            //FC2型番
            var CODE_FC2 = new Regex(
                @"(fc2)[\s-_]?(?:ppv)*[\s-_]?(\d+)",
                RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);

            //一般的な型番
            var CODE_NORMAL = new Regex(
                @"([a-z]+)-?(\d+)",
                RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);

            var work = new List<string>();

            MatchCollection mc = CODE_FC2.IsMatch(filename) ? CODE_FC2.Matches(filename)
                : CODE_NORMAL.Matches(filename);

            //型番(ABC-1234)を英字部(ABC)と数字部(1234)に分け、ハイフン区切り・スペース区切りのパターンを提案する
            foreach (Match m in mc)
            {
                work.Add(m.Value);
                work.Add(m.Groups[1].Value + "-" + m.Groups[2].Value);    //ハイフン区切り提案
                work.Add(m.Groups[1].Value + " " + m.Groups[2].Value);    //スペース区切り提案
            }
            //入力と提案が重複する場合は除外する
            retVal.AddRange(work.Distinct().OrderBy(s => s).ToList());

            //最下行にファイル名そのものを載せる
            if (mc.Count > 0) retVal.Add("[元ファイル名]--------------------");   //候補が有るときは区切りが無いと見にくい
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

            slbStatus.Text = "検索中...";

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

        /// <summary>ラジオボタンの選択に対応するScraperを返す</summary>
        /// <returns>ラジオボタンに対応するScraper</returns>
        private IScraper selectScraper()
        {
            if (rbtSearchNyaaSi.Checked) return new NyaaSiScraper();
            if (rbtSearchNyaa.Checked) return new NyaaPantsuScraper();
            if (rbtSearchGoogle.Checked) return new GoogleScraper();
            //if (rbtSearchH_Era.Checked) return new hEraScraper();

            //デフォルト
            return new NyaaSiScraper();
        }

        /// <summary>ファイル名変更</summary>
        private void rename()
        {
            try
            {
                //変更元ファイル確定
                var frFullPath = Path.Combine(txtFilePath.Text, txtFileName.Text);

                //変更先ファイル確定
                var toRenName = txtRenFile.Text.Trim();         //誤入力で空白ゴミ入る事あるので除く
                var toFileName = toRenName + lblRenExt.Text;    //拡張子付き
                checkFileName(toFileName);                      //禁止文字OK？
                var toFullPath = Path.Combine(txtFilePath.Text, toFileName);

                // ファイル名が空なら何もしない
                if (frFullPath.Trim() == "") return;
                if (toRenName == "") return;

                // 全てチェックOKならファイル名変更
                System.IO.File.Move(frFullPath, toFullPath);

                clearItems();
                slbStatus.Text = "ファイル名を変更しました";
            }
            catch (Exception e)
            {
                slbStatus.Text = string.Format("ファイル名変更に失敗しました(原因：{0})", e.Message);
            }
        }

        /// <summary>
        /// ファイル名に使用禁止文字が含まれているかチェックする
        /// 含まれていればエラーメッセージを表示し、ApplicationExceptionをthrowする
        /// </summary>
        /// <param name="fileName">チェック対象ファイル</param>
        private void checkFileName(string fileName)
        {
            //ファイル名に使用禁止文字が含まれていれば0以上の位置番号がセットされる
            var pos = fileName.IndexOfAny(Path.GetInvalidFileNameChars());

            if (pos != -1)
            {
                var baseStr = string.Format(
                    "「変更後ファイル名」欄の{0}文字目に使用禁止文字「{1}」が使われています。",
                    (pos + 1),
                    fileName.Substring(pos, 1));

                MessageBox.Show(
                    baseStr + Environment.NewLine +
                    "全角文字に直す、または取り除いてから、再度『ファイル名変更』ボタンを押してください。",
                    "ファイル名変更に失敗",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                throw new ApplicationException(baseStr);
            }
        }
        #endregion
    }
}
