namespace NSCC_GUI
{
    partial class Main
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
            this.original_button = new System.Windows.Forms.Button();
            this.original_groupBox = new System.Windows.Forms.GroupBox();
            this.original_textBox = new System.Windows.Forms.TextBox();
            this.copyTo_groupBox = new System.Windows.Forms.GroupBox();
            this.copyTo_textBox = new System.Windows.Forms.TextBox();
            this.copyTo_button = new System.Windows.Forms.Button();
            this.logs_progressBar = new System.Windows.Forms.ProgressBar();
            this.start_button = new System.Windows.Forms.Button();
            this.logs_groupBox = new System.Windows.Forms.GroupBox();
            this.logs_textBox = new System.Windows.Forms.TextBox();
            this.original_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.copyTo_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.options_groupBox = new System.Windows.Forms.GroupBox();
            this.fileExist_checkBox = new System.Windows.Forms.CheckBox();
            this.showCopyTo_checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.original_groupBox.SuspendLayout();
            this.copyTo_groupBox.SuspendLayout();
            this.logs_groupBox.SuspendLayout();
            this.options_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // original_button
            // 
            this.original_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.original_button.ForeColor = System.Drawing.Color.Lime;
            this.original_button.Location = new System.Drawing.Point(387, 31);
            this.original_button.Name = "original_button";
            this.original_button.Size = new System.Drawing.Size(94, 23);
            this.original_button.TabIndex = 0;
            this.original_button.Text = "Folder...";
            this.original_button.UseVisualStyleBackColor = true;
            this.original_button.Click += new System.EventHandler(this.original_button_Click);
            // 
            // original_groupBox
            // 
            this.original_groupBox.Controls.Add(this.original_textBox);
            this.original_groupBox.Controls.Add(this.original_button);
            this.original_groupBox.ForeColor = System.Drawing.Color.Lime;
            this.original_groupBox.Location = new System.Drawing.Point(12, 12);
            this.original_groupBox.Name = "original_groupBox";
            this.original_groupBox.Size = new System.Drawing.Size(487, 76);
            this.original_groupBox.TabIndex = 1;
            this.original_groupBox.TabStop = false;
            this.original_groupBox.Text = "Original";
            this.original_groupBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.original_groupBox_DragDrop);
            this.original_groupBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.original_groupBox_DragEnter);
            // 
            // original_textBox
            // 
            this.original_textBox.AllowDrop = true;
            this.original_textBox.BackColor = System.Drawing.Color.Black;
            this.original_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.original_textBox.ForeColor = System.Drawing.Color.Lime;
            this.original_textBox.Location = new System.Drawing.Point(6, 31);
            this.original_textBox.Name = "original_textBox";
            this.original_textBox.ReadOnly = true;
            this.original_textBox.Size = new System.Drawing.Size(375, 23);
            this.original_textBox.TabIndex = 1;
            this.original_textBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.original_groupBox_DragDrop);
            this.original_textBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.original_groupBox_DragEnter);
            // 
            // copyTo_groupBox
            // 
            this.copyTo_groupBox.Controls.Add(this.copyTo_textBox);
            this.copyTo_groupBox.Controls.Add(this.copyTo_button);
            this.copyTo_groupBox.ForeColor = System.Drawing.Color.Lime;
            this.copyTo_groupBox.Location = new System.Drawing.Point(12, 94);
            this.copyTo_groupBox.Name = "copyTo_groupBox";
            this.copyTo_groupBox.Size = new System.Drawing.Size(487, 76);
            this.copyTo_groupBox.TabIndex = 2;
            this.copyTo_groupBox.TabStop = false;
            this.copyTo_groupBox.Text = "Copy to";
            this.copyTo_groupBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.copyTo_groupBox_DragDrop);
            this.copyTo_groupBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.copyTo_groupBox_DragEnter);
            // 
            // copyTo_textBox
            // 
            this.copyTo_textBox.AllowDrop = true;
            this.copyTo_textBox.BackColor = System.Drawing.Color.Black;
            this.copyTo_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyTo_textBox.ForeColor = System.Drawing.Color.Lime;
            this.copyTo_textBox.Location = new System.Drawing.Point(6, 31);
            this.copyTo_textBox.Name = "copyTo_textBox";
            this.copyTo_textBox.ReadOnly = true;
            this.copyTo_textBox.Size = new System.Drawing.Size(375, 23);
            this.copyTo_textBox.TabIndex = 1;
            this.copyTo_textBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.copyTo_groupBox_DragDrop);
            this.copyTo_textBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.copyTo_groupBox_DragEnter);
            // 
            // copyTo_button
            // 
            this.copyTo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyTo_button.ForeColor = System.Drawing.Color.Lime;
            this.copyTo_button.Location = new System.Drawing.Point(387, 31);
            this.copyTo_button.Name = "copyTo_button";
            this.copyTo_button.Size = new System.Drawing.Size(94, 23);
            this.copyTo_button.TabIndex = 0;
            this.copyTo_button.Text = "Folder...";
            this.copyTo_button.UseVisualStyleBackColor = true;
            this.copyTo_button.Click += new System.EventHandler(this.copyTo_button_Click);
            // 
            // logs_progressBar
            // 
            this.logs_progressBar.ForeColor = System.Drawing.Color.Lime;
            this.logs_progressBar.Location = new System.Drawing.Point(12, 445);
            this.logs_progressBar.Maximum = 0;
            this.logs_progressBar.Name = "logs_progressBar";
            this.logs_progressBar.Size = new System.Drawing.Size(487, 23);
            this.logs_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.logs_progressBar.TabIndex = 3;
            // 
            // start_button
            // 
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.ForeColor = System.Drawing.Color.Lime;
            this.start_button.Location = new System.Drawing.Point(399, 189);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 67);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // logs_groupBox
            // 
            this.logs_groupBox.Controls.Add(this.logs_textBox);
            this.logs_groupBox.ForeColor = System.Drawing.Color.Lime;
            this.logs_groupBox.Location = new System.Drawing.Point(12, 262);
            this.logs_groupBox.Name = "logs_groupBox";
            this.logs_groupBox.Size = new System.Drawing.Size(487, 177);
            this.logs_groupBox.TabIndex = 5;
            this.logs_groupBox.TabStop = false;
            this.logs_groupBox.Text = "Logs";
            // 
            // logs_textBox
            // 
            this.logs_textBox.BackColor = System.Drawing.Color.Black;
            this.logs_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs_textBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logs_textBox.ForeColor = System.Drawing.Color.Lime;
            this.logs_textBox.Location = new System.Drawing.Point(3, 19);
            this.logs_textBox.Multiline = true;
            this.logs_textBox.Name = "logs_textBox";
            this.logs_textBox.ReadOnly = true;
            this.logs_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logs_textBox.Size = new System.Drawing.Size(481, 155);
            this.logs_textBox.TabIndex = 1;
            this.logs_textBox.WordWrap = false;
            // 
            // original_folderBrowserDialog
            // 
            this.original_folderBrowserDialog.Description = "コピー元フォルダを選択";
            // 
            // copyTo_folderBrowserDialog
            // 
            this.copyTo_folderBrowserDialog.Description = "コピー先フォルダを選択";
            // 
            // options_groupBox
            // 
            this.options_groupBox.Controls.Add(this.showCopyTo_checkBox);
            this.options_groupBox.Controls.Add(this.fileExist_checkBox);
            this.options_groupBox.ForeColor = System.Drawing.Color.Lime;
            this.options_groupBox.Location = new System.Drawing.Point(12, 180);
            this.options_groupBox.Name = "options_groupBox";
            this.options_groupBox.Size = new System.Drawing.Size(381, 76);
            this.options_groupBox.TabIndex = 6;
            this.options_groupBox.TabStop = false;
            this.options_groupBox.Text = "Options";
            // 
            // fileExist_checkBox
            // 
            this.fileExist_checkBox.AutoSize = true;
            this.fileExist_checkBox.Location = new System.Drawing.Point(6, 34);
            this.fileExist_checkBox.Name = "fileExist_checkBox";
            this.fileExist_checkBox.Size = new System.Drawing.Size(195, 19);
            this.fileExist_checkBox.TabIndex = 0;
            this.fileExist_checkBox.Text = "ファイルが存在した場合、上書きする";
            this.fileExist_checkBox.UseVisualStyleBackColor = true;
            // 
            // showCopyTo_checkBox
            // 
            this.showCopyTo_checkBox.AutoSize = true;
            this.showCopyTo_checkBox.Location = new System.Drawing.Point(207, 34);
            this.showCopyTo_checkBox.Name = "showCopyTo_checkBox";
            this.showCopyTo_checkBox.Size = new System.Drawing.Size(134, 19);
            this.showCopyTo_checkBox.TabIndex = 1;
            this.showCopyTo_checkBox.Text = "コピー先パスを表示する";
            this.showCopyTo_checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NSCC_GUI.Properties.Resources._8_animation;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(511, 484);
            this.Controls.Add(this.options_groupBox);
            this.Controls.Add(this.logs_groupBox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.logs_progressBar);
            this.Controls.Add(this.copyTo_groupBox);
            this.Controls.Add(this.original_groupBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NSCC GUI v1.00";
            this.original_groupBox.ResumeLayout(false);
            this.original_groupBox.PerformLayout();
            this.copyTo_groupBox.ResumeLayout(false);
            this.copyTo_groupBox.PerformLayout();
            this.logs_groupBox.ResumeLayout(false);
            this.logs_groupBox.PerformLayout();
            this.options_groupBox.ResumeLayout(false);
            this.options_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button original_button;
        private System.Windows.Forms.GroupBox original_groupBox;
        private System.Windows.Forms.TextBox original_textBox;
        private System.Windows.Forms.GroupBox copyTo_groupBox;
        private System.Windows.Forms.TextBox copyTo_textBox;
        private System.Windows.Forms.Button copyTo_button;
        private System.Windows.Forms.ProgressBar logs_progressBar;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.GroupBox logs_groupBox;
        private System.Windows.Forms.TextBox logs_textBox;
        private System.Windows.Forms.FolderBrowserDialog original_folderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog copyTo_folderBrowserDialog;
        private System.Windows.Forms.GroupBox options_groupBox;
        private System.Windows.Forms.CheckBox fileExist_checkBox;
        private System.Windows.Forms.CheckBox showCopyTo_checkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

