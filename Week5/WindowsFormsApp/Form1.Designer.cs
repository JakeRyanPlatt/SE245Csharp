namespace WindowsFormsApp
{
    partial class Form1
    {
     
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

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
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.zipcode = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.txtcell = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtigURL = new System.Windows.Forms.Label();
            this.txtInstagramURL = new System.Windows.Forms.TextBox();
            this.CustomerService = new System.Windows.Forms.Label();
            this.txtCustomerSince = new System.Windows.Forms.TextBox();
            this.TotalPurchases = new System.Windows.Forms.Label();
            this.txtTotalPurchases = new System.Windows.Forms.TextBox();
            this.DiscountMember = new System.Windows.Forms.Label();
            this.RewardsEarned = new System.Windows.Forms.Label();
            this.txtRewardsEarned = new System.Windows.Forms.TextBox();
            this.chkDiscountMember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(12, 28);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(61, 13);
            this.fname.TabIndex = 0;
            this.fname.Text = "First name: ";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(11, 54);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(62, 13);
            this.lname.TabIndex = 1;
            this.lname.Text = "Last name :";
            this.lname.Click += new System.EventHandler(this.label2_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 76);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 2;
            this.email.Text = "Email :";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(12, 102);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(41, 13);
            this.state.TabIndex = 3;
            this.state.Text = "State : ";
            this.state.Click += new System.EventHandler(this.label4_Click);
            // 
            // zipcode
            // 
            this.zipcode.AutoSize = true;
            this.zipcode.Location = new System.Drawing.Point(12, 129);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(53, 13);
            this.zipcode.TabIndex = 4;
            this.zipcode.Text = "ZipCode :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSubmit.Location = new System.Drawing.Point(332, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 57);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(79, 47);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(166, 20);
            this.txtlname.TabIndex = 6;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(79, 21);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(166, 20);
            this.txtfname.TabIndex = 7;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(79, 73);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(166, 20);
            this.txtemail.TabIndex = 8;
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(79, 99);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(166, 20);
            this.txtstate.TabIndex = 9;
            this.txtstate.TextChanged += new System.EventHandler(this.state_TextChanged);
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(79, 126);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(166, 20);
            this.txtzip.TabIndex = 10;
            // 
            // txtcell
            // 
            this.txtcell.AutoSize = true;
            this.txtcell.Location = new System.Drawing.Point(12, 155);
            this.txtcell.Name = "txtcell";
            this.txtcell.Size = new System.Drawing.Size(61, 13);
            this.txtcell.TabIndex = 11;
            this.txtcell.Text = "Cell Phone:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 12;
            // 
            // txtigURL
            // 
            this.txtigURL.AutoSize = true;
            this.txtigURL.Location = new System.Drawing.Point(14, 182);
            this.txtigURL.Name = "txtigURL";
            this.txtigURL.Size = new System.Drawing.Size(81, 13);
            this.txtigURL.TabIndex = 13;
            this.txtigURL.Text = "Instagram URL:";
            // 
            // txtInstagramURL
            // 
            this.txtInstagramURL.Location = new System.Drawing.Point(101, 178);
            this.txtInstagramURL.Name = "txtInstagramURL";
            this.txtInstagramURL.Size = new System.Drawing.Size(609, 20);
            this.txtInstagramURL.TabIndex = 14;
            // 
            // CustomerService
            // 
            this.CustomerService.AutoSize = true;
            this.CustomerService.Location = new System.Drawing.Point(12, 208);
            this.CustomerService.Name = "CustomerService";
            this.CustomerService.Size = new System.Drawing.Size(84, 13);
            this.CustomerService.TabIndex = 15;
            this.CustomerService.Text = "Customer Since:";
            // 
            // txtCustomerSince
            // 
            this.txtCustomerSince.Location = new System.Drawing.Point(103, 208);
            this.txtCustomerSince.Name = "txtCustomerSince";
            this.txtCustomerSince.Size = new System.Drawing.Size(142, 20);
            this.txtCustomerSince.TabIndex = 16;
            // 
            // TotalPurchases
            // 
            this.TotalPurchases.AutoSize = true;
            this.TotalPurchases.Location = new System.Drawing.Point(14, 235);
            this.TotalPurchases.Name = "TotalPurchases";
            this.TotalPurchases.Size = new System.Drawing.Size(87, 13);
            this.TotalPurchases.TabIndex = 17;
            this.TotalPurchases.Text = "Total Purchases:";
            // 
            // txtTotalPurchases
            // 
            this.txtTotalPurchases.Location = new System.Drawing.Point(101, 235);
            this.txtTotalPurchases.Name = "txtTotalPurchases";
            this.txtTotalPurchases.Size = new System.Drawing.Size(144, 20);
            this.txtTotalPurchases.TabIndex = 18;
            // 
            // DiscountMember
            // 
            this.DiscountMember.AutoSize = true;
            this.DiscountMember.Location = new System.Drawing.Point(14, 261);
            this.DiscountMember.Name = "DiscountMember";
            this.DiscountMember.Size = new System.Drawing.Size(93, 13);
            this.DiscountMember.TabIndex = 19;
            this.DiscountMember.Text = "Discount Member:";
            // 
            // RewardsEarned
            // 
            this.RewardsEarned.AutoSize = true;
            this.RewardsEarned.Location = new System.Drawing.Point(14, 292);
            this.RewardsEarned.Name = "RewardsEarned";
            this.RewardsEarned.Size = new System.Drawing.Size(89, 13);
            this.RewardsEarned.TabIndex = 21;
            this.RewardsEarned.Text = "Rewards Earned:";
            // 
            // txtRewardsEarned
            // 
            this.txtRewardsEarned.Location = new System.Drawing.Point(103, 288);
            this.txtRewardsEarned.Name = "txtRewardsEarned";
            this.txtRewardsEarned.Size = new System.Drawing.Size(142, 20);
            this.txtRewardsEarned.TabIndex = 22;
            // 
            // chkDiscountMember
            // 
            this.chkDiscountMember.AutoSize = true;
            this.chkDiscountMember.Location = new System.Drawing.Point(114, 261);
            this.chkDiscountMember.Name = "chkDiscountMember";
            this.chkDiscountMember.Size = new System.Drawing.Size(109, 17);
            this.chkDiscountMember.TabIndex = 23;
            this.chkDiscountMember.Text = "Discount Member";
            this.chkDiscountMember.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkDiscountMember);
            this.Controls.Add(this.txtRewardsEarned);
            this.Controls.Add(this.RewardsEarned);
            this.Controls.Add(this.DiscountMember);
            this.Controls.Add(this.txtTotalPurchases);
            this.Controls.Add(this.TotalPurchases);
            this.Controls.Add(this.txtCustomerSince);
            this.Controls.Add(this.CustomerService);
            this.Controls.Add(this.txtInstagramURL);
            this.Controls.Add(this.txtigURL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcell);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.state);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label zipcode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Label txtcell;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtigURL;
        private System.Windows.Forms.TextBox txtInstagramURL;
        private System.Windows.Forms.Label CustomerService;
        private System.Windows.Forms.TextBox txtCustomerSince;
        private System.Windows.Forms.Label TotalPurchases;
        private System.Windows.Forms.TextBox txtTotalPurchases;
        private System.Windows.Forms.Label DiscountMember;
        private System.Windows.Forms.Label RewardsEarned;
        private System.Windows.Forms.TextBox txtRewardsEarned;
        private System.Windows.Forms.CheckBox chkDiscountMember;
    }
}

