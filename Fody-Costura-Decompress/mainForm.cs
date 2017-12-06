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

        FileInfo _fileToDeCompressInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InputFileButton_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog {Multiselect = false};


            doneLabel.Visible = false;
            var openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                inputFileLabel.Text = openDialog.FileName;
                _fileToDeCompressInfo = new FileInfo(openDialog.FileName);
                decompButton.Enabled = true;
            }

        }

       


        private void DecompButton_Click(object sender, EventArgs e)
        {

                using (var originalFileStream = File.OpenRead(_fileToDeCompressInfo.FullName))
                {
                    var currentFileName = _fileToDeCompressInfo.FullName.ToString();
                    var newFileName = currentFileName.Remove(currentFileName.Length - _fileToDeCompressInfo.Extension.Length);

                    using (var decompressedFileStream = File.Create(newFileName))
                    {
                        using (var decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            doneLabel.Visible = true;
                        }
                    }
                }
         
        }
    }
}
