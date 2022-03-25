namespace VideoTitleGetter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.lstSearched = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRenFile = new System.Windows.Forms.TextBox();
            this.ofdFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.slbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRenExt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtSearchNyaaSi = new System.Windows.Forms.RadioButton();
            this.rbtSearchGoogle = new System.Windows.Forms.RadioButton();
            this.rbtSearchNyaa = new System.Windows.Forms.RadioButton();
            this.rbtSearchHEra = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "変更後ファイル名";
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(470, 352);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(142, 56);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "ファイル名変更";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lstSearched
            // 
            this.lstSearched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSearched.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstSearched.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstSearched.FormattingEnabled = true;
            this.lstSearched.HorizontalScrollbar = true;
            this.lstSearched.ItemHeight = 15;
            this.lstSearched.Location = new System.Drawing.Point(12, 199);
            this.lstSearched.Name = "lstSearched";
            this.lstSearched.Size = new System.Drawing.Size(600, 124);
            this.lstSearched.TabIndex = 4;
            this.lstSearched.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSearched_DrawItem);
            this.lstSearched.SelectedIndexChanged += new System.EventHandler(this.lstSearched_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "ファイル名候補";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(470, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 52);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "型番候補";
            // 
            // txtRenFile
            // 
            this.txtRenFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenFile.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRenFile.Location = new System.Drawing.Point(12, 352);
            this.txtRenFile.Multiline = true;
            this.txtRenFile.Name = "txtRenFile";
            this.txtRenFile.Size = new System.Drawing.Size(449, 56);
            this.txtRenFile.TabIndex = 10;
            this.txtRenFile.Text = "１２３４５６７８９０１２３４５６７８９０１２３４５６７\r\nｔｘｔＲｅｎＦｉｌｅ\r\nｔｘｔＲｅｎＦｉｌｅ";
            this.txtRenFile.TextChanged += new System.EventHandler(this.txtRenFile_TextChanged);
            this.txtRenFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRenFile_KeyDown);
            // 
            // ofdFileSelector
            // 
            this.ofdFileSelector.FileName = "openFileDialog1";
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItemCode.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(81, 91);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(531, 23);
            this.cmbItemCode.TabIndex = 13;
            this.cmbItemCode.Text = "cmbItemCode";
            this.cmbItemCode.TextChanged += new System.EventHandler(this.cmbItemCode_TextChanged);
            this.cmbItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbItemCode_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ファイル名情報";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(70, 46);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(524, 21);
            this.txtFileName.TabIndex = 17;
            this.txtFileName.Text = "txtFileName";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(70, 20);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(524, 21);
            this.txtFilePath.TabIndex = 16;
            this.txtFilePath.Text = "txtFilePath";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "ファイル名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "場所";
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbStatus});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 419);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stsStatusBar.Size = new System.Drawing.Size(624, 22);
            this.stsStatusBar.TabIndex = 17;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // slbStatus
            // 
            this.slbStatus.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.slbStatus.Name = "slbStatus";
            this.slbStatus.Size = new System.Drawing.Size(53, 17);
            this.slbStatus.Text = "slbStatus";
            // 
            // lblRenExt
            // 
            this.lblRenExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenExt.AutoSize = true;
            this.lblRenExt.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRenExt.Location = new System.Drawing.Point(514, 434);
            this.lblRenExt.Name = "lblRenExt";
            this.lblRenExt.Size = new System.Drawing.Size(47, 15);
            this.lblRenExt.TabIndex = 18;
            this.lblRenExt.Text = ".xxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "検索先";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtSearchHEra);
            this.panel1.Controls.Add(this.rbtSearchNyaaSi);
            this.panel1.Controls.Add(this.rbtSearchGoogle);
            this.panel1.Controls.Add(this.rbtSearchNyaa);
            this.panel1.Location = new System.Drawing.Point(81, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 52);
            this.panel1.TabIndex = 21;
            // 
            // rbtSearchNyaaSi
            // 
            this.rbtSearchNyaaSi.AutoSize = true;
            this.rbtSearchNyaaSi.Checked = true;
            this.rbtSearchNyaaSi.Location = new System.Drawing.Point(3, 3);
            this.rbtSearchNyaaSi.Name = "rbtSearchNyaaSi";
            this.rbtSearchNyaaSi.Size = new System.Drawing.Size(130, 18);
            this.rbtSearchNyaaSi.TabIndex = 23;
            this.rbtSearchNyaaSi.TabStop = true;
            this.rbtSearchNyaaSi.Text = "Nyaa.si（件数：多）";
            this.rbtSearchNyaaSi.UseVisualStyleBackColor = true;
            // 
            // rbtSearchGoogle
            // 
            this.rbtSearchGoogle.AutoSize = true;
            this.rbtSearchGoogle.Location = new System.Drawing.Point(171, 27);
            this.rbtSearchGoogle.Name = "rbtSearchGoogle";
            this.rbtSearchGoogle.Size = new System.Drawing.Size(112, 18);
            this.rbtSearchGoogle.TabIndex = 22;
            this.rbtSearchGoogle.Text = "Google（おまけ）";
            this.rbtSearchGoogle.UseVisualStyleBackColor = true;
            // 
            // rbtSearchNyaa
            // 
            this.rbtSearchNyaa.AutoSize = true;
            this.rbtSearchNyaa.Location = new System.Drawing.Point(143, 3);
            this.rbtSearchNyaa.Name = "rbtSearchNyaa";
            this.rbtSearchNyaa.Size = new System.Drawing.Size(159, 18);
            this.rbtSearchNyaa.TabIndex = 21;
            this.rbtSearchNyaa.Text = "NyaaPantsu（件数：少）";
            this.rbtSearchNyaa.UseVisualStyleBackColor = true;
            // 
            // rbtSearchHEra
            // 
            this.rbtSearchHEra.AutoSize = true;
            this.rbtSearchHEra.Location = new System.Drawing.Point(3, 27);
            this.rbtSearchHEra.Name = "rbtSearchHEra";
            this.rbtSearchHEra.Size = new System.Drawing.Size(162, 18);
            this.rbtSearchHEra.TabIndex = 24;
            this.rbtSearchHEra.Text = "jav.h-era.org（件数：多）";
            this.rbtSearchHEra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbItemCode);
            this.Controls.Add(this.txtRenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSearched);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRenExt);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "えろびりねーまー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ListBox lstSearched;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRenFile;
        private System.Windows.Forms.OpenFileDialog ofdFileSelector;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel slbStatus;
        private System.Windows.Forms.Label lblRenExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtSearchGoogle;
        private System.Windows.Forms.RadioButton rbtSearchNyaa;
        private System.Windows.Forms.RadioButton rbtSearchNyaaSi;
        private System.Windows.Forms.RadioButton rbtSearchHEra;
    }
}

