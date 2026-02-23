using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Parse numeric fields safely
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a whole number.");
                return;
            }

            if (!double.TryParse(txtTotalPurchases.Text, out double purchases))
            {
                MessageBox.Show("Total Purchases must be a number.");
                return;
            }

            if (!int.TryParse(txtRewards.Text, out int rewards))
            {
                MessageBox.Show("Rewards must be a whole number.");
                return;
            }

            // Create the Customer object — validation runs inside the setters
            Customer c = new Customer(
                txtFName.Text,
                txtLName.Text,
                txtEmail.Text,
                age,
                txtCellPhone.Text,
                txtInstagram.Text,
                dtpCustomerSince.Value,
                purchases,
                chkDiscount.Checked,
                rewards
            );

            // Check feedback from the object
            if (!string.IsNullOrEmpty(c.Feedback))
            {
                txtOutput.Text = "Validation Errors:\n" + c.Feedback;
            }
            else
            {
                txtOutput.Text = "Customer saved successfully!\n\n" + c.ToString();
            }
        }
    }
}