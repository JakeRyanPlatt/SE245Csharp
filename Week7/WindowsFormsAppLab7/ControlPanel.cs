using System;
using System.Windows.Forms;

namespace WindowsFormsAppLab7
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        // Opens the Add Contact form (Form1)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 addForm = new Form1();
            addForm.Show();
        }

        // Opens the Search / Update / Delete form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchContacts searchForm = new SearchContacts();
            searchForm.Show();
        }
    }
}