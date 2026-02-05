using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week4_BookClassinWindows;
namespace Week5ForWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Test");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book temp = new Book();
            //MessageBox.Show(txtTitle.Text);
            temp.Title = txtTitle.Text;
            //MessageBox.Show(temp.Title);
            //I run your programming function
            // temp.Title += "with Poopy";
            //MessageBox.Show(temp.Title);
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            //Output or sore to DB
            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.Title + "Written By " + temp.AuthorFirst +
                " " + temp.AuthorLast;
            }
        }
        private void btnFillForm_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Optimus Prime Goes Fishing";
            txtAuthorFirst.Text = "Scott";
            txtAuthorLast.Text = "Lambert";
        }
    }
}

