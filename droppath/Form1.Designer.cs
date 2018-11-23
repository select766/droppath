namespace droppath
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaseDirectory = new System.Windows.Forms.TextBox();
            this.checkBoxRelativePath = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSepChar = new System.Windows.Forms.ComboBox();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCdCopy = new System.Windows.Forms.Button();
            this.checkBoxQuote = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "基準ディレクトリ";
            // 
            // textBoxBaseDirectory
            // 
            this.textBoxBaseDirectory.AllowDrop = true;
            this.textBoxBaseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBaseDirectory.Location = new System.Drawing.Point(96, 12);
            this.textBoxBaseDirectory.Name = "textBoxBaseDirectory";
            this.textBoxBaseDirectory.Size = new System.Drawing.Size(619, 19);
            this.textBoxBaseDirectory.TabIndex = 1;
            this.textBoxBaseDirectory.TextChanged += new System.EventHandler(this.textBoxBaseDirectory_TextChanged);
            this.textBoxBaseDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxBaseDirectory_DragDrop);
            this.textBoxBaseDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxBaseDirectory_DragEnter);
            // 
            // checkBoxRelativePath
            // 
            this.checkBoxRelativePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRelativePath.AutoSize = true;
            this.checkBoxRelativePath.Location = new System.Drawing.Point(721, 14);
            this.checkBoxRelativePath.Name = "checkBoxRelativePath";
            this.checkBoxRelativePath.Size = new System.Drawing.Size(67, 16);
            this.checkBoxRelativePath.TabIndex = 2;
            this.checkBoxRelativePath.Text = "相対パス";
            this.checkBoxRelativePath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "区切り文字";
            // 
            // comboBoxSepChar
            // 
            this.comboBoxSepChar.FormattingEnabled = true;
            this.comboBoxSepChar.Items.AddRange(new object[] {
            "[Space]",
            "[Tab]",
            "[Comma]",
            "[Colon]",
            "[Semicolon]",
            "[CRLF]",
            "[LF]"});
            this.comboBoxSepChar.Location = new System.Drawing.Point(79, 37);
            this.comboBoxSepChar.Name = "comboBoxSepChar";
            this.comboBoxSepChar.Size = new System.Drawing.Size(64, 20);
            this.comboBoxSepChar.TabIndex = 4;
            this.comboBoxSepChar.Text = "[Space]";
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.AllowDrop = true;
            this.textBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiles.Location = new System.Drawing.Point(12, 63);
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.Size = new System.Drawing.Size(776, 375);
            this.textBoxFiles.TabIndex = 5;
            this.textBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragDrop);
            this.textBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragEnter);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(713, 35);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "コピー";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCdCopy
            // 
            this.buttonCdCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCdCopy.Location = new System.Drawing.Point(600, 34);
            this.buttonCdCopy.Name = "buttonCdCopy";
            this.buttonCdCopy.Size = new System.Drawing.Size(107, 23);
            this.buttonCdCopy.TabIndex = 7;
            this.buttonCdCopy.Text = "CDコマンドコピー";
            this.buttonCdCopy.UseVisualStyleBackColor = true;
            this.buttonCdCopy.Click += new System.EventHandler(this.buttonCdCopy_Click);
            // 
            // checkBoxQuote
            // 
            this.checkBoxQuote.AutoSize = true;
            this.checkBoxQuote.Checked = true;
            this.checkBoxQuote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuote.Location = new System.Drawing.Point(149, 39);
            this.checkBoxQuote.Name = "checkBoxQuote";
            this.checkBoxQuote.Size = new System.Drawing.Size(87, 16);
            this.checkBoxQuote.TabIndex = 8;
            this.checkBoxQuote.Text = "ダブルクオート";
            this.checkBoxQuote.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxQuote);
            this.Controls.Add(this.buttonCdCopy);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.comboBoxSepChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxRelativePath);
            this.Controls.Add(this.textBoxBaseDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DropPath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaseDirectory;
        private System.Windows.Forms.CheckBox checkBoxRelativePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSepChar;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCdCopy;
        private System.Windows.Forms.CheckBox checkBoxQuote;
    }
}

