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
            this.rbtSearchGoogle = new System.Windows.Forms.RadioButton();
            this.rbtSearchNyaa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "変更後ファイル名";
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(490, 343);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(122, 38);
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
            this.lstSearched.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstSearched.FormattingEnabled = true;
            this.lstSearched.HorizontalScrollbar = true;
            this.lstSearched.ItemHeight = 15;
            this.lstSearched.Location = new System.Drawing.Point(13, 157);
            this.lstSearched.Name = "lstSearched";
            this.lstSearched.Size = new System.Drawing.Size(599, 169);
            this.lstSearched.TabIndex = 4;
            this.lstSearched.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSearched_DrawItem);
            this.lstSearched.SelectedIndexChanged += new System.EventHandler(this.lstSearched_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ファイル名候補";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(490, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "型番候補";
            // 
            // txtRenFile
            // 
            this.txtRenFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenFile.Location = new System.Drawing.Point(12, 350);
            this.txtRenFile.Multiline = true;
            this.txtRenFile.Name = "txtRenFile";
            this.txtRenFile.Size = new System.Drawing.Size(441, 31);
            this.txtRenFile.TabIndex = 10;
            this.txtRenFile.Text = "txtRenFile\r\ntxtRenFile";
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
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(77, 84);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(407, 20);
            this.cmbItemCode.TabIndex = 13;
            this.cmbItemCode.Text = "cmbItemCode";
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
            this.groupBox1.Size = new System.Drawing.Size(600, 66);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ファイル名情報";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(65, 42);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(529, 19);
            this.txtFileName.TabIndex = 17;
            this.txtFileName.Text = "txtFileName";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(65, 18);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(529, 19);
            this.txtFilePath.TabIndex = 16;
            this.txtFilePath.Text = "txtFilePath";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "ファイル名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "場所";
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbStatus});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 384);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(624, 22);
            this.stsStatusBar.TabIndex = 17;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // slbStatus
            // 
            this.slbStatus.Name = "slbStatus";
            this.slbStatus.Size = new System.Drawing.Size(54, 17);
            this.slbStatus.Text = "slbStatus";
            // 
            // lblRenExt
            // 
            this.lblRenExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenExt.AutoSize = true;
            this.lblRenExt.Location = new System.Drawing.Point(454, 369);
            this.lblRenExt.Name = "lblRenExt";
            this.lblRenExt.Size = new System.Drawing.Size(31, 12);
            this.lblRenExt.TabIndex = 18;
            this.lblRenExt.Text = ".xxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "検索先";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtSearchGoogle);
            this.panel1.Controls.Add(this.rbtSearchNyaa);
            this.panel1.Location = new System.Drawing.Point(77, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 22);
            this.panel1.TabIndex = 21;
            // 
            // rbtSearchGoogle
            // 
            this.rbtSearchGoogle.AutoSize = true;
            this.rbtSearchGoogle.Location = new System.Drawing.Point(101, 3);
            this.rbtSearchGoogle.Name = "rbtSearchGoogle";
            this.rbtSearchGoogle.Size = new System.Drawing.Size(58, 16);
            this.rbtSearchGoogle.TabIndex = 22;
            this.rbtSearchGoogle.Text = "Google";
            this.rbtSearchGoogle.UseVisualStyleBackColor = true;
            // 
            // rbtSearchNyaa
            // 
            this.rbtSearchNyaa.AutoSize = true;
            this.rbtSearchNyaa.Checked = true;
            this.rbtSearchNyaa.Location = new System.Drawing.Point(3, 3);
            this.rbtSearchNyaa.Name = "rbtSearchNyaa";
            this.rbtSearchNyaa.Size = new System.Drawing.Size(92, 16);
            this.rbtSearchNyaa.TabIndex = 21;
            this.rbtSearchNyaa.TabStop = true;
            this.rbtSearchNyaa.Text = "NyaaTorrents";
            this.rbtSearchNyaa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblRenExt);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbItemCode);
            this.Controls.Add(this.txtRenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSearched);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "えろびりねーまー powerd by NyaaTorrents";
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
    }
}

