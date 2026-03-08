using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab7
{
    public partial class SearchContacts : Form
    {
        private Label fname;
        private TextBox txtfname;
        private Label lname;
        private TextBox txtlname;

        public SearchContacts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchContacts_Click(object sender, EventArgs e)
        {
            SearchContacts temp = new SearchContacts();

            DataSet ds = temp.SearchContacts(txtFname.Text,txtLname.Text);

            dvgResults.DataSource = ds;
            dvgResuilts.DataMember = ds.Tables["SearchContacts_temp"].ToString();
        }

        private void InitializeComponent()
        {
            this.fname = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(28, 33);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(63, 13);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name :";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(97, 30);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(146, 20);
            this.txtfname.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(31, 78);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(64, 13);
            this.lname.TabIndex = 2;
            this.lname.Text = "Last Name :";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(102, 78);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(141, 20);
            this.txtlname.TabIndex = 3;
            // 
            // SearchContacts
            // 
            this.ClientSize = new System.Drawing.Size(628, 406);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.fname);
            this.Name = "SearchContacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
