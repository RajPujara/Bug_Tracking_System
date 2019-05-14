namespace Bug_Trakking_System
{
    partial class addnewuser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbluserregistrationname = new System.Windows.Forms.Label();
            this.txtuserregistrationname = new System.Windows.Forms.TextBox();
            this.lbluserregistrationlevel = new System.Windows.Forms.Label();
            this.combolbluserregistrationlevel = new System.Windows.Forms.ComboBox();
            this.lblregistrationusername = new System.Windows.Forms.Label();
            this.txtregistrationusername = new System.Windows.Forms.TextBox();
            this.lblregistrationpassword = new System.Windows.Forms.Label();
            this.txtregistrationpassword = new System.Windows.Forms.TextBox();
            this.lblregistrationconformpassword = new System.Windows.Forms.Label();
            this.txtregistrationconformpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluserregistrationmobile = new System.Windows.Forms.Label();
            this.txtuserregistrationmobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbluserregistrationemail = new System.Windows.Forms.Label();
            this.txtuserregistrationemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbluserregistrationdob = new System.Windows.Forms.Label();
            this.txtuserregistrationdob = new System.Windows.Forms.TextBox();
            this.lbluserregistrationaddress = new System.Windows.Forms.Label();
            this.txtuserregistrationaddress = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // lbluserregistrationname
            // 
            this.lbluserregistrationname.AutoSize = true;
            this.lbluserregistrationname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationname.ForeColor = System.Drawing.Color.White;
            this.lbluserregistrationname.Location = new System.Drawing.Point(28, 98);
            this.lbluserregistrationname.Name = "lbluserregistrationname";
            this.lbluserregistrationname.Size = new System.Drawing.Size(133, 29);
            this.lbluserregistrationname.TabIndex = 0;
            this.lbluserregistrationname.Text = "Full Name";
            // 
            // txtuserregistrationname
            // 
            this.txtuserregistrationname.Location = new System.Drawing.Point(334, 102);
            this.txtuserregistrationname.Name = "txtuserregistrationname";
            this.txtuserregistrationname.Size = new System.Drawing.Size(340, 26);
            this.txtuserregistrationname.TabIndex = 2;
            this.txtuserregistrationname.TextChanged += new System.EventHandler(this.txtuserregistrationname_TextChanged);
            // 
            // lbluserregistrationlevel
            // 
            this.lbluserregistrationlevel.AutoSize = true;
            this.lbluserregistrationlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationlevel.Location = new System.Drawing.Point(26, 148);
            this.lbluserregistrationlevel.Name = "lbluserregistrationlevel";
            this.lbluserregistrationlevel.Size = new System.Drawing.Size(138, 29);
            this.lbluserregistrationlevel.TabIndex = 1;
            this.lbluserregistrationlevel.Text = "User Level";
            // 
            // combolbluserregistrationlevel
            // 
            this.combolbluserregistrationlevel.FormattingEnabled = true;
            this.combolbluserregistrationlevel.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.combolbluserregistrationlevel.Location = new System.Drawing.Point(334, 152);
            this.combolbluserregistrationlevel.Name = "combolbluserregistrationlevel";
            this.combolbluserregistrationlevel.Size = new System.Drawing.Size(340, 28);
            this.combolbluserregistrationlevel.TabIndex = 3;
            this.combolbluserregistrationlevel.SelectedIndexChanged += new System.EventHandler(this.combolbluserregistrationlevel_SelectedIndexChanged);
            // 
            // lblregistrationusername
            // 
            this.lblregistrationusername.AutoSize = true;
            this.lblregistrationusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationusername.Location = new System.Drawing.Point(28, 209);
            this.lblregistrationusername.Name = "lblregistrationusername";
            this.lblregistrationusername.Size = new System.Drawing.Size(132, 29);
            this.lblregistrationusername.TabIndex = 1;
            this.lblregistrationusername.Text = "Username";
            // 
            // txtregistrationusername
            // 
            this.txtregistrationusername.Location = new System.Drawing.Point(334, 213);
            this.txtregistrationusername.Name = "txtregistrationusername";
            this.txtregistrationusername.Size = new System.Drawing.Size(340, 26);
            this.txtregistrationusername.TabIndex = 4;
            // 
            // lblregistrationpassword
            // 
            this.lblregistrationpassword.AutoSize = true;
            this.lblregistrationpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationpassword.Location = new System.Drawing.Point(28, 258);
            this.lblregistrationpassword.Name = "lblregistrationpassword";
            this.lblregistrationpassword.Size = new System.Drawing.Size(128, 29);
            this.lblregistrationpassword.TabIndex = 1;
            this.lblregistrationpassword.Text = "Password";
            // 
            // txtregistrationpassword
            // 
            this.txtregistrationpassword.Location = new System.Drawing.Point(334, 265);
            this.txtregistrationpassword.Name = "txtregistrationpassword";
            this.txtregistrationpassword.PasswordChar = '*';
            this.txtregistrationpassword.Size = new System.Drawing.Size(340, 26);
            this.txtregistrationpassword.TabIndex = 5;
            // 
            // lblregistrationconformpassword
            // 
            this.lblregistrationconformpassword.AutoSize = true;
            this.lblregistrationconformpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationconformpassword.Location = new System.Drawing.Point(28, 309);
            this.lblregistrationconformpassword.Name = "lblregistrationconformpassword";
            this.lblregistrationconformpassword.Size = new System.Drawing.Size(234, 29);
            this.lblregistrationconformpassword.TabIndex = 1;
            this.lblregistrationconformpassword.Text = "Conform Password";
            // 
            // txtregistrationconformpassword
            // 
            this.txtregistrationconformpassword.Location = new System.Drawing.Point(334, 313);
            this.txtregistrationconformpassword.Name = "txtregistrationconformpassword";
            this.txtregistrationconformpassword.PasswordChar = '*';
            this.txtregistrationconformpassword.Size = new System.Drawing.Size(340, 26);
            this.txtregistrationconformpassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "mobile";
            // 
            // lbluserregistrationmobile
            // 
            this.lbluserregistrationmobile.AutoSize = true;
            this.lbluserregistrationmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationmobile.Location = new System.Drawing.Point(28, 375);
            this.lbluserregistrationmobile.Name = "lbluserregistrationmobile";
            this.lbluserregistrationmobile.Size = new System.Drawing.Size(93, 29);
            this.lbluserregistrationmobile.TabIndex = 1;
            this.lbluserregistrationmobile.Text = "Mobile";
            // 
            // txtuserregistrationmobile
            // 
            this.txtuserregistrationmobile.Location = new System.Drawing.Point(334, 375);
            this.txtuserregistrationmobile.Name = "txtuserregistrationmobile";
            this.txtuserregistrationmobile.Size = new System.Drawing.Size(340, 26);
            this.txtuserregistrationmobile.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "mobile";
            // 
            // lbluserregistrationemail
            // 
            this.lbluserregistrationemail.AutoSize = true;
            this.lbluserregistrationemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationemail.Location = new System.Drawing.Point(28, 428);
            this.lbluserregistrationemail.Name = "lbluserregistrationemail";
            this.lbluserregistrationemail.Size = new System.Drawing.Size(79, 29);
            this.lbluserregistrationemail.TabIndex = 1;
            this.lbluserregistrationemail.Text = "Email\r\n";
            // 
            // txtuserregistrationemail
            // 
            this.txtuserregistrationemail.Location = new System.Drawing.Point(334, 428);
            this.txtuserregistrationemail.Name = "txtuserregistrationemail";
            this.txtuserregistrationemail.Size = new System.Drawing.Size(340, 26);
            this.txtuserregistrationemail.TabIndex = 8;
            this.txtuserregistrationemail.TextChanged += new System.EventHandler(this.txtuserregistrationemail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "mobile";
            // 
            // lbluserregistrationdob
            // 
            this.lbluserregistrationdob.AutoSize = true;
            this.lbluserregistrationdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationdob.Location = new System.Drawing.Point(28, 472);
            this.lbluserregistrationdob.Name = "lbluserregistrationdob";
            this.lbluserregistrationdob.Size = new System.Drawing.Size(157, 29);
            this.lbluserregistrationdob.TabIndex = 1;
            this.lbluserregistrationdob.Text = "Date of Birth";
            // 
            // txtuserregistrationdob
            // 
            this.txtuserregistrationdob.Location = new System.Drawing.Point(330, 475);
            this.txtuserregistrationdob.Name = "txtuserregistrationdob";
            this.txtuserregistrationdob.Size = new System.Drawing.Size(344, 26);
            this.txtuserregistrationdob.TabIndex = 9;
            // 
            // lbluserregistrationaddress
            // 
            this.lbluserregistrationaddress.AutoSize = true;
            this.lbluserregistrationaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationaddress.Location = new System.Drawing.Point(28, 518);
            this.lbluserregistrationaddress.Name = "lbluserregistrationaddress";
            this.lbluserregistrationaddress.Size = new System.Drawing.Size(109, 29);
            this.lbluserregistrationaddress.TabIndex = 1;
            this.lbluserregistrationaddress.Text = "Address";
            // 
            // txtuserregistrationaddress
            // 
            this.txtuserregistrationaddress.Location = new System.Drawing.Point(334, 522);
            this.txtuserregistrationaddress.Name = "txtuserregistrationaddress";
            this.txtuserregistrationaddress.Size = new System.Drawing.Size(340, 26);
            this.txtuserregistrationaddress.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Orange;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(67, 613);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(119, 56);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnuserregistrationsubmit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(416, 613);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(130, 56);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "Add";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnuserregistrationreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Orange;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(700, 613);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 56);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btnuserregistrationsubmit_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(1030, 613);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(130, 56);
            this.btnreset.TabIndex = 14;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnuserregistrationreset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addnewuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1461, 710);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.combolbluserregistrationlevel);
            this.Controls.Add(this.txtuserregistrationaddress);
            this.Controls.Add(this.txtuserregistrationdob);
            this.Controls.Add(this.txtuserregistrationemail);
            this.Controls.Add(this.lbluserregistrationaddress);
            this.Controls.Add(this.txtuserregistrationmobile);
            this.Controls.Add(this.lbluserregistrationdob);
            this.Controls.Add(this.txtregistrationconformpassword);
            this.Controls.Add(this.lbluserregistrationemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtregistrationpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbluserregistrationmobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblregistrationconformpassword);
            this.Controls.Add(this.txtregistrationusername);
            this.Controls.Add(this.lblregistrationpassword);
            this.Controls.Add(this.txtuserregistrationname);
            this.Controls.Add(this.lblregistrationusername);
            this.Controls.Add(this.lbluserregistrationlevel);
            this.Controls.Add(this.lbluserregistrationname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "addnewuser";
            this.Text = " Add User";
            this.Load += new System.EventHandler(this.Add_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluserregistrationname;
        private System.Windows.Forms.TextBox txtuserregistrationname;
        private System.Windows.Forms.Label lbluserregistrationlevel;
        private System.Windows.Forms.ComboBox combolbluserregistrationlevel;
        private System.Windows.Forms.Label lblregistrationusername;
        private System.Windows.Forms.TextBox txtregistrationusername;
        private System.Windows.Forms.Label lblregistrationpassword;
        private System.Windows.Forms.TextBox txtregistrationpassword;
        private System.Windows.Forms.Label lblregistrationconformpassword;
        private System.Windows.Forms.TextBox txtregistrationconformpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluserregistrationmobile;
        private System.Windows.Forms.TextBox txtuserregistrationmobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbluserregistrationemail;
        private System.Windows.Forms.TextBox txtuserregistrationemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbluserregistrationdob;
        private System.Windows.Forms.TextBox txtuserregistrationdob;
        private System.Windows.Forms.Label lbluserregistrationaddress;
        private System.Windows.Forms.TextBox txtuserregistrationaddress;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}