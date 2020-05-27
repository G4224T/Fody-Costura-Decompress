using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Fody_Costura_Decompress
{
    public partial class MainForm : Form
    {

        FileInfo _sourceFileInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessFile(FileInfo sourceFile, string destinationFileName, bool compress)
        {
            using (var originalFileStream = File.OpenRead(_sourceFileInfo.FullName))
                using (var destinationFileStream = File.Create(destinationFileName))
                    if (compress)
                        using (var compressionStream = new DeflateStream(destinationFileStream, CompressionMode.Compress))
                            originalFileStream.CopyTo(compressionStream);
                    else
                        using (var decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                            decompressionStream.CopyTo(destinationFileStream);
        }

        private void InputFileButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog {Multiselect = false};

            var openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                selectedFileTextBox.Text = openDialog.FileName;
                _sourceFileInfo = new FileInfo(openDialog.FileName);
                decompressButton.Enabled = true;
                compressButton.Enabled = true;
            }
        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            var sourceFileName = _sourceFileInfo.FullName.ToString();
            var inflatedFileName = sourceFileName.Remove(sourceFileName.Length - _sourceFileInfo.Extension.Length);
            try
            {
                ProcessFile(_sourceFileInfo, inflatedFileName, false);
                System.Windows.Forms.MessageBox.Show("Successfully inflated " + _sourceFileInfo.Name);
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error when inflating file: " + err.ToString());
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            var sourceFileName = _sourceFileInfo.FullName.ToString();
            var deflatedFileName = sourceFileName + ".compressed";
            try
            {
                ProcessFile(_sourceFileInfo, deflatedFileName, true);
                System.Windows.Forms.MessageBox.Show("Successfully deflated " + _sourceFileInfo.Name);
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error when deflating file: " + err.ToString());
            }
        }
    }
}
