namespace HW6_1_EKF
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
            this.xPromptLabel = new System.Windows.Forms.Label();
            this.xISBNTextBox = new System.Windows.Forms.TextBox();
            this.xCheckButton = new System.Windows.Forms.Button();
            this.xAboutLabel = new System.Windows.Forms.Label();
            this.xHelpLabel = new System.Windows.Forms.Label();
            this.xResultsLabel = new System.Windows.Forms.Label();
            this.xResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xPromptLabel
            // 
            this.xPromptLabel.AutoSize = true;
            this.xPromptLabel.Location = new System.Drawing.Point(12, 9);
            this.xPromptLabel.Name = "xPromptLabel";
            this.xPromptLabel.Size = new System.Drawing.Size(86, 13);
            this.xPromptLabel.TabIndex = 0;
            this.xPromptLabel.Text = "Enter your ISBN:";
            // 
            // xISBNTextBox
            // 
            this.xISBNTextBox.Location = new System.Drawing.Point(15, 35);
            this.xISBNTextBox.MaxLength = 15;
            this.xISBNTextBox.Name = "xISBNTextBox";
            this.xISBNTextBox.Size = new System.Drawing.Size(176, 20);
            this.xISBNTextBox.TabIndex = 1;
            // 
            // xCheckButton
            // 
            this.xCheckButton.Location = new System.Drawing.Point(197, 32);
            this.xCheckButton.Name = "xCheckButton";
            this.xCheckButton.Size = new System.Drawing.Size(75, 23);
            this.xCheckButton.TabIndex = 2;
            this.xCheckButton.Text = "Check!";
            this.xCheckButton.UseVisualStyleBackColor = true;
            this.xCheckButton.Click += new System.EventHandler(this.xCheckButton_Click);
            // 
            // xAboutLabel
            // 
            this.xAboutLabel.AutoSize = true;
            this.xAboutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xAboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAboutLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xAboutLabel.Location = new System.Drawing.Point(12, 149);
            this.xAboutLabel.Name = "xAboutLabel";
            this.xAboutLabel.Size = new System.Drawing.Size(53, 13);
            this.xAboutLabel.TabIndex = 3;
            this.xAboutLabel.Text = "About Me";
            this.xAboutLabel.Click += new System.EventHandler(this.xAboutLabel_Click);
            // 
            // xHelpLabel
            // 
            this.xHelpLabel.AutoSize = true;
            this.xHelpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xHelpLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xHelpLabel.Location = new System.Drawing.Point(243, 149);
            this.xHelpLabel.Name = "xHelpLabel";
            this.xHelpLabel.Size = new System.Drawing.Size(29, 13);
            this.xHelpLabel.TabIndex = 4;
            this.xHelpLabel.Text = "Help";
            this.xHelpLabel.Click += new System.EventHandler(this.xHelpLabel_Click);
            // 
            // xResultsLabel
            // 
            this.xResultsLabel.AutoSize = true;
            this.xResultsLabel.Location = new System.Drawing.Point(12, 69);
            this.xResultsLabel.Name = "xResultsLabel";
            this.xResultsLabel.Size = new System.Drawing.Size(45, 13);
            this.xResultsLabel.TabIndex = 5;
            this.xResultsLabel.Text = "Results:";
            // 
            // xResultsTextBox
            // 
            this.xResultsTextBox.Location = new System.Drawing.Point(12, 85);
            this.xResultsTextBox.Multiline = true;
            this.xResultsTextBox.Name = "xResultsTextBox";
            this.xResultsTextBox.ReadOnly = true;
            this.xResultsTextBox.Size = new System.Drawing.Size(260, 61);
            this.xResultsTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.xResultsTextBox);
            this.Controls.Add(this.xResultsLabel);
            this.Controls.Add(this.xHelpLabel);
            this.Controls.Add(this.xAboutLabel);
            this.Controls.Add(this.xCheckButton);
            this.Controls.Add(this.xISBNTextBox);
            this.Controls.Add(this.xPromptLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xPromptLabel;
        private System.Windows.Forms.TextBox xISBNTextBox;
        private System.Windows.Forms.Button xCheckButton;
        private System.Windows.Forms.Label xAboutLabel;
        private System.Windows.Forms.Label xHelpLabel;
        private System.Windows.Forms.Label xResultsLabel;
        private System.Windows.Forms.TextBox xResultsTextBox;
    }
}