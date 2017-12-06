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
            this.inputFileButton = new System.Windows.Forms.Button();
            this.decompButton = new System.Windows.Forms.Button();
            this.doneLabel = new System.Windows.Forms.Label();
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
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(68, 64);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(141, 53);
            this.inputFileButton.TabIndex = 2;
            this.inputFileButton.Text = "Select Input File";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // decompButton
            // 
            this.decompButton.Enabled = false;
            this.decompButton.Location = new System.Drawing.Point(68, 233);
            this.decompButton.Name = "decompButton";
            this.decompButton.Size = new System.Drawing.Size(836, 60);
            this.decompButton.TabIndex = 4;
            this.decompButton.Text = "De-Compress and Create";
            this.decompButton.UseVisualStyleBackColor = true;
            this.decompButton.Click += new System.EventHandler(this.DecompButton_Click);
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.ForeColor = System.Drawing.Color.Red;
            this.doneLabel.Location = new System.Drawing.Point(435, 304);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(71, 29);
            this.doneLabel.TabIndex = 5;
            this.doneLabel.Text = "Done";
            this.doneLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 342);
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.decompButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.inputFileLabel);
            this.Name = "MainForm";
            this.Text = "Fody-Costura-Decompress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Button decompButton;
        private System.Windows.Forms.Label doneLabel;
    }
}

