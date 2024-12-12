using System;
using System.Windows.Forms;

namespace Malmo7wishlist
{
    /// <summary>
    /// Represents the About form of the application, providing information about the app and its author.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutForm"/> class.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            // Attach the click event to the Close button
            btnClose.Click += BtnClose_Click;
        }
        /// <summary>
        /// Event handler for the Close button.
        /// </summary>
       
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }
    }
}

