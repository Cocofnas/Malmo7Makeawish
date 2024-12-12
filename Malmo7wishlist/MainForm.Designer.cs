using System.Windows.Forms;

namespace Malmo7wishlist
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMakeAWish = new Label();
            lblMakeAWishName = new Label();
            lblMakeAWishAge = new Label();
            lblMakeAWishRelationship = new Label();
            lstBoxMakeAWish = new ListBox();
            btnAddWisher = new Button();
            btnEditWisher = new Button();
            btnDeleteWisher = new Button();
            btnViewWishes = new Button();
            btnEditWishes = new Button();
            lblWisherID = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeAWish
            // 
            lblMakeAWish.AutoSize = true;
            lblMakeAWish.BackColor = Color.Transparent;
            lblMakeAWish.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeAWish.ForeColor = SystemColors.HighlightText;
            lblMakeAWish.Location = new Point(106, 70);
            lblMakeAWish.Name = "lblMakeAWish";
            lblMakeAWish.Size = new Size(192, 41);
            lblMakeAWish.TabIndex = 0;
            lblMakeAWish.Text = "Make a wish";
            // 
            // lblMakeAWishName
            // 
            lblMakeAWishName.AutoSize = true;
            lblMakeAWishName.BackColor = Color.Transparent;
            lblMakeAWishName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeAWishName.ForeColor = SystemColors.HighlightText;
            lblMakeAWishName.Location = new Point(247, 157);
            lblMakeAWishName.Name = "lblMakeAWishName";
            lblMakeAWishName.Size = new Size(68, 28);
            lblMakeAWishName.TabIndex = 1;
            lblMakeAWishName.Text = "Name";
            // 
            // lblMakeAWishAge
            // 
            lblMakeAWishAge.AutoSize = true;
            lblMakeAWishAge.BackColor = Color.Transparent;
            lblMakeAWishAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeAWishAge.ForeColor = SystemColors.HighlightText;
            lblMakeAWishAge.Location = new Point(460, 157);
            lblMakeAWishAge.Name = "lblMakeAWishAge";
            lblMakeAWishAge.Size = new Size(49, 28);
            lblMakeAWishAge.TabIndex = 2;
            lblMakeAWishAge.Text = "Age";
            // 
            // lblMakeAWishRelationship
            // 
            lblMakeAWishRelationship.AutoSize = true;
            lblMakeAWishRelationship.BackColor = Color.Transparent;
            lblMakeAWishRelationship.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeAWishRelationship.ForeColor = SystemColors.HighlightText;
            lblMakeAWishRelationship.Location = new Point(653, 157);
            lblMakeAWishRelationship.Name = "lblMakeAWishRelationship";
            lblMakeAWishRelationship.Size = new Size(130, 28);
            lblMakeAWishRelationship.TabIndex = 3;
            lblMakeAWishRelationship.Text = "Relationship";
            // 
            // lstBoxMakeAWish
            // 
            lstBoxMakeAWish.BackColor = SystemColors.HighlightText;
            lstBoxMakeAWish.DrawMode = DrawMode.OwnerDrawFixed;
            lstBoxMakeAWish.FormattingEnabled = true;
            lstBoxMakeAWish.Location = new Point(106, 213);
            lstBoxMakeAWish.Name = "lstBoxMakeAWish";
            lstBoxMakeAWish.Size = new Size(736, 344);
            lstBoxMakeAWish.TabIndex = 4;
            lstBoxMakeAWish.DrawItem += ListBox_DrawItem;
            // 
            // btnAddWisher
            // 
            btnAddWisher.BackColor = Color.CadetBlue;
            btnAddWisher.FlatStyle = FlatStyle.Popup;
            btnAddWisher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWisher.Location = new Point(106, 587);
            btnAddWisher.Name = "btnAddWisher";
            btnAddWisher.Size = new Size(134, 29);
            btnAddWisher.TabIndex = 5;
            btnAddWisher.Text = "Add Wisher";
            btnAddWisher.UseVisualStyleBackColor = false;
            // 
            // btnEditWisher
            // 
            btnEditWisher.BackColor = Color.CadetBlue;
            btnEditWisher.FlatStyle = FlatStyle.Popup;
            btnEditWisher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditWisher.Location = new Point(401, 587);
            btnEditWisher.Name = "btnEditWisher";
            btnEditWisher.Size = new Size(134, 29);
            btnEditWisher.TabIndex = 6;
            btnEditWisher.Text = "Edit Wisher";
            btnEditWisher.UseVisualStyleBackColor = false;
            // 
            // btnDeleteWisher
            // 
            btnDeleteWisher.BackColor = Color.CadetBlue;
            btnDeleteWisher.FlatStyle = FlatStyle.Popup;
            btnDeleteWisher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteWisher.Location = new Point(708, 587);
            btnDeleteWisher.Name = "btnDeleteWisher";
            btnDeleteWisher.Size = new Size(134, 29);
            btnDeleteWisher.TabIndex = 7;
            btnDeleteWisher.Text = "Delete Wisher";
            btnDeleteWisher.UseVisualStyleBackColor = false;
            // 
            // btnViewWishes
            // 
            btnViewWishes.BackColor = Color.CadetBlue;
            btnViewWishes.FlatStyle = FlatStyle.Popup;
            btnViewWishes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewWishes.Location = new Point(558, 653);
            btnViewWishes.Name = "btnViewWishes";
            btnViewWishes.Size = new Size(134, 29);
            btnViewWishes.TabIndex = 8;
            btnViewWishes.Text = "View Wishes";
            btnViewWishes.UseVisualStyleBackColor = false;
            // 
            // btnEditWishes
            // 
            btnEditWishes.BackColor = Color.CadetBlue;
            btnEditWishes.FlatStyle = FlatStyle.Popup;
            btnEditWishes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditWishes.Location = new Point(247, 653);
            btnEditWishes.Name = "btnEditWishes";
            btnEditWishes.Size = new Size(134, 29);
            btnEditWishes.TabIndex = 9;
            btnEditWishes.Text = "Add/Edit Wishes";
            btnEditWishes.UseVisualStyleBackColor = false;
            // 
            // lblWisherID
            // 
            lblWisherID.AutoSize = true;
            lblWisherID.BackColor = Color.Transparent;
            lblWisherID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWisherID.ForeColor = SystemColors.HighlightText;
            lblWisherID.Location = new Point(106, 157);
            lblWisherID.Name = "lblWisherID";
            lblWisherID.Size = new Size(33, 28);
            lblWisherID.TabIndex = 10;
            lblWisherID.Text = "ID";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1414, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitAltF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            newCtrlNToolStripMenuItem.Size = new Size(204, 26);
            newCtrlNToolStripMenuItem.Text = "New      Ctrl+N";
            newCtrlNToolStripMenuItem.Click += newCtrlNToolStripMenuItem_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(204, 26);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(204, 26);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
           

            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(204, 26);
            exitAltF4ToolStripMenuItem.Text = "Exit           Alt+F4";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wish;
            ClientSize = new Size(1414, 703);
            Controls.Add(lblWisherID);
            Controls.Add(btnEditWishes);
            Controls.Add(btnViewWishes);
            Controls.Add(btnDeleteWisher);
            Controls.Add(btnEditWisher);
            Controls.Add(btnAddWisher);
            Controls.Add(lstBoxMakeAWish);
            Controls.Add(lblMakeAWishRelationship);
            Controls.Add(lblMakeAWishAge);
            Controls.Add(lblMakeAWishName);
            Controls.Add(lblMakeAWish);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMakeAWish;
        private Label lblMakeAWishName;
        private Label lblMakeAWishAge;
        private Label lblMakeAWishRelationship;
        private ListBox lstBoxMakeAWish;
        private Button btnAddWisher;
        private Button btnEditWisher;
        private Button btnDeleteWisher;
        private Button btnViewWishes;
        private Button btnEditWishes;
        private Label lblWisherID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private object listBoxMakeAWish;
    }
}