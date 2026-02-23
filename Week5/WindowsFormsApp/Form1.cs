using System;
using System.Windows.Forms;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Customer _confirmedCustomer = null;
        public Form1()
        {
            InitializeComponent();
        }
        private string ValidateCustomer(Customer c)
        {
            c.Feedback = "";
            try
            {
                c.FirstName = txtfname.Text;
                c.Feedback += "First Name:      OK" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                c.Feedback += "First Name:      ERROR - " + ex.Message + Environment.NewLine;
            }
            try
            {
                c.LastName = txtlname.Text;
                c.Feedback += "Last Name:       OK" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                c.Feedback += "Last Name:       ERROR - " + ex.Message + Environment.NewLine;
            }
            c.Email = txtemail.Text;
            if (!WindowsFormsApp.Validate.IsValidEmail(c.Email))
                c.Feedback += "Email:           ERROR - Invalid format (ex: Bob@gmail.com)" + Environment.NewLine;
            else
                c.Feedback += "Email:           OK" + Environment.NewLine;
            c.StateCode = txtstate.Text.Trim().ToUpper();
            if (c.StateCode.Length != 2 || !char.IsLetter(c.StateCode[0]) || !char.IsLetter(c.StateCode[1]))
                c.Feedback += "State:           ERROR - Must be 2 letters (ex: MA)" + Environment.NewLine;
            else
                c.Feedback += "State:           OK" + Environment.NewLine;
            c.Zip = txtzip.Text.Trim();
            if (c.Zip.Length != 5 || !int.TryParse(c.Zip, out _))
                c.Feedback += "ZIP:             ERROR - Must be 5 digits (ex: 02886)" + Environment.NewLine;
            else
                c.Feedback += "ZIP:             OK" + Environment.NewLine;
            try
            {
                c.CellPhone = textBox1.Text;
                c.Feedback += "Cell Phone:      OK" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                c.Feedback += "Cell Phone:      ERROR - " + ex.Message + Environment.NewLine;
            }
            try
            {
                c.InstagramURL = txtInstagramURL.Text;
                c.Feedback += "Instagram URL:   OK" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                c.Feedback += "Instagram URL:   ERROR - " + ex.Message + Environment.NewLine;
            }
            if (DateTime.TryParse(txtCustomerSince.Text, out DateTime since))
            {
                try
                {
                    c.CustomerSince = since;
                    c.Feedback += "Customer Since:  OK" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    c.Feedback += "Customer Since:  ERROR - " + ex.Message + Environment.NewLine;
                }
            }
            else
            {
                c.Feedback += "Customer Since:  ERROR - Must be a valid date (ex: 01/15/2020)" + Environment.NewLine;
            }
            if (double.TryParse(txtTotalPurchases.Text, out double purchases))
            {
                try
                {
                    c.TotalPurchases = purchases;
                    c.Feedback += "Total Purchases: OK" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    c.Feedback += "Total Purchases: ERROR - " + ex.Message + Environment.NewLine;
                }
            }
            else
            {
                c.Feedback += "Total Purchases: ERROR - Must be a number (ex: 250.00)" + Environment.NewLine;
            }
            c.DiscountMember = chkDiscountMember.Checked;
            c.Feedback += "Discount Member: " + (c.DiscountMember ? "Yes" : "No") + " (OK)" + Environment.NewLine;
            if (int.TryParse(txtRewardsEarned.Text, out int rewards))
            {
                try
                {
                    c.RewardsEarned = rewards;
                    c.Feedback += "Rewards Earned:  OK" + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    c.Feedback += "Rewards Earned:  ERROR - " + ex.Message + Environment.NewLine;
                }
            }
            else
            {
                c.Feedback += "Rewards Earned:  ERROR - Must be a whole number (ex: 150)" + Environment.NewLine;
            }
            return c.Feedback;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Customer temp = new Customer();
            string report = ValidateCustomer(temp);
            if (report.Contains("ERROR"))
            {
                MessageBox.Show(report, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSubmit.ForeColor = System.Drawing.Color.Red;
                btnSubmit.Text = "Fix the errors above and try again.";
                return;
            }
            DialogResult answer = MessageBox.Show(
                temp.GetCustomerSummary() + Environment.NewLine + Environment.NewLine +
                "All fields look good. Do you want to CONFIRM?",
                "Confirm Customer Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                _confirmedCustomer = temp;
                btnSubmit.ForeColor = System.Drawing.Color.Green;
                btnSubmit.Text = "CONFIRMED - " + temp.FirstName + " " + temp.LastName +
                                 " | Email: " + temp.Email +
                                 " | State: " + temp.StateCode +
                                 " | ZIP: " + temp.Zip;
            }
            else
            {
                btnSubmit.ForeColor = System.Drawing.Color.DarkOrange;
                btnSubmit.Text = "DENIED - change any fields you want and try again.";
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_confirmedCustomer == null)
            {
                MessageBox.Show("Please confirm the customer information first.",
                                "Not Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Customer saved successfully!" + Environment.NewLine + Environment.NewLine +
                            _confirmedCustomer.GetCustomerSummary(),
                            "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void state_TextChanged(object sender, EventArgs e) { }
    }
}