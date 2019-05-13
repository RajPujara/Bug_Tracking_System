namespace Bug_Trakking_System
{
    partial class userreport
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
            this.datagridviewuserreport = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewuserreport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Report";
            // 
            // datagridviewuserreport
            // 
            this.datagridviewuserreport.ColumnHeadersHeight = 50;
            this.datagridviewuserreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.user_level,
            this.mobile,
            this.email,
            this.DOB,
            this.address,
            this.created_at,
            this.updated_at});
            this.datagridviewuserreport.Location = new System.Drawing.Point(1, 76);
            this.datagridviewuserreport.Name = "datagridviewuserreport";
            this.datagridviewuserreport.RowHeadersWidth = 47;
            this.datagridviewuserreport.RowTemplate.Height = 28;
            this.datagridviewuserreport.Size = new System.Drawing.Size(1494, 601);
            this.datagridviewuserreport.TabIndex = 2;
            this.datagridviewuserreport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewuserreport_CellContentClick);
            // 
            // username
            // 
            this.username.HeaderText = "UserName";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // user_level
            // 
            this.user_level.HeaderText = "User Level";
            this.user_level.Name = "user_level";
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date of Birth";
            this.DOB.Name = "DOB";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Created_at";
            this.created_at.Name = "created_at";
            // 
            // updated_at
            // 
            this.updated_at.HeaderText = "Updated_at";
            this.updated_at.Name = "updated_at";
            // 
            // userreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1493, 669);
            this.Controls.Add(this.datagridviewuserreport);
            this.Controls.Add(this.label1);
            this.Name = "userreport";
            this.Text = "User_Report";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewuserreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridviewuserreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
    }
}