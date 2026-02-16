using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // DELETE everything else that was here!
            // InitializeComponent() already creates all the controls
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Person object
                Person person = new Person();

                // Fill the person object with data from textboxes using the properties
                person.FirstName = textBox1.Text;
                person.MiddleName = txtMname.Text;
                person.LastName = textBox2.Text;
                person.Street1 = textBox4.Text;
                person.Street2 = txtstreet2.Text;
                person.City = txtCity.Text;
                person.State = txtState.Text;
                person.Zip = txtZip.Text;
                person.Phone = txtPhone.Text;
                person.Email = txtEmail.Text;

                // Display feedback showing the person's data
                string feedback = "Person Successfully Added!\n\n";
                feedback += $"Name: {person.FirstName} {person.MiddleName} {person.LastName}\n";
                feedback += $"Address: {person.Street1}";

                if (!string.IsNullOrEmpty(person.Street2))
                {
                    feedback += $", {person.Street2}";
                }

                feedback += $"\n{person.City}, {person.State} {person.Zip}\n";
                feedback += $"Phone: {person.Phone}\n";
                feedback += $"Email: {person.Email}";

                lblFeedback.Text = feedback;
            }
            catch (Exception ex)
            {
                // Display validation errors
                lblFeedback.Text = "Error: " + ex.Message;
            }
        }
    }
}