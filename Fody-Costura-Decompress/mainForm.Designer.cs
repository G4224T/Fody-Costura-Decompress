namespace Fody_Costura_Decompress
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.decompressButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.selectedFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(20, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(565, 34);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Select Costura compressed resources for decompression or select files for compres" +
    "sion\r\nCompression algorithm used by Costura is DEFLATE (Costura file ext: .zip, " +
    ".compressed)";
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(454, 56);
            this.inputFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(114, 31);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "browse";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // decompressButton
            // 
            this.decompressButton.Enabled = false;
            this.decompressButton.Location = new System.Drawing.Point(23, 131);
            this.decompressButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decompressButton.Name = "decompressButton";
            this.decompressButton.Size = new System.Drawing.Size(256, 48);
            this.decompressButton.TabIndex = 4;
            this.decompressButton.Text = "Decompress";
            this.decompressButton.UseVisualStyleBackColor = true;
            this.decompressButton.Click += new System.EventHandler(this.DecompressButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Enabled = false;
            this.compressButton.Location = new System.Drawing.Point(312, 131);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(256, 48);
            this.compressButton.TabIndex = 6;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // selectedFileTextBox
            // 
            this.selectedFileTextBox.Location = new System.Drawing.Point(23, 60);
            this.selectedFileTextBox.Name = "selectedFileTextBox";
            this.selectedFileTextBox.ReadOnly = true;
            this.selectedFileTextBox.Size = new System.Drawing.Size(425, 22);
            this.selectedFileTextBox.TabIndex = 7;
            this.selectedFileTextBox.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Compressed/decompressed file will be placed in same directory of source file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedFileTextBox);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.decompressButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.instructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Fody-Costura-(De)compress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Button decompressButton;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.TextBox selectedFileTextBox;
        private System.Windows.Forms.Label label1;
    }
}

