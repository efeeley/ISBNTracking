namespace HW6_1_EKF
{
    partial class About
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
            this.xAboutMeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xAboutMeTextBox
            // 
            this.xAboutMeTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.xAboutMeTextBox.Location = new System.Drawing.Point(13, 12);
            this.xAboutMeTextBox.Multiline = true;
            this.xAboutMeTextBox.Name = "xAboutMeTextBox";
            this.xAboutMeTextBox.ReadOnly = true;
            this.xAboutMeTextBox.Size = new System.Drawing.Size(137, 110);
            this.xAboutMeTextBox.TabIndex = 0;
            this.xAboutMeTextBox.Text = "Name: Elisabeth Feeley\r\n\r\nQuarter: Summer 2012\r\n\r\nClass: CSC 242\r\n\r\nDate: 8/30/20" +
    "12";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 132);
            this.Controls.Add(this.xAboutMeTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xAboutMeTextBox;
    }
}