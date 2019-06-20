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
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelImageNameColumn = new System.Windows.Forms.Label();
            this.labelImageFileExtension = new System.Windows.Forms.Label();
            this.numUpDownImageNameColumn = new System.Windows.Forms.NumericUpDown();
            this.textBoxImageFileExtension = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownImageNameColumn)).BeginInit();
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
            this.textBoxDestFolder.Size = new System.Drawing.Size(363, 20);
            this.textBoxDestFolder.TabIndex = 2;
            this.textBoxDestFolder.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFile.Location = new System.Drawing.Point(119, 24);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(363, 20);
            this.textBoxSourceFile.TabIndex = 1;
            this.textBoxSourceFile.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControls.Controls.Add(this.textBoxImageFileExtension);
            this.groupBoxControls.Controls.Add(this.numUpDownImageNameColumn);
            this.groupBoxControls.Controls.Add(this.labelImageFileExtension);
            this.groupBoxControls.Controls.Add(this.labelImageNameColumn);
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
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.Filter = "XLSX files|*.xlsx";
            this.openSourceFileDialog.InitialDirectory = ".";
            // 
            // labelImageNameColumn
            // 
            this.labelImageNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageNameColumn.AutoSize = true;
            this.labelImageNameColumn.Location = new System.Drawing.Point(510, 27);
            this.labelImageNameColumn.Name = "labelImageNameColumn";
            this.labelImageNameColumn.Size = new System.Drawing.Size(102, 13);
            this.labelImageNameColumn.TabIndex = 4;
            this.labelImageNameColumn.Text = "Image name column";
            // 
            // labelImageFileExtension
            // 
            this.labelImageFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageFileExtension.AutoSize = true;
            this.labelImageFileExtension.Location = new System.Drawing.Point(510, 59);
            this.labelImageFileExtension.Name = "labelImageFileExtension";
            this.labelImageFileExtension.Size = new System.Drawing.Size(100, 13);
            this.labelImageFileExtension.TabIndex = 4;
            this.labelImageFileExtension.Text = "Image file extension";
            // 
            // numUpDownImageNameColumn
            // 
            this.numUpDownImageNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownImageNameColumn.Location = new System.Drawing.Point(618, 25);
            this.numUpDownImageNameColumn.Name = "numUpDownImageNameColumn";
            this.numUpDownImageNameColumn.Size = new System.Drawing.Size(49, 20);
            this.numUpDownImageNameColumn.TabIndex = 5;
            // 
            // textBoxImageFileExtension
            // 
            this.textBoxImageFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFileExtension.Location = new System.Drawing.Point(618, 56);
            this.textBoxImageFileExtension.Name = "textBoxImageFileExtension";
            this.textBoxImageFileExtension.Size = new System.Drawing.Size(49, 20);
            this.textBoxImageFileExtension.TabIndex = 6;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(5, 105);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLog.Size = new System.Drawing.Size(783, 342);
            this.listBoxLog.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.groupBoxControls);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Image Reader";
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownImageNameColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.Label labelDestFolder;
        private System.Windows.Forms.TextBox textBoxDestFolder;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openSourceFileDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderBrowserDialog;
        private System.Windows.Forms.Label labelImageFileExtension;
        private System.Windows.Forms.Label labelImageNameColumn;
        private System.Windows.Forms.NumericUpDown numUpDownImageNameColumn;
        private System.Windows.Forms.TextBox textBoxImageFileExtension;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

