using System;
using System.Windows.Forms;

namespace FormAppMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get user input, validate, and display results
            Person temp = new Person(); // Creates instance

            // Initialize feedback to empty string
            temp.Feedback = "";

            // Set basic fields
            temp.FirstName = txtFname.Text;
            temp.LastName = txtLname.Text;

            // Email validation (must have @ and .)
            temp.Email = txtEmail.Text;
            if (temp.Email.Contains("@") == false || temp.Email.Contains(".") == false)
            {
                temp.Feedback += "ERROR: Invalid Email Format. Ex: BobAlice@gmail.com\n";
            }

            // State validation (2-letter US abbreviation, letters only)
            temp.State = txtState.Text.Trim().ToUpper();
            if (temp.State.Length != 2)
            {
                temp.Feedback += "ERROR: State must be 2 letters. Ex: MA, NY\n";
            }
            else
            {
                // Check that both characters are letters
                if (!char.IsLetter(temp.State[0]) || !char.IsLetter(temp.State[1]))
                {
                    temp.Feedback += "ERROR: State must contain only letters. Ex: MA, NY\n";
                }
            }

            // ZIP validation (exactly 5 digits)
            temp.Zip = txtZip.Text.Trim();
            if (temp.Zip.Length != 5)
            {
                temp.Feedback += "ERROR: ZIP must be exactly 5 digits. Ex: 02886\n";
            }
            else
            {
                int zipNum;
                if (int.TryParse(temp.Zip, out zipNum) == false)
                {
                    temp.Feedback += "ERROR: ZIP must be numeric. Ex: 02886\n";
                }
            }

            // Check for any errors
            if (temp.Feedback.Contains("ERROR:"))
            {
                // If there are errors, show the error msgs to prompt fixes
                lblFeedback.ForeColor = System.Drawing.Color.Red;
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                // Else, we have no errors, show results
                lblFeedback.ForeColor = System.Drawing.Color.Green;
                lblFeedback.Text = "Person Added: " +
                    temp.FirstName + " " + temp.LastName +
                    " | Email: " + temp.Email +
                    " | State: " + temp.State +
                    " | ZIP: " + temp.Zip;
            }
        }
    }
}