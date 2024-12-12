namespace Malmo7wishlist
{
    partial class AboutForm
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
            pictureBox1 = new PictureBox();
            lblCopyright = new Label();
            lblAboutDescription = new Label();
            lblAboutTitle = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.wish;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 536);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Location = new Point(34, 291);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(222, 20);
            lblCopyright.TabIndex = 7;
            lblCopyright.Text = "Copyright Alexandra Meija 2025";
            // 
            // lblAboutDescription
            // 
            lblAboutDescription.AutoSize = true;
            lblAboutDescription.BackColor = Color.CadetBlue;
            lblAboutDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAboutDescription.Location = new Point(34, 170);
            lblAboutDescription.Name = "lblAboutDescription";
            lblAboutDescription.Size = new Size(408, 28);
            lblAboutDescription.TabIndex = 6;
            lblAboutDescription.Text = "This is your chance to make wishes come true.";
            // 
            // lblAboutTitle
            // 
            lblAboutTitle.AutoSize = true;
            lblAboutTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAboutTitle.Location = new Point(34, 51);
            lblAboutTitle.Name = "lblAboutTitle";
            lblAboutTitle.Size = new Size(191, 38);
            lblAboutTitle.TabIndex = 5;
            lblAboutTitle.Text = "The Wish List";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(195, 480);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(617, 604);
            Controls.Add(btnClose);
            Controls.Add(lblCopyright);
            Controls.Add(lblAboutDescription);
            Controls.Add(lblAboutTitle);
            Controls.Add(pictureBox1);
            Name = "AboutForm";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCopyright;
        private Label lblAboutDescription;
        private Label lblAboutTitle;
        private Button btnClose;
    }
}