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

        OpenFileDialog openDialog = new OpenFileDialog();
        string fileToDecompress;
        FileInfo fsInfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
           
            DialogResult openResult;

            openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                inputFileLabel.Text = openDialog.FileName;
                fileToDecompress = openDialog.FileName;
                fsInfo = new FileInfo(openDialog.FileName);
            }

        }

        private void outputFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            DialogResult saveResult;

            saveResult = saveDialog.ShowDialog();

            if (saveResult == DialogResult.OK)
            {
                outputFileLabel.Text = saveDialog.FileName;
            }
        }


        private void decompButton_Click(object sender, EventArgs e)
        {

                using (FileStream originalFileStream = File.OpenRead(fileToDecompress))
                {
                    string currentFileName = fileToDecompress;
                    string newFileName = currentFileName.Remove(currentFileName.Length - fsInfo.Extension.Length);

                    using (FileStream decompressedFileStream = File.Create(newFileName))
                    {
                        using (DeflateStream decompressionStream = new DeflateStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            // Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                        }
                    }
                }
         
        }
    }
}
