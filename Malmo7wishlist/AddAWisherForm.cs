using System;
using System.Windows.Forms;

namespace Malmo7wishlist
{
    /// <summary>
    /// Represents a form for adding or editing a wisher.
    /// </summary>
    public partial class AddAWisherForm : Form
    {
        /// <summary>
        /// Does so the wisher can be created or edited in the form.
        /// </summary>
        public Wisher Wisher { get; private set; }
        private ToolTip toolTip;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAWisherForm"/> class.
        /// </summary>
        public AddAWisherForm(Wisher wisher = null)
        {
            InitializeComponent();

            // Initialize ToolTip
            toolTip = new ToolTip
            {
                IsBalloon = true,
                BackColor = System.Drawing.Color.LightYellow,
                ForeColor = System.Drawing.Color.Black
            };

            // Set up tooltips for controls
            toolTip.SetToolTip(txtBoxAddAName, "The name of the wisher?");
            toolTip.SetToolTip(txtBoxAddAAge, "The age of the wisher (in numbers)?.");
            toolTip.SetToolTip(cmbBoxAddARelationship, "What's your relationship with the wisher?.");
            toolTip.SetToolTip(btnAddASave, "Click to save the wisher.");
            toolTip.SetToolTip(btnClose, "Click to cancel and close the form.");

            // Initialize relationship options
            cmbBoxAddARelationship.Items.AddRange(new string[]
            {
                "Family",
                "Friend",
                "Colleague",
                "School",
                "Other"
            });

            // Pre-fill fields if editing an existing wisher
            if (wisher != null)
            {
                txtBoxAddAName.Text = wisher.Name;
                txtBoxAddAAge.Text = wisher.Age.ToString();
                cmbBoxAddARelationship.SelectedItem = wisher.Relationship;
                Wisher = wisher;
            }
            else
            {
                // Set a default value for the relationship ComboBox
                cmbBoxAddARelationship.SelectedItem = "Family";
            }
        }
        /// <summary>
        /// Handles the Save button click event.
        /// Validates the input and saves the wisher details.
        /// </summary>
        private void btnAddASave_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtBoxAddAName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBoxAddAAge.Text, out var age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBoxAddARelationship.SelectedItem == null)
            {
                MessageBox.Show("Please select a relationship.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create or update the Wisher object
            if (Wisher == null)
            {
                Wisher = new Wisher();
            }

            Wisher.Name = txtBoxAddAName.Text;
            Wisher.Age = age;
            Wisher.Relationship = cmbBoxAddARelationship.SelectedItem.ToString();

      

            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Handles the Close button event handler.
        /// Closes the form without saving changes.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
