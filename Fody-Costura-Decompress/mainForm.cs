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

        FileInfo fileToDeCompressInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult openResult;
            openDialog.Multiselect = false;


            doneLabel.Visible = false;
            openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                inputFileLabel.Text = openDialog.FileName;
                fileToDeCompressInfo = new FileInfo(openDialog.FileName);
                decompButton.Enabled = true;
            }

        }

       


        private void decompButton_Click(object sender, EventArgs e)
        {

                using (FileStream originalFileStream = File.OpenRead(fileToDeCompressInfo.FullName))
                {
                    string currentFileName = fileToDeCompressInfo.FullName.ToString();
                    string newFileName = currentFileName.Remove(currentFileName.Length - fileToDeCompressInfo.Extension.Length);

                    using (FileStream decompressedFileStream = File.Create(newFileName))
                    {
                        using (DeflateStream decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            doneLabel.Visible = true;
                        }
                    }
                }
         
        }
    }
}
