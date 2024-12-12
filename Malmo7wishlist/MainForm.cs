using System;
using System.Drawing;
using System.Windows.Forms;

namespace Malmo7wishlist
{
    /// <summary>
    /// Represents the main application form for managing wishers and their wishes.
    /// </summary>
    public partial class MainForm : Form
    {
        private ToolTip toolTip;

        public MainForm()
        {
            InitializeComponent();

            // Initialize the ToolTip
            toolTip = new ToolTip
            {
                IsBalloon = true,
                BackColor = Color.LightYellow,
                ForeColor = Color.Black
            };

            // Set up tooltips for buttons
            toolTip.SetToolTip(btnAddWisher, "Click to add a new wisher to the list");
            toolTip.SetToolTip(btnEditWisher, "Click to edit the selected wisher");
            toolTip.SetToolTip(btnDeleteWisher, "Click to delete the selected wisher");
            toolTip.SetToolTip(btnViewWishes, "Click to view the wishes of the selected wisher. You have to add a wisher first!");
            toolTip.SetToolTip(btnEditWishes, "Click to edit the wishes of the selected wisher. You have to add a wisher first!");


            // Hook up event handlers
            btnAddWisher.Click += btnAddWisher_Click;
            btnEditWisher.Click += btnEditWisher_Click;
            btnDeleteWisher.Click += btnDeleteWisher_Click;
            btnViewWishes.Click += btnViewWishes_Click;
            btnEditWishes.Click += btnEditWishes_Click;
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;

            // Load initial data
            RefreshWisherList();
        }
        /// <summary>
        /// Handles the form load event. Sets up the listbox for custom drawing.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            lstBoxMakeAWish.DrawMode = DrawMode.OwnerDrawFixed;
            lstBoxMakeAWish.DrawItem += ListBox_DrawItem;
        }
        /// <summary>
        /// Handles the columns in the listbox.
        /// </summary>
        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index < 0) return;

            if (lstBoxMakeAWish.Items[e.Index] is Wisher wisher)
            {
                // Define column widths
                int idColumnWidth = 150;
                int nameColumnWidth = 210;
                int ageColumnWidth = 200;
                int relationshipColumnWidth = 150;

                // Define text to display
                string idText = wisher.ID.ToString();
                string nameText = wisher.Name;
                string ageText = wisher.Age.ToString();
                string relationshipText = wisher.Relationship;

                // Draw each column with padding
                e.Graphics.DrawString(idText, e.Font, Brushes.Black, e.Bounds.Left + 5, e.Bounds.Top);
                e.Graphics.DrawString(nameText, e.Font, Brushes.Black, e.Bounds.Left + idColumnWidth + 5, e.Bounds.Top);
                e.Graphics.DrawString(ageText, e.Font, Brushes.Black, e.Bounds.Left + idColumnWidth + nameColumnWidth + 5, e.Bounds.Top);
                e.Graphics.DrawString(relationshipText, e.Font, Brushes.Black, e.Bounds.Left + idColumnWidth + nameColumnWidth + ageColumnWidth + 5, e.Bounds.Top);
            }

            e.DrawFocusRectangle();
        }
        /// <summary>
        /// Refreshes the wisher list in the listbox.
        /// </summary>
        private void RefreshWisherList()
        {
            lstBoxMakeAWish.DataSource = null;
            lstBoxMakeAWish.DataSource = WishManager.GetWishers();
            lstBoxMakeAWish.DisplayMember = string.Empty; // Disable default binding
        }
        /// <summary>
        /// Handles the Add Wisher button handler event.
        /// </summary>
        private void btnAddWisher_Click(object sender, EventArgs e)
        {
            var addForm = new AddAWisherForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                WishManager.AddWisher(addForm.Wisher);
                RefreshWisherList();
            }
        }
        /// <summary>
        /// Handles the Edit Wisher button handler event.
        /// </summary>
        private void btnEditWisher_Click(object sender, EventArgs e)
        {
            if (lstBoxMakeAWish.SelectedItem is Wisher selectedWisher)
            {
                var editForm = new AddAWisherForm(selectedWisher);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // No need to call UpdateWisher; the selectedWisher object is already updated
                    RefreshWisherList();
                }
            }
        }
        /// <summary>
        /// Handles the Delete Wisher button click event.
        /// </summary>
        private void btnDeleteWisher_Click(object sender, EventArgs e)
        {
            if (lstBoxMakeAWish.SelectedItem is Wisher selectedWisher)
            {
                if (MessageBox.Show($"Are you sure you want to delete '{selectedWisher.Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    WishManager.RemoveWisher(selectedWisher);
                    RefreshWisherList();
                }
            }
        }
        /// <summary>
        /// Handles the View wishes button handler event.
        /// </summary>
        private void btnViewWishes_Click(object sender, EventArgs e)
        {
            if (lstBoxMakeAWish.SelectedItem is Wisher selectedWisher)
            {
                var wishListForm = new WishListForm(selectedWisher);
                wishListForm.ShowDialog();
            }
        }
        /// <summary>
        /// Handles the Edit Wishes button handler event.
        /// </summary>
        private void btnEditWishes_Click(object sender, EventArgs e)
        {
            if (lstBoxMakeAWish.SelectedItem is Wisher selectedWisher)
            {
                var editWishListForm = new WishListForm(selectedWisher);
                editWishListForm.ShowDialog();
            }
        }
        /// <summary>
        /// Handles the About menu item handler event.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        /// <summary>
        /// Handles the Exit menu item handler event.
        /// </summary>
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handles the New menu item handler event to create a new wish list.
        /// </summary>
        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm with the user before clearing all data
                var result = MessageBox.Show("Are you sure you want to create a new wish list? This will clear all current data.",
                                             "Confirm New", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Clear all wishers
                    WishManager.ClearAllWishers();

                    // Refresh the list to reflect the changes
                    RefreshWisherList();

                    MessageBox.Show("New wish list created successfully!", "New List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create new wish list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Save Data File menu item handler event.
        /// </summary>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "WishList Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.FileName = "wishlist.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WishManager.SaveToFile(saveFileDialog.FileName);
                        MessageBox.Show("Data saved successfully!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Handles the Open Data File menu item handler event.
        /// </summary>
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WishList Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        WishManager.LoadFromFile(openFileDialog.FileName);
                        RefreshWisherList();
                        MessageBox.Show("Data loaded successfully!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
