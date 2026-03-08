using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppLab7;

namespace WindowsFormsApp1
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }
     
        private void btnAddContact(object sender, EventArgs e)
        {
            var addForm = new AddContactForm();
            addForm.Show();
        }

        private void btnSearchContacts(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.Show();
        }

      
    }

}
