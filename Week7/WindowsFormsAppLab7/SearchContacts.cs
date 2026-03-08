using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsAppLab7
{
    public partial class SearchContacts : Form
    {
        public SearchContacts()
        {
            InitializeComponent();
        }

        //  SEARCH BUTTONS

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                MessageBox.Show("Please enter a name to search.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable results = PersonV2.SearchByName(txtSearchName.Text);
            LoadGrid(results);
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable results = PersonV2.SearchByID(id);
            LoadGrid(results);
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchEmail.Text))
            {
                MessageBox.Show("Please enter an email to search.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable results = PersonV2.SearchByEmail(txtSearchEmail.Text);
            LoadGrid(results);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable results = PersonV2.GetAllPeople();
            LoadGrid(results);
        }

        //  LOAD RECORD BY ID  (pre-fills the edit fields)

        private void btnLoadRecord_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEditID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric PersonID.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = PersonV2.SearchByID(id);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show($"No record found with PersonID {id}.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow row = dt.Rows[0];
            txtEditFName.Text = row["FName"].ToString();
            txtEditLName.Text = row["LName"].ToString();
            txtEditEmail.Text = row["Email"].ToString();
            txtEditAge.Text = row["Age"].ToString();
            txtEditPhone.Text = row["CellPhone"].ToString();
            txtEditInstagram.Text = row["InstagramURL"].ToString();

            lblStatus.Text = $"Record {id} loaded — edit fields and click Update.";
        }

        //  UPDATE

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEditID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric PersonID.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEditAge.Text, out int age))
            {
                MessageBox.Show("Age must be a whole number.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = PersonV2.UpdatePerson(
                id,
                txtEditFName.Text.Trim(),
                txtEditLName.Text.Trim(),
                txtEditEmail.Text.Trim(),
                age,
                txtEditPhone.Text.Trim(),
                txtEditInstagram.Text.Trim()
            );

            lblStatus.Text = result;

            // Refresh grid to show the updated data
            if (dgvResults.DataSource != null)
                LoadGrid(PersonV2.GetAllPeople());
        }


        //  DELETE
   

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDeleteID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric PersonID.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete PersonID {id}?\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            string result = PersonV2.DeletePerson(id);
            lblStatus.Text = result;
            txtDeleteID.Clear();

            // Refresh grid
            if (dgvResults.DataSource != null)
                LoadGrid(PersonV2.GetAllPeople());
        }

        //  HELPER — bind DataTable to grid


        private void LoadGrid(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                dgvResults.DataSource = null;
                lblStatus.Text = "No records found.";
                return;
            }

            dgvResults.DataSource = dt;
            dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvResults.ReadOnly = true;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblStatus.Text = $"{dt.Rows.Count} record(s) found.";
        }
    }
}