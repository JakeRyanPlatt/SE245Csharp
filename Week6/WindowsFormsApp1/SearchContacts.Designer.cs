namespace WindowsFormsAppLab7
{
    partial class SearchContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchContacts = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.fname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchContacts
            // 
            this.btnSearchContacts.Location = new System.Drawing.Point(304, 102);
            this.btnSearchContacts.Name = "btnSearchContacts";
            this.btnSearchContacts.Size = new System.Drawing.Size(195, 56);
            this.btnSearchContacts.TabIndex = 0;
            this.btnSearchContacts.Text = "Search Contacts";
            this.btnSearchContacts.UseVisualStyleBackColor = true;
            this.btnSearchContacts.Click += new System.EventHandler(this.btnSearchContacts_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 181);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(776, 257);
            this.dgvResults.TabIndex = 1;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(45, 25);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(60, 13);
            this.fname.TabIndex = 2;
            this.fname.Text = "First Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(115, 22);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(155, 20);
            this.txtFname.TabIndex = 3;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(48, 59);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(61, 13);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(115, 56);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(155, 20);
            this.txtLname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instagram URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(413, 22);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(202, 20);
            this.txtURL.TabIndex = 7;
            // 
            // SearchContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearchContacts);
            this.Name = "SearchContacts";
            this.Text = "SearchContacts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchContacts;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
    }
}