using System;
using System.Drawing;
using System.Windows.Forms;
using ExcelImageReader.Model;
using ExcelImageReader.Service;

namespace ExcelImageReader.View
{
    public partial class FormMain : Form
    {
        private Button buttonSourceFile;
        private Button buttonDestFolder;

        public FormMain()
        {
            InitializeComponent();

            SetupComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            DataProcessor dataProcessor = new DataProcessor(textBoxSourceFile.Text, (int)numUpDownImageNameColumn.Value,
                textBoxDestFolder.Text, textBoxImageFileExtension.Text,
                AddToLogList);

            dataProcessor.Process();
        }

        private void AddToLogList(string message)
        {
            listBoxLog.Items.Add(message);
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            listBoxLog.SelectedIndex = -1;
        }

        private void SetupComponent()
        {
            SetMainTitle(AppService.APP_TITLE, true, false);

            InitSourceFileButton();
            InitDestFolderButton();
        }

        private void SetMainTitle(string title, bool withVersion = false, bool withBuildDate = false)
        {
            this.Text = title;

            if (withVersion)
                this.Text += (" " + AppService.GetVersion());

            if (withBuildDate)
                this.Text += (" (" + AppService.GetBuildDate().ToString() + ")");
        }

        private void InitSourceFileButton()
        {
            buttonSourceFile = new Button();

            InitButtonInTextBox(buttonSourceFile, textBoxSourceFile, null,
                Properties.Resources.folder_icon, new EventHandler(buttonSourceFile_Click));
        }

        private void InitDestFolderButton()
        {
            buttonDestFolder = new Button();

            InitButtonInTextBox(buttonDestFolder, textBoxDestFolder, null,
                Properties.Resources.folder_icon, new EventHandler(buttonDestFolder_Click));
        }

        private void buttonSourceFile_Click(object sender, EventArgs e)
        {
            if (openSourceFileDialog.ShowDialog() == DialogResult.OK)
                textBoxSourceFile.Text = openSourceFileDialog.FileName;
        }

        private void buttonDestFolder_Click(object sender, EventArgs e)
        {
            if (destFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxDestFolder.Text = destFolderBrowserDialog.SelectedPath;
        }

        private void InitButtonInTextBox(Button button, TextBox textBox, string text, Image image, EventHandler clickHandler)
        {
            button.Cursor = Cursors.Default;
            button.Text = text;
            button.Image = image;
            button.Click += clickHandler;
            textBox.Controls.Add(button);

            ResetButtonInTextBox(button, textBox);
        }

        private void ResetButtonInTextBox(Button button, TextBox textBox)
        {
            button.Size = new Size(25, textBox.ClientSize.Height + 2);
            button.Location = new Point(textBox.ClientSize.Width - button.Width, -1);
            SendMessage(textBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(button.Width << 16));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void textBox_Resize(object sender, EventArgs e)
        {
            if (sender.Equals(textBoxSourceFile))
                ResetButtonInTextBox(buttonSourceFile, textBoxSourceFile);
            else if (sender.Equals(textBoxDestFolder))
                ResetButtonInTextBox(buttonDestFolder, textBoxDestFolder);
        }
    }
}
