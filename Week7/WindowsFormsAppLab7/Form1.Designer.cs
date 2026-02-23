namespace WindowsFormsAppLab7
{
    partial class Form1
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
            this.FName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCustomerSince = new System.Windows.Forms.DateTimePicker();
            this.TotalPurchases = new System.Windows.Forms.Label();
            this.txtTotalPurchases = new System.Windows.Forms.TextBox();
            this.DicsountMember = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRewards = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(13, 13);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(60, 13);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name:";
            this.FName.Click += new System.EventHandler(this.FName_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(79, 10);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(198, 20);
            this.txtFName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(79, 46);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(198, 20);
            this.txtLName.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(16, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(19, 115);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(29, 13);
            this.Age.TabIndex = 6;
            this.Age.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(79, 115);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(198, 20);
            this.txtAge.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cell Phone:";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(79, 145);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(198, 20);
            this.txtCellPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Instagram URL:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(103, 180);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(344, 20);
            this.txtInstagram.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Since";
            // 
            // dtpCustomerSince
            // 
            this.dtpCustomerSince.Location = new System.Drawing.Point(106, 216);
            this.dtpCustomerSince.Name = "dtpCustomerSince";
            this.dtpCustomerSince.Size = new System.Drawing.Size(200, 20);
            this.dtpCustomerSince.TabIndex = 14;
            // 
            // TotalPurchases
            // 
            this.TotalPurchases.AutoSize = true;
            this.TotalPurchases.Location = new System.Drawing.Point(16, 253);
            this.TotalPurchases.Name = "TotalPurchases";
            this.TotalPurchases.Size = new System.Drawing.Size(84, 13);
            this.TotalPurchases.TabIndex = 15;
            this.TotalPurchases.Text = "Total Purchases";
            // 
            // txtTotalPurchases
            // 
            this.txtTotalPurchases.Location = new System.Drawing.Point(107, 250);
            this.txtTotalPurchases.Name = "txtTotalPurchases";
            this.txtTotalPurchases.Size = new System.Drawing.Size(199, 20);
            this.txtTotalPurchases.TabIndex = 16;
            // 
            // DicsountMember
            // 
            this.DicsountMember.AutoSize = true;
            this.DicsountMember.Location = new System.Drawing.Point(16, 283);
            this.DicsountMember.Name = "DicsountMember";
            this.DicsountMember.Size = new System.Drawing.Size(90, 13);
            this.DicsountMember.TabIndex = 17;
            this.DicsountMember.Text = "Discount Member";
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(113, 283);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(80, 17);
            this.chkDiscount.TabIndex = 18;
            this.chkDiscount.Text = "checkBox1";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rewards Earned";
            // 
            // txtRewards
            // 
            this.txtRewards.Location = new System.Drawing.Point(107, 306);
            this.txtRewards.Name = "txtRewards";
            this.txtRewards.Size = new System.Drawing.Size(199, 20);
            this.txtRewards.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(476, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 53);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(315, 349);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(438, 88);
            this.txtOutput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRewards);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.DicsountMember);
            this.Controls.Add(this.txtTotalPurchases);
            this.Controls.Add(this.TotalPurchases);
            this.Controls.Add(this.dtpCustomerSince);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInstagram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.FName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCustomerSince;
        private System.Windows.Forms.Label TotalPurchases;
        private System.Windows.Forms.TextBox txtTotalPurchases;
        private System.Windows.Forms.Label DicsountMember;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRewards;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

