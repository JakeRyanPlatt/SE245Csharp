using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week4_BookClassinWindows;

namespace FormAppMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Fill the Text property of the Feedback variable with the book title, price, and date published with some desccriptive text/strings
            // the "value" propterty of a DateTimePicker returns a DateTime variable. We convertt it to a string in order to append it to thenstirng/text/
            //lblFeedback.Text = "Book Added: " + txtTitle.Text + "($" + txtPrice.Text + ") - Published: " + dtpDatePublished.Value.ToString();

            Book temp = new Book(); // Creates instance
            temp.Title = txtTitle.Text; // set title
            temp.AuthorFirst = txtFname.Text; // set author first name
            temp.AuthorLast = txtLname.Text; // set author last name
            temp.Pages = Int32.Parse(txtNumPages.Text);

            // Email validation
            temp.Email = txtEmail.Text; // set email

            if (temp.Email.Contains("@") == false || temp.Email.Contains(".") == false)
            {
                temp.Feedback += "ERROR: Invalid Email Format. Ex:BobAlice@hotmail.com ";
            }
            else
            {
                temp.Email = txtEmail.Text; // set emails
            }

                temp.Feedback = ""; // initialize feedback to empty string

            // Price validation
            double tPrice = 0;
            if (double.TryParse(txtPrice.Text, out tPrice))
            {
                temp.Price = tPrice; // set price if valid
            }
            else
            {
                temp.Feedback += "ERROR: Invalid Price Format.Ex: 5.98 ";
            }

            // Date Published Validation
            temp.DatePublished = dtpDatePublished.Value; // set date published

            if (temp.Feedback.Contains("ERROR:"))
            {
                // If there are errrors, show the error msgs in order to prompt fixes
                lblFeedback.Text = temp.Feedback;
            }
            else
                // Else, we have no errors, show results
                lblFeedback.Text = "Book Added: " + temp.Title + " ($ " + temp.Price.ToString() + ") - Published: " + temp.DatePublished.ToString();

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numPages_Click(object sender, EventArgs e)
        {

        }
    }
    }

