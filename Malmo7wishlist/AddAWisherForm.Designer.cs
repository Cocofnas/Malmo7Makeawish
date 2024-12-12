namespace Malmo7wishlist
{
    partial class AddAWisherForm
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
            lblAddAWisherTitle = new Label();
            lblAddAName = new Label();
            lblAddAAge = new Label();
            lblAddARelationship = new Label();
            btnAddASave = new Button();
            cmbBoxAddARelationship = new ComboBox();
            txtBoxAddAName = new TextBox();
            btnClose = new Button();
            txtBoxAddAAge = new TextBox();
            SuspendLayout();
            // 
            // lblAddAWisherTitle
            // 
            lblAddAWisherTitle.AutoSize = true;
            lblAddAWisherTitle.BackColor = Color.Transparent;
            lblAddAWisherTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAWisherTitle.ForeColor = SystemColors.HighlightText;
            lblAddAWisherTitle.Location = new Point(87, 66);
            lblAddAWisherTitle.Name = "lblAddAWisherTitle";
            lblAddAWisherTitle.Size = new Size(201, 41);
            lblAddAWisherTitle.TabIndex = 0;
            lblAddAWisherTitle.Text = "Add a wisher";
            // 
            // lblAddAName
            // 
            lblAddAName.AutoSize = true;
            lblAddAName.BackColor = Color.Transparent;
            lblAddAName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAName.ForeColor = SystemColors.HighlightText;
            lblAddAName.Location = new Point(101, 154);
            lblAddAName.Name = "lblAddAName";
            lblAddAName.Size = new Size(66, 28);
            lblAddAName.TabIndex = 1;
            lblAddAName.Text = "Name";
            // 
            // lblAddAAge
            // 
            lblAddAAge.AutoSize = true;
            lblAddAAge.BackColor = Color.Transparent;
            lblAddAAge.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAAge.ForeColor = SystemColors.HighlightText;
            lblAddAAge.Location = new Point(101, 214);
            lblAddAAge.Name = "lblAddAAge";
            lblAddAAge.Size = new Size(48, 28);
            lblAddAAge.TabIndex = 2;
            lblAddAAge.Text = "Age";
            // 
            // lblAddARelationship
            // 
            lblAddARelationship.AutoSize = true;
            lblAddARelationship.BackColor = Color.Transparent;
            lblAddARelationship.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddARelationship.ForeColor = SystemColors.HighlightText;
            lblAddARelationship.Location = new Point(98, 275);
            lblAddARelationship.Name = "lblAddARelationship";
            lblAddARelationship.Size = new Size(123, 28);
            lblAddARelationship.TabIndex = 3;
            lblAddARelationship.Text = "Relationship";
            // 
            // btnAddASave
            // 
            btnAddASave.BackColor = Color.CadetBlue;
            btnAddASave.FlatStyle = FlatStyle.Popup;
            btnAddASave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddASave.Location = new Point(234, 408);
            btnAddASave.Name = "btnAddASave";
            btnAddASave.Size = new Size(94, 29);
            btnAddASave.TabIndex = 4;
            btnAddASave.Text = "Save";
            btnAddASave.UseVisualStyleBackColor = false;
            btnAddASave.Click += btnAddASave_Click;
            // 
            // cmbBoxAddARelationship
            // 
            cmbBoxAddARelationship.FormattingEnabled = true;
            cmbBoxAddARelationship.Location = new Point(276, 282);
            cmbBoxAddARelationship.Name = "cmbBoxAddARelationship";
            cmbBoxAddARelationship.Size = new Size(382, 28);
            cmbBoxAddARelationship.TabIndex = 5;
            // 
            // txtBoxAddAName
            // 
            txtBoxAddAName.BackColor = SystemColors.HighlightText;
            txtBoxAddAName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAddAName.Location = new Point(276, 161);
            txtBoxAddAName.Name = "txtBoxAddAName";
            txtBoxAddAName.Size = new Size(382, 34);
            txtBoxAddAName.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.CadetBlue;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.Location = new Point(467, 408);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;

            // 
            // txtBoxAddAAge
            // 
            txtBoxAddAAge.BackColor = SystemColors.HighlightText;
            txtBoxAddAAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAddAAge.Location = new Point(276, 221);
            txtBoxAddAAge.Name = "txtBoxAddAAge";
            txtBoxAddAAge.Size = new Size(382, 34);
            txtBoxAddAAge.TabIndex = 7;
            // 
            // AddAWisherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wish;
            ClientSize = new Size(1161, 671);
            Controls.Add(btnClose);
            Controls.Add(txtBoxAddAAge);
            Controls.Add(txtBoxAddAName);
            Controls.Add(cmbBoxAddARelationship);
            Controls.Add(btnAddASave);
            Controls.Add(lblAddARelationship);
            Controls.Add(lblAddAAge);
            Controls.Add(lblAddAName);
            Controls.Add(lblAddAWisherTitle);
            Name = "AddAWisherForm";
            Text = "AddAWisher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddAWisherTitle;
        private Label lblAddAName;
        private Label lblAddAAge;
        private Label lblAddARelationship;
        private Button btnAddASave;
        private ComboBox cmbBoxAddARelationship;
        private TextBox txtBoxAddAName;
        private Button btnClose;
        private TextBox txtBoxAddAAge;
    }
}