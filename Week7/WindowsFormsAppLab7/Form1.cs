using System;
using System.Windows.Forms;

namespace WindowsFormsAppLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";

            if (!int.TryParse(txtAge.Text, out int age))
            {
                txtOutput.Text = "ERROR: Age must be a whole number.";
                return;
            }

            PersonV2 p = new PersonV2(
                txtFName.Text,
                txtLName.Text,
                txtEmail.Text,
                age,
                txtCellPhone.Text,
                txtInstagram.Text
            );

            if (!string.IsNullOrEmpty(p.Feedback))
            {
                txtOutput.Text = "Please fix the following errors:\n" + p.Feedback;
                return;
            }

            string dbResult = p.AddToDatabase();
            txtOutput.Text = dbResult + "\n\n" + p.ToString();
        }

        private void FName_Click(object sender, EventArgs e)
        {

        }
    }
}