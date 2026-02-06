namespace FormAppMidterm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.numPages = new System.Windows.Forms.Label();
            this.txtNumPages = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(289, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Published:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(390, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(392, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePublished.Location = new System.Drawing.Point(390, 249);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePublished.TabIndex = 5;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(387, 376);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(105, 13);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Feedback goes here";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Location = new System.Drawing.Point(390, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(286, 93);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(94, 13);
            this.Fname.TabIndex = 9;
            this.Fname.Text = "Author First Name:";
            this.Fname.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(289, 126);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(95, 13);
            this.Lname.TabIndex = 10;
            this.Lname.Text = "Author Last Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(390, 93);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(200, 20);
            this.txtFname.TabIndex = 11;
            this.txtFname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(390, 126);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(200, 20);
            this.txtLname.TabIndex = 12;
            // 
            // numPages
            // 
            this.numPages.AutoSize = true;
            this.numPages.Location = new System.Drawing.Point(289, 155);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(92, 13);
            this.numPages.TabIndex = 13;
            this.numPages.Text = "Number of Pages:";
            this.numPages.Click += new System.EventHandler(this.numPages_Click);
            // 
            // txtNumPages
            // 
            this.txtNumPages.Location = new System.Drawing.Point(390, 155);
            this.txtNumPages.Name = "txtNumPages";
            this.txtNumPages.Size = new System.Drawing.Size(100, 20);
            this.txtNumPages.TabIndex = 14;
            this.txtNumPages.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(289, 186);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(73, 13);
            this.Email.TabIndex = 15;
            this.Email.Text = "Author\'s Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtNumPages);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label numPages;
        private System.Windows.Forms.TextBox txtNumPages;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

