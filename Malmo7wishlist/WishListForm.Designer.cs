
namespace Malmo7wishlist
{
    partial class WishListForm
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
            label1 = new Label();
            listBox1 = new ListBox();
            lblWishListFormWishName = new Label();
            lblWishListFormDescription = new Label();
            lblWishListFormWhereToBuy = new Label();
            lblWishListFormPrice = new Label();
            btnDeleteList = new Button();
            grpBoxWishes = new GroupBox();
            btnWishUpdateWish = new Button();
            grpBoxAddEdit = new GroupBox();
            btnAddAddWish = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            lblWishAddPrice = new Label();
            lblWishAddWhereToBuy = new Label();
            lblWishAddDescription = new Label();
            lblWishAddWish = new Label();
            textBox1 = new TextBox();
            btnWishListClose = new Button();
            grpBoxWishes.SuspendLayout();
            grpBoxAddEdit.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(360, 41);
            label1.TabIndex = 0;
            label1.Text = "Where wishes come true";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(89, 147);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(782, 304);
            listBox1.TabIndex = 1;
            listBox1.DrawItem += ListBox1_DrawItem;
            // 
            // lblWishListFormWishName
            // 
            lblWishListFormWishName.AutoSize = true;
            lblWishListFormWishName.BackColor = Color.Transparent;
            lblWishListFormWishName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWishListFormWishName.ForeColor = SystemColors.HighlightText;
            lblWishListFormWishName.Location = new Point(89, 95);
            lblWishListFormWishName.Name = "lblWishListFormWishName";
            lblWishListFormWishName.Size = new Size(59, 28);
            lblWishListFormWishName.TabIndex = 2;
            lblWishListFormWishName.Text = "Wish";
            // 
            // lblWishListFormDescription
            // 
            lblWishListFormDescription.AutoSize = true;
            lblWishListFormDescription.BackColor = Color.Transparent;
            lblWishListFormDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWishListFormDescription.ForeColor = SystemColors.HighlightText;
            lblWishListFormDescription.Location = new Point(277, 95);
            lblWishListFormDescription.Name = "lblWishListFormDescription";
            lblWishListFormDescription.Size = new Size(121, 28);
            lblWishListFormDescription.TabIndex = 3;
            lblWishListFormDescription.Text = "Description";
            // 
            // lblWishListFormWhereToBuy
            // 
            lblWishListFormWhereToBuy.AutoSize = true;
            lblWishListFormWhereToBuy.BackColor = Color.Transparent;
            lblWishListFormWhereToBuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWishListFormWhereToBuy.ForeColor = SystemColors.HighlightText;
            lblWishListFormWhereToBuy.Location = new Point(463, 95);
            lblWishListFormWhereToBuy.Name = "lblWishListFormWhereToBuy";
            lblWishListFormWhereToBuy.Size = new Size(141, 28);
            lblWishListFormWhereToBuy.TabIndex = 4;
            lblWishListFormWhereToBuy.Text = "Where to buy";
            // 
            // lblWishListFormPrice
            // 
            lblWishListFormPrice.AutoSize = true;
            lblWishListFormPrice.BackColor = Color.Transparent;
            lblWishListFormPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWishListFormPrice.ForeColor = SystemColors.HighlightText;
            lblWishListFormPrice.Location = new Point(732, 95);
            lblWishListFormPrice.Name = "lblWishListFormPrice";
            lblWishListFormPrice.Size = new Size(59, 28);
            lblWishListFormPrice.TabIndex = 5;
            lblWishListFormPrice.Text = "Price";
            // 
            // btnDeleteList
            // 
            btnDeleteList.BackColor = Color.CadetBlue;
            btnDeleteList.FlatStyle = FlatStyle.Popup;
            btnDeleteList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteList.ForeColor = SystemColors.ControlText;
            btnDeleteList.Location = new Point(276, 404);
            btnDeleteList.Name = "btnDeleteList";
            btnDeleteList.Size = new Size(153, 29);
            btnDeleteList.TabIndex = 6;
            btnDeleteList.Text = "Delete wish";
            btnDeleteList.UseVisualStyleBackColor = false;
            btnDeleteList.Click += btnDeleteList_Click;
            // 
            // grpBoxWishes
            // 
            grpBoxWishes.BackColor = Color.Transparent;
            grpBoxWishes.Controls.Add(btnDeleteList);
            grpBoxWishes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxWishes.ForeColor = SystemColors.HighlightText;
            grpBoxWishes.Location = new Point(71, 62);
            grpBoxWishes.Name = "grpBoxWishes";
            grpBoxWishes.Size = new Size(833, 454);
            grpBoxWishes.TabIndex = 7;
            grpBoxWishes.TabStop = false;
            // 
            // btnWishUpdateWish
            // 
            btnWishUpdateWish.BackColor = Color.CadetBlue;
            btnWishUpdateWish.FlatStyle = FlatStyle.Popup;
            btnWishUpdateWish.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWishUpdateWish.ForeColor = SystemColors.ControlText;
            btnWishUpdateWish.Location = new Point(151, 351);
            btnWishUpdateWish.Name = "btnWishUpdateWish";
            btnWishUpdateWish.Size = new Size(148, 29);
            btnWishUpdateWish.TabIndex = 9;
            btnWishUpdateWish.Text = "Update wish";
            btnWishUpdateWish.UseVisualStyleBackColor = false;
            btnWishUpdateWish.Click += btnWishUpdateWish_Click;
            // 
            // grpBoxAddEdit
            // 
            grpBoxAddEdit.BackColor = Color.Transparent;
            grpBoxAddEdit.Controls.Add(btnAddAddWish);
            grpBoxAddEdit.Controls.Add(btnWishUpdateWish);
            grpBoxAddEdit.Controls.Add(textBox4);
            grpBoxAddEdit.Controls.Add(textBox3);
            grpBoxAddEdit.Controls.Add(textBox2);
            grpBoxAddEdit.Controls.Add(lblWishAddPrice);
            grpBoxAddEdit.Controls.Add(lblWishAddWhereToBuy);
            grpBoxAddEdit.Controls.Add(lblWishAddDescription);
            grpBoxAddEdit.Controls.Add(lblWishAddWish);
            grpBoxAddEdit.Controls.Add(textBox1);
            grpBoxAddEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxAddEdit.ForeColor = SystemColors.HighlightText;
            grpBoxAddEdit.Location = new Point(71, 545);
            grpBoxAddEdit.Name = "grpBoxAddEdit";
            grpBoxAddEdit.Size = new Size(850, 414);
            grpBoxAddEdit.TabIndex = 8;
            grpBoxAddEdit.TabStop = false;
            grpBoxAddEdit.Text = "Add/edit wish";
            // 
            // btnAddAddWish
            // 
            btnAddAddWish.BackColor = Color.CadetBlue;
            btnAddAddWish.FlatStyle = FlatStyle.Popup;
            btnAddAddWish.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddAddWish.ForeColor = SystemColors.ControlText;
            btnAddAddWish.Location = new Point(392, 351);
            btnAddAddWish.Name = "btnAddAddWish";
            btnAddAddWish.Size = new Size(148, 29);
            btnAddAddWish.TabIndex = 8;
            btnAddAddWish.Text = "Add wish";
            btnAddAddWish.UseVisualStyleBackColor = false;
            btnAddAddWish.Click += btnAddAddWish_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(206, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 34);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 34);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 115);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 82);
            textBox2.TabIndex = 5;
            // 
            // lblWishAddPrice
            // 
            lblWishAddPrice.AutoSize = true;
            lblWishAddPrice.Location = new Point(44, 283);
            lblWishAddPrice.Name = "lblWishAddPrice";
            lblWishAddPrice.Size = new Size(59, 28);
            lblWishAddPrice.TabIndex = 4;
            lblWishAddPrice.Text = "Price";
            // 
            // lblWishAddWhereToBuy
            // 
            lblWishAddWhereToBuy.AutoSize = true;
            lblWishAddWhereToBuy.Location = new Point(44, 222);
            lblWishAddWhereToBuy.Name = "lblWishAddWhereToBuy";
            lblWishAddWhereToBuy.Size = new Size(141, 28);
            lblWishAddWhereToBuy.TabIndex = 3;
            lblWishAddWhereToBuy.Text = "Where to buy";
            // 
            // lblWishAddDescription
            // 
            lblWishAddDescription.AutoSize = true;
            lblWishAddDescription.Location = new Point(44, 118);
            lblWishAddDescription.Name = "lblWishAddDescription";
            lblWishAddDescription.Size = new Size(121, 28);
            lblWishAddDescription.TabIndex = 2;
            lblWishAddDescription.Text = "Description";
            // 
            // lblWishAddWish
            // 
            lblWishAddWish.AutoSize = true;
            lblWishAddWish.Location = new Point(44, 58);
            lblWishAddWish.Name = "lblWishAddWish";
            lblWishAddWish.Size = new Size(59, 28);
            lblWishAddWish.TabIndex = 1;
            lblWishAddWish.Text = "Wish";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 34);
            textBox1.TabIndex = 0;
            // 
            // btnWishListClose
            // 
            btnWishListClose.BackColor = Color.CadetBlue;
            btnWishListClose.FlatStyle = FlatStyle.Popup;
            btnWishListClose.Location = new Point(810, 12);
            btnWishListClose.Name = "btnWishListClose";
            btnWishListClose.Size = new Size(94, 29);
            btnWishListClose.TabIndex = 9;
            btnWishListClose.Text = "Close";
            btnWishListClose.UseVisualStyleBackColor = false;
            btnWishListClose.Click += btnWishListClose_Click;
            // 
            // WishListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.wish;
            ClientSize = new Size(1057, 971);
            Controls.Add(btnWishListClose);
            Controls.Add(grpBoxAddEdit);
            Controls.Add(lblWishListFormPrice);
            Controls.Add(lblWishListFormWhereToBuy);
            Controls.Add(lblWishListFormDescription);
            Controls.Add(lblWishListFormWishName);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(grpBoxWishes);
            Name = "WishListForm";
            Text = "WishListForm";
            grpBoxWishes.ResumeLayout(false);
            grpBoxAddEdit.ResumeLayout(false);
            grpBoxAddEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ListBox listBox1;
        private Label lblWishListFormWishName;
        private Label lblWishListFormDescription;
        private Label lblWishListFormWhereToBuy;
        private Label lblWishListFormPrice;
        private Button btnDeleteList;
        private GroupBox grpBoxWishes;
        private GroupBox grpBoxAddEdit;
        private Label lblWishAddPrice;
        private Label lblWishAddWhereToBuy;
        private Label lblWishAddDescription;
        private Label lblWishAddWish;
        private TextBox textBox1;
        private Button btnWishUpdateWish;
        private Button btnAddAddWish;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private string v;
        private Button btnWishListClose;
    }
}