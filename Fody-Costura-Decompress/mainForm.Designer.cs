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
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.decompButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(271, 80);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(117, 20);
            this.inputFileLabel.TabIndex = 0;
            this.inputFileLabel.Text = "Input File [*.zip]";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(271, 161);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(87, 20);
            this.outputFileLabel.TabIndex = 1;
            this.outputFileLabel.Text = "Output File";
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(68, 64);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(141, 53);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "Select Input File";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // outputFileButton
            // 
            this.outputFileButton.Location = new System.Drawing.Point(68, 142);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(141, 59);
            this.outputFileButton.TabIndex = 3;
            this.outputFileButton.Text = "Select Output File";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // decompButton
            // 
            this.decompButton.Location = new System.Drawing.Point(68, 233);
            this.decompButton.Name = "decompButton";
            this.decompButton.Size = new System.Drawing.Size(836, 60);
            this.decompButton.TabIndex = 4;
            this.decompButton.Text = "De-Compress and Create";
            this.decompButton.UseVisualStyleBackColor = true;
            this.decompButton.Click += new System.EventHandler(this.decompButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 342);
            this.Controls.Add(this.decompButton);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Name = "MainForm";
            this.Text = "Fody-Costura-Decompress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.Button decompButton;
    }
}

