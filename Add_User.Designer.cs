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
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.lbluserregistrationlevel = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lblregistrationusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblregistrationpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblregistrationconformpassword = new System.Windows.Forms.Label();
            this.txtregistrationconformpassword = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
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
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(334, 102);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(340, 26);
            this.txtfullname.TabIndex = 2;
            this.txtfullname.TextChanged += new System.EventHandler(this.txtuserregistrationname_TextChanged);
            // 
            // lbluserregistrationlevel
            // 
            this.lbluserregistrationlevel.AutoSize = true;
            this.lbluserregistrationlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserregistrationlevel.Location = new System.Drawing.Point(26, 148);
            this.lbluserregistrationlevel.Name = "lbluserregistrationlevel";
            this.lbluserregistrationlevel.Size = new System.Drawing.Size(68, 29);
            this.lbluserregistrationlevel.TabIndex = 1;
            this.lbluserregistrationlevel.Text = "Role";
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "admin",
            "tester",
            "developer"});
            this.cmbrole.Location = new System.Drawing.Point(334, 152);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(340, 28);
            this.cmbrole.TabIndex = 3;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.combolbluserregistrationlevel_SelectedIndexChanged);
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
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(334, 213);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(340, 26);
            this.txtusername.TabIndex = 4;
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
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(334, 265);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(340, 26);
            this.txtpassword.TabIndex = 5;
            // 
            // lblregistrationconformpassword
            // 
            this.lblregistrationconformpassword.AutoSize = true;
            this.lblregistrationconformpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationconformpassword.Location = new System.Drawing.Point(28, 309);
            this.lblregistrationconformpassword.Name = "lblregistrationconformpassword";
            this.lblregistrationconformpassword.Size = new System.Drawing.Size(226, 29);
            this.lblregistrationconformpassword.TabIndex = 1;
            this.lblregistrationconformpassword.Text = "Confirm Password";
            // 
            // txtregistrationconformpassword
            // 
            this.txtregistrationconformpassword.Location = new System.Drawing.Point(334, 313);
            this.txtregistrationconformpassword.Name = "txtregistrationconformpassword";
            this.txtregistrationconformpassword.PasswordChar = '*';
            this.txtregistrationconformpassword.Size = new System.Drawing.Size(340, 26);
            this.txtregistrationconformpassword.TabIndex = 6;
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
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(416, 613);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(130, 56);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Update";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtregistrationconformpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblregistrationconformpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblregistrationpassword);
            this.Controls.Add(this.txtfullname);
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
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label lbluserregistrationlevel;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lblregistrationusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblregistrationpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblregistrationconformpassword;
        private System.Windows.Forms.TextBox txtregistrationconformpassword;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}