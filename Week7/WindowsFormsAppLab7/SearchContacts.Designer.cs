namespace WindowsFormsAppLab7
{
    partial class SearchContacts
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            // Declare all controls 
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();

            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();

            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.btnSearchEmail = new System.Windows.Forms.Button();

            this.btnShowAll = new System.Windows.Forms.Button();

            this.dgvResults = new System.Windows.Forms.DataGridView();

            this.lblEditSection = new System.Windows.Forms.Label();
            this.lblEditID = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.btnLoadRecord = new System.Windows.Forms.Button();

            this.lblEditFName = new System.Windows.Forms.Label();
            this.txtEditFName = new System.Windows.Forms.TextBox();
            this.lblEditLName = new System.Windows.Forms.Label();
            this.txtEditLName = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditAge = new System.Windows.Forms.Label();
            this.txtEditAge = new System.Windows.Forms.TextBox();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.lblEditInstagram = new System.Windows.Forms.Label();
            this.txtEditInstagram = new System.Windows.Forms.TextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();

            this.lblDeleteSection = new System.Windows.Forms.Label();
            this.lblDeleteID = new System.Windows.Forms.Label();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();

            this.lblStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // ROW 1: Search by Name
            this.lblSearchName.Text = "Search by Name:";
            this.lblSearchName.Location = new System.Drawing.Point(12, 15);
            this.lblSearchName.Size = new System.Drawing.Size(100, 20);

            this.txtSearchName.Location = new System.Drawing.Point(115, 12);
            this.txtSearchName.Size = new System.Drawing.Size(200, 22);
            this.txtSearchName.Name = "txtSearchName";

            this.btnSearchName.Text = "Search";
            this.btnSearchName.Location = new System.Drawing.Point(325, 10);
            this.btnSearchName.Size = new System.Drawing.Size(80, 26);
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);

            //  ROW 2: Search by ID 
            this.lblSearchID.Text = "Search by ID:";
            this.lblSearchID.Location = new System.Drawing.Point(12, 50);
            this.lblSearchID.Size = new System.Drawing.Size(100, 20);

            this.txtSearchID.Location = new System.Drawing.Point(115, 47);
            this.txtSearchID.Size = new System.Drawing.Size(200, 22);
            this.txtSearchID.Name = "txtSearchID";

            this.btnSearchID.Text = "Search";
            this.btnSearchID.Location = new System.Drawing.Point(325, 45);
            this.btnSearchID.Size = new System.Drawing.Size(80, 26);
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);

            // ROW 3: Search by Email
            this.lblSearchEmail.Text = "Search by Email:";
            this.lblSearchEmail.Location = new System.Drawing.Point(12, 85);
            this.lblSearchEmail.Size = new System.Drawing.Size(100, 20);

            this.txtSearchEmail.Location = new System.Drawing.Point(115, 82);
            this.txtSearchEmail.Size = new System.Drawing.Size(200, 22);
            this.txtSearchEmail.Name = "txtSearchEmail";

            this.btnSearchEmail.Text = "Search";
            this.btnSearchEmail.Location = new System.Drawing.Point(325, 80);
            this.btnSearchEmail.Size = new System.Drawing.Size(80, 26);
            this.btnSearchEmail.Click += new System.EventHandler(this.btnSearchEmail_Click);

            // Show All button 
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Location = new System.Drawing.Point(420, 45);
            this.btnShowAll.Size = new System.Drawing.Size(80, 26);
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            //  DataGridView 
            this.dgvResults.Location = new System.Drawing.Point(12, 120);
            this.dgvResults.Size = new System.Drawing.Size(860, 200);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.TabIndex = 10;

            //  UPDATE SECTION
            this.lblEditSection.Text = "── Update Record ──────────────────────────";
            this.lblEditSection.Location = new System.Drawing.Point(12, 335);
            this.lblEditSection.Size = new System.Drawing.Size(400, 18);
            this.lblEditSection.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);

            this.lblEditID.Text = "PersonID:";
            this.lblEditID.Location = new System.Drawing.Point(12, 360);
            this.lblEditID.Size = new System.Drawing.Size(65, 20);

            this.txtEditID.Location = new System.Drawing.Point(80, 357);
            this.txtEditID.Size = new System.Drawing.Size(80, 22);
            this.txtEditID.Name = "txtEditID";

            this.btnLoadRecord.Text = "Load Record";
            this.btnLoadRecord.Location = new System.Drawing.Point(170, 355);
            this.btnLoadRecord.Size = new System.Drawing.Size(100, 26);
            this.btnLoadRecord.Click += new System.EventHandler(this.btnLoadRecord_Click);

            // Edit fields — row 1
            this.lblEditFName.Text = "First Name:";
            this.lblEditFName.Location = new System.Drawing.Point(12, 395);
            this.lblEditFName.Size = new System.Drawing.Size(70, 20);
            this.txtEditFName.Location = new System.Drawing.Point(85, 392);
            this.txtEditFName.Size = new System.Drawing.Size(130, 22);
            this.txtEditFName.Name = "txtEditFName";

            this.lblEditLName.Text = "Last Name:";
            this.lblEditLName.Location = new System.Drawing.Point(230, 395);
            this.lblEditLName.Size = new System.Drawing.Size(70, 20);
            this.txtEditLName.Location = new System.Drawing.Point(305, 392);
            this.txtEditLName.Size = new System.Drawing.Size(130, 22);
            this.txtEditLName.Name = "txtEditLName";

            this.lblEditEmail.Text = "Email:";
            this.lblEditEmail.Location = new System.Drawing.Point(450, 395);
            this.lblEditEmail.Size = new System.Drawing.Size(40, 20);
            this.txtEditEmail.Location = new System.Drawing.Point(495, 392);
            this.txtEditEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEditEmail.Name = "txtEditEmail";

            // Edit fields — row 2
            this.lblEditAge.Text = "Age:";
            this.lblEditAge.Location = new System.Drawing.Point(12, 430);
            this.lblEditAge.Size = new System.Drawing.Size(70, 20);
            this.txtEditAge.Location = new System.Drawing.Point(85, 427);
            this.txtEditAge.Size = new System.Drawing.Size(60, 22);
            this.txtEditAge.Name = "txtEditAge";

            this.lblEditPhone.Text = "Cell Phone:";
            this.lblEditPhone.Location = new System.Drawing.Point(160, 430);
            this.lblEditPhone.Size = new System.Drawing.Size(70, 20);
            this.txtEditPhone.Location = new System.Drawing.Point(235, 427);
            this.txtEditPhone.Size = new System.Drawing.Size(130, 22);
            this.txtEditPhone.Name = "txtEditPhone";

            this.lblEditInstagram.Text = "Instagram:";
            this.lblEditInstagram.Location = new System.Drawing.Point(380, 430);
            this.lblEditInstagram.Size = new System.Drawing.Size(70, 20);
            this.txtEditInstagram.Location = new System.Drawing.Point(455, 427);
            this.txtEditInstagram.Size = new System.Drawing.Size(200, 22);
            this.txtEditInstagram.Name = "txtEditInstagram";

            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.Location = new System.Drawing.Point(12, 465);
            this.btnUpdateRecord.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateRecord.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);

            //  DELETE SECTION 
            this.lblDeleteSection.Text = "── Delete Record ──────────────────────────";
            this.lblDeleteSection.Location = new System.Drawing.Point(12, 510);
            this.lblDeleteSection.Size = new System.Drawing.Size(400, 18);
            this.lblDeleteSection.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);

            this.lblDeleteID.Text = "PersonID:";
            this.lblDeleteID.Location = new System.Drawing.Point(12, 535);
            this.lblDeleteID.Size = new System.Drawing.Size(65, 20);

            this.txtDeleteID.Location = new System.Drawing.Point(80, 532);
            this.txtDeleteID.Size = new System.Drawing.Size(80, 22);
            this.txtDeleteID.Name = "txtDeleteID";

            this.btnDelete.Text = "Delete Record";
            this.btnDelete.Location = new System.Drawing.Point(170, 530);
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            //  Status label
            this.lblStatus.Text = "Ready.";
            this.lblStatus.Location = new System.Drawing.Point(12, 575);
            this.lblStatus.Size = new System.Drawing.Size(860, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.ForeColor = System.Drawing.Color.DarkBlue;

            // Form 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 610);
            this.Text = "Search Contacts";
            this.Name = "SearchContacts";

            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.lblSearchID);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.lblSearchEmail);
            this.Controls.Add(this.txtSearchEmail);
            this.Controls.Add(this.btnSearchEmail);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblEditSection);
            this.Controls.Add(this.lblEditID);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.btnLoadRecord);
            this.Controls.Add(this.lblEditFName);
            this.Controls.Add(this.txtEditFName);
            this.Controls.Add(this.lblEditLName);
            this.Controls.Add(this.txtEditLName);
            this.Controls.Add(this.lblEditEmail);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.lblEditAge);
            this.Controls.Add(this.txtEditAge);
            this.Controls.Add(this.lblEditPhone);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.lblEditInstagram);
            this.Controls.Add(this.txtEditInstagram);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.lblDeleteSection);
            this.Controls.Add(this.lblDeleteID);
            this.Controls.Add(this.txtDeleteID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStatus);

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        // Search controls
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Button btnSearchEmail;
        private System.Windows.Forms.Button btnShowAll;

        // Results grid
        private System.Windows.Forms.DataGridView dgvResults;

        // Update controls
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Button btnLoadRecord;
        private System.Windows.Forms.Label lblEditFName;
        private System.Windows.Forms.TextBox txtEditFName;
        private System.Windows.Forms.Label lblEditLName;
        private System.Windows.Forms.TextBox txtEditLName;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditAge;
        private System.Windows.Forms.TextBox txtEditAge;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label lblEditInstagram;
        private System.Windows.Forms.TextBox txtEditInstagram;
        private System.Windows.Forms.Button btnUpdateRecord;

        // Delete controls
        private System.Windows.Forms.Label lblDeleteSection;
        private System.Windows.Forms.Label lblDeleteID;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Button btnDelete;

        // Status
        private System.Windows.Forms.Label lblStatus;
    }
}