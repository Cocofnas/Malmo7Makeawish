using System;
using System.Drawing;
using System.Windows.Forms;

namespace Malmo7wishlist
{
    /// <summary>
    /// Represents the form for managing a wisher's wish list.
    /// </summary>
    public partial class WishListForm : Form
    {
        private Wisher _currentWisher;
        private ToolTip toolTip;

        /// <summary>
        /// Initializes a new instance of the <see cref="WishListForm"/> class.
        /// </summary>
        /// <param name="wisher">The wisher whose wishlist is being managed.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="wisher"/> is null.</exception>
        public WishListForm(Wisher wisher)
        {
            InitializeComponent();

            // Initialize ToolTip
            toolTip = new ToolTip
            {
                IsBalloon = true,
                BackColor = Color.LightYellow,
                ForeColor = Color.Black
            };

            // Set up ToolTips for buttons
            toolTip.SetToolTip(btnAddAddWish, "Click to add a new wish.");
            toolTip.SetToolTip(btnWishUpdateWish, "Click to update the selected wish. But first select a wish to edit.");
            toolTip.SetToolTip(btnDeleteList, "Click to delete a wish from the list.");
            toolTip.SetToolTip(btnWishListClose, "Click to close the wish list.");

            _currentWisher = wisher ?? throw new ArgumentNullException(nameof(wisher));
            RefreshWishList();

            // Attach SelectedIndexChanged event
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles the form's Load event. Configures the ListBox for custom drawing.
        /// </summary>
        private void WishListForm_Load(object sender, EventArgs e)
        {
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += ListBox1_DrawItem;
        }

        /// <summary>
        /// Handles the columns of the ListBox items.
        /// </summary>
        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index < 0) return;

            // Retrieve the current Item
            if (listBox1.Items[e.Index] is Item item)
            {
                // Define column widths
                int nameColumnWidth = 190;
                int descriptionColumnWidth = 200;
                int whereToBuyColumnWidth = 250;
                int priceColumnWidth = 100;

                // Define text to display
                string nameText = item.Name;
                string descriptionText = item.Description;
                string whereToBuyText = item.WhereToBuy;
                string priceText = $"{item.Price:C}";

                // Draw each column
                e.Graphics.DrawString(nameText, e.Font, Brushes.Black, e.Bounds.Left + 5, e.Bounds.Top);
                e.Graphics.DrawString(descriptionText, e.Font, Brushes.Black, e.Bounds.Left + nameColumnWidth + 5, e.Bounds.Top);
                e.Graphics.DrawString(whereToBuyText, e.Font, Brushes.Black, e.Bounds.Left + nameColumnWidth + descriptionColumnWidth + 5, e.Bounds.Top);
                e.Graphics.DrawString(priceText, e.Font, Brushes.Black, e.Bounds.Left + nameColumnWidth + descriptionColumnWidth + whereToBuyColumnWidth + 5, e.Bounds.Top);
            }

            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Refreshes the wish list displayed in the ListBox.
        /// </summary>
        private void RefreshWishList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _currentWisher.WishList;
            listBox1.DisplayMember = "Name"; // Display wish name in the list
            listBox1.ClearSelected();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event for the ListBox. Populates textboxes with the selected wishdetails.
        /// </summary>
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Item selectedWish)
            {
                // Populate the textboxes with the selected wish details
                textBox1.Text = selectedWish.Name;
                textBox2.Text = selectedWish.Description;
                textBox3.Text = selectedWish.WhereToBuy;
                textBox4.Text = selectedWish.Price.ToString("F2");
            }
        }

        /// <summary>
        /// Handles the Add Wish button handler event. Adds a new wish to the list.
        /// </summary>
        private void btnAddAddWish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Wish Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newWish = new Item(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                decimal.TryParse(textBox4.Text, out var price) ? price : 0
            );

            _currentWisher.AddWish(newWish);
            RefreshWishList();
            ClearInputFields();
        }

        /// <summary>
        /// Handles the Delete Wish button handler event. Removes the selected wish from the list.
        /// </summary>
        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Item selectedWish)
            {
                var result = MessageBox.Show($"Are you sure you want to delete '{selectedWish.Name}'?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _currentWisher.RemoveWish(selectedWish);
                    RefreshWishList();
                }
            }
            else
            {
                MessageBox.Show("No wish selected for deletion.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the Update Wish button handler event. Updates the selected wish with new details.
        /// </summary>
        private void btnWishUpdateWish_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Item selectedWish)
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    !decimal.TryParse(textBox4.Text, out var price))
                {
                    MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the selected wish with the new details
                selectedWish.Name = textBox1.Text;
                selectedWish.Description = textBox2.Text;
                selectedWish.WhereToBuy = textBox3.Text;
                selectedWish.Price = price;

                RefreshWishList(); // Refresh the ListBox to reflect the updated details
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("No wish selected for updating.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the Close button handler event. Closes the wish list form.
        /// </summary>
        private void btnWishListClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears the input fields in the form.
        /// </summary>
        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
