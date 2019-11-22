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
            this.numUpDownImageURLColumn = new System.Windows.Forms.NumericUpDown();
            this.labelImageURLColumn = new System.Windows.Forms.Label();
            this.comboImageSourceType = new System.Windows.Forms.ComboBox();
            this.labelImageSourceType = new System.Windows.Forms.Label();
            this.textBoxImageFileExtension = new System.Windows.Forms.TextBox();
            this.numUpDownImageNameColumn = new System.Windows.Forms.NumericUpDown();
            this.labelImageFileExtension = new System.Windows.Forms.Label();
            this.labelImageNameColumn = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownImageURLColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownImageNameColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(18, 57);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(57, 13);
            this.labelSourceFile.TabIndex = 0;
            this.labelSourceFile.Text = "Source file";
            // 
            // labelDestFolder
            // 
            this.labelDestFolder.AutoSize = true;
            this.labelDestFolder.Location = new System.Drawing.Point(18, 89);
            this.labelDestFolder.Name = "labelDestFolder";
            this.labelDestFolder.Size = new System.Drawing.Size(89, 13);
            this.labelDestFolder.TabIndex = 1;
            this.labelDestFolder.Text = "Destination folder";
            // 
            // textBoxDestFolder
            // 
            this.textBoxDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestFolder.Location = new System.Drawing.Point(120, 86);
            this.textBoxDestFolder.Name = "textBoxDestFolder";
            this.textBoxDestFolder.Size = new System.Drawing.Size(363, 20);
            this.textBoxDestFolder.TabIndex = 2;
            this.textBoxDestFolder.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFile.Location = new System.Drawing.Point(120, 54);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(363, 20);
            this.textBoxSourceFile.TabIndex = 1;
            this.textBoxSourceFile.Resize += new System.EventHandler(this.textBox_Resize);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControls.Controls.Add(this.numUpDownImageURLColumn);
            this.groupBoxControls.Controls.Add(this.labelImageURLColumn);
            this.groupBoxControls.Controls.Add(this.comboImageSourceType);
            this.groupBoxControls.Controls.Add(this.labelImageSourceType);
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
            this.groupBoxControls.Size = new System.Drawing.Size(783, 123);
            this.groupBoxControls.TabIndex = 5;
            this.groupBoxControls.TabStop = false;
            // 
            // numUpDownImageURLColumn
            // 
            this.numUpDownImageURLColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownImageURLColumn.Location = new System.Drawing.Point(619, 55);
            this.numUpDownImageURLColumn.Name = "numUpDownImageURLColumn";
            this.numUpDownImageURLColumn.Size = new System.Drawing.Size(49, 20);
            this.numUpDownImageURLColumn.TabIndex = 10;
            // 
            // labelImageURLColumn
            // 
            this.labelImageURLColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageURLColumn.AutoSize = true;
            this.labelImageURLColumn.Location = new System.Drawing.Point(511, 57);
            this.labelImageURLColumn.Name = "labelImageURLColumn";
            this.labelImageURLColumn.Size = new System.Drawing.Size(98, 13);
            this.labelImageURLColumn.TabIndex = 9;
            this.labelImageURLColumn.Text = "Image URL column";
            // 
            // comboImageSourceType
            // 
            this.comboImageSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboImageSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImageSourceType.FormattingEnabled = true;
            this.comboImageSourceType.Location = new System.Drawing.Point(120, 19);
            this.comboImageSourceType.Name = "comboImageSourceType";
            this.comboImageSourceType.Size = new System.Drawing.Size(363, 21);
            this.comboImageSourceType.TabIndex = 8;
            // 
            // labelImageSourceType
            // 
            this.labelImageSourceType.AutoSize = true;
            this.labelImageSourceType.Location = new System.Drawing.Point(18, 22);
            this.labelImageSourceType.Name = "labelImageSourceType";
            this.labelImageSourceType.Size = new System.Drawing.Size(94, 13);
            this.labelImageSourceType.TabIndex = 7;
            this.labelImageSourceType.Text = "Image source type";
            // 
            // textBoxImageFileExtension
            // 
            this.textBoxImageFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFileExtension.Location = new System.Drawing.Point(619, 86);
            this.textBoxImageFileExtension.Name = "textBoxImageFileExtension";
            this.textBoxImageFileExtension.Size = new System.Drawing.Size(49, 20);
            this.textBoxImageFileExtension.TabIndex = 6;
            // 
            // numUpDownImageNameColumn
            // 
            this.numUpDownImageNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownImageNameColumn.Location = new System.Drawing.Point(619, 20);
            this.numUpDownImageNameColumn.Name = "numUpDownImageNameColumn";
            this.numUpDownImageNameColumn.Size = new System.Drawing.Size(49, 20);
            this.numUpDownImageNameColumn.TabIndex = 5;
            // 
            // labelImageFileExtension
            // 
            this.labelImageFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageFileExtension.AutoSize = true;
            this.labelImageFileExtension.Location = new System.Drawing.Point(511, 89);
            this.labelImageFileExtension.Name = "labelImageFileExtension";
            this.labelImageFileExtension.Size = new System.Drawing.Size(100, 13);
            this.labelImageFileExtension.TabIndex = 4;
            this.labelImageFileExtension.Text = "Image file extension";
            // 
            // labelImageNameColumn
            // 
            this.labelImageNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageNameColumn.AutoSize = true;
            this.labelImageNameColumn.Location = new System.Drawing.Point(511, 22);
            this.labelImageNameColumn.Name = "labelImageNameColumn";
            this.labelImageNameColumn.Size = new System.Drawing.Size(102, 13);
            this.labelImageNameColumn.TabIndex = 4;
            this.labelImageNameColumn.Text = "Image name column";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpload.Location = new System.Drawing.Point(688, 20);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(77, 86);
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
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(5, 131);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLog.Size = new System.Drawing.Size(783, 316);
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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownImageURLColumn)).EndInit();
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
        private System.Windows.Forms.ComboBox comboImageSourceType;
        private System.Windows.Forms.Label labelImageSourceType;
        private System.Windows.Forms.NumericUpDown numUpDownImageURLColumn;
        private System.Windows.Forms.Label labelImageURLColumn;
    }
}

