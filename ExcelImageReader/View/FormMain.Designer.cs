namespace ExcelImageReader.View
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.labelDestFolder = new System.Windows.Forms.Label();
            this.textBoxDestFolder = new System.Windows.Forms.TextBox();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(17, 27);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(57, 13);
            this.labelSourceFile.TabIndex = 0;
            this.labelSourceFile.Text = "Source file";
            // 
            // labelDestFolder
            // 
            this.labelDestFolder.AutoSize = true;
            this.labelDestFolder.Location = new System.Drawing.Point(17, 59);
            this.labelDestFolder.Name = "labelDestFolder";
            this.labelDestFolder.Size = new System.Drawing.Size(89, 13);
            this.labelDestFolder.TabIndex = 1;
            this.labelDestFolder.Text = "Destination folder";
            // 
            // textBoxDestFolder
            // 
            this.textBoxDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestFolder.Location = new System.Drawing.Point(119, 56);
            this.textBoxDestFolder.Name = "textBoxDestFolder";
            this.textBoxDestFolder.Size = new System.Drawing.Size(552, 20);
            this.textBoxDestFolder.TabIndex = 2;
            this.textBoxDestFolder.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFile.Location = new System.Drawing.Point(119, 24);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(552, 20);
            this.textBoxSourceFile.TabIndex = 1;
            this.textBoxSourceFile.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControls.Controls.Add(this.buttonUpload);
            this.groupBoxControls.Controls.Add(this.labelSourceFile);
            this.groupBoxControls.Controls.Add(this.textBoxDestFolder);
            this.groupBoxControls.Controls.Add(this.textBoxSourceFile);
            this.groupBoxControls.Controls.Add(this.labelDestFolder);
            this.groupBoxControls.Location = new System.Drawing.Point(5, 2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(783, 97);
            this.groupBoxControls.TabIndex = 5;
            this.groupBoxControls.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpload.Location = new System.Drawing.Point(687, 24);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(77, 52);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(5, 105);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(783, 333);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.TabStop = false;
            this.textBoxLog.WordWrap = false;
            // 
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.Filter = "XLS files|*.xls|XLSX files|*.xlsx";
            this.openSourceFileDialog.InitialDirectory = ".";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBoxControls);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Image Reader";
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.Label labelDestFolder;
        private System.Windows.Forms.TextBox textBoxDestFolder;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.OpenFileDialog openSourceFileDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderBrowserDialog;
    }
}

