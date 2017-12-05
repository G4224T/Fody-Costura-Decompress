using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fody_Costura_Decompress
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult openResult;

            openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                inputFileLabel.Text = openDialog.FileName;
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
    }
}
