namespace Bug_Trakking_System
{
    partial class addnewproject
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
            this.lblprojecttitle = new System.Windows.Forms.Label();
            this.txtprojecttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprojecttype = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblprogramminglanguage = new System.Windows.Forms.Label();
            this.comboprojecttype = new System.Windows.Forms.ComboBox();
            this.comboprogramminglanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richtxtboxaddnewprojectdescription = new System.Windows.Forms.RichTextBox();
            this.btnadprojectsubmit = new System.Windows.Forms.Button();
            this.btnaddprojectupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Project";
            // 
            // lblprojecttitle
            // 
            this.lblprojecttitle.AutoSize = true;
            this.lblprojecttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojecttitle.ForeColor = System.Drawing.Color.White;
            this.lblprojecttitle.Location = new System.Drawing.Point(135, 188);
            this.lblprojecttitle.Name = "lblprojecttitle";
            this.lblprojecttitle.Size = new System.Drawing.Size(156, 29);
            this.lblprojecttitle.TabIndex = 1;
            this.lblprojecttitle.Text = "Project Title";
            // 
            // txtprojecttitle
            // 
            this.txtprojecttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprojecttitle.Location = new System.Drawing.Point(519, 188);
            this.txtprojecttitle.Name = "txtprojecttitle";
            this.txtprojecttitle.Size = new System.Drawing.Size(350, 35);
            this.txtprojecttitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Title";
            // 
            // lblprojecttype
            // 
            this.lblprojecttype.AutoSize = true;
            this.lblprojecttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojecttype.ForeColor = System.Drawing.Color.White;
            this.lblprojecttype.Location = new System.Drawing.Point(135, 268);
            this.lblprojecttype.Name = "lblprojecttype";
            this.lblprojecttype.Size = new System.Drawing.Size(162, 29);
            this.lblprojecttype.TabIndex = 1;
            this.lblprojecttype.Text = "Project Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Programming Language";
            // 
            // lblprogramminglanguage
            // 
            this.lblprogramminglanguage.AutoSize = true;
            this.lblprogramminglanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogramminglanguage.ForeColor = System.Drawing.Color.White;
            this.lblprogramminglanguage.Location = new System.Drawing.Point(135, 335);
            this.lblprogramminglanguage.Name = "lblprogramminglanguage";
            this.lblprogramminglanguage.Size = new System.Drawing.Size(292, 29);
            this.lblprogramminglanguage.TabIndex = 1;
            this.lblprogramminglanguage.Text = "Programming Language";
            // 
            // comboprojecttype
            // 
            this.comboprojecttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboprojecttype.FormattingEnabled = true;
            this.comboprojecttype.Items.AddRange(new object[] {
            "Maintenance Project",
            "Student Management System",
            "Consultancy"});
            this.comboprojecttype.Location = new System.Drawing.Point(522, 258);
            this.comboprojecttype.Name = "comboprojecttype";
            this.comboprojecttype.Size = new System.Drawing.Size(347, 37);
            this.comboprojecttype.TabIndex = 4;
            // 
            // comboprogramminglanguage
            // 
            this.comboprogramminglanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboprogramminglanguage.FormattingEnabled = true;
            this.comboprogramminglanguage.Items.AddRange(new object[] {
            "PHP",
            "JAVA",
            "C#"});
            this.comboprogramminglanguage.Location = new System.Drawing.Point(522, 335);
            this.comboprogramminglanguage.Name = "comboprogramminglanguage";
            this.comboprogramminglanguage.Size = new System.Drawing.Size(347, 37);
            this.comboprogramminglanguage.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // richtxtboxaddnewprojectdescription
            // 
            this.richtxtboxaddnewprojectdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtboxaddnewprojectdescription.Location = new System.Drawing.Point(522, 412);
            this.richtxtboxaddnewprojectdescription.Name = "richtxtboxaddnewprojectdescription";
            this.richtxtboxaddnewprojectdescription.Size = new System.Drawing.Size(349, 96);
            this.richtxtboxaddnewprojectdescription.TabIndex = 5;
            this.richtxtboxaddnewprojectdescription.Text = "";
            // 
            // btnadprojectsubmit
            // 
            this.btnadprojectsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadprojectsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadprojectsubmit.ForeColor = System.Drawing.Color.White;
            this.btnadprojectsubmit.Location = new System.Drawing.Point(206, 586);
            this.btnadprojectsubmit.Name = "btnadprojectsubmit";
            this.btnadprojectsubmit.Size = new System.Drawing.Size(117, 43);
            this.btnadprojectsubmit.TabIndex = 6;
            this.btnadprojectsubmit.Text = "Submit";
            this.btnadprojectsubmit.UseVisualStyleBackColor = false;
            this.btnadprojectsubmit.Click += new System.EventHandler(this.btnadprojectsubmit_Click);
            // 
            // btnaddprojectupdate
            // 
            this.btnaddprojectupdate.BackColor = System.Drawing.Color.Teal;
            this.btnaddprojectupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddprojectupdate.ForeColor = System.Drawing.Color.White;
            this.btnaddprojectupdate.Location = new System.Drawing.Point(531, 586);
            this.btnaddprojectupdate.Name = "btnaddprojectupdate";
            this.btnaddprojectupdate.Size = new System.Drawing.Size(114, 43);
            this.btnaddprojectupdate.TabIndex = 6;
            this.btnaddprojectupdate.Text = "Reset";
            this.btnaddprojectupdate.UseVisualStyleBackColor = false;
            this.btnaddprojectupdate.Click += new System.EventHandler(this.btnaddprojectreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(813, 586);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 43);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btnadprojectsubmit_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Teal;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(1143, 586);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(114, 43);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnaddprojectreset_Click);
            // 
            // addnewproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1458, 669);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnaddprojectupdate);
            this.Controls.Add(this.btnadprojectsubmit);
            this.Controls.Add(this.richtxtboxaddnewprojectdescription);
            this.Controls.Add(this.comboprogramminglanguage);
            this.Controls.Add(this.comboprojecttype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblprogramminglanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprojecttype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprojecttitle);
            this.Controls.Add(this.lblprojecttitle);
            this.Controls.Add(this.label1);
            this.Name = "addnewproject";
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.addnewproject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprojecttitle;
        private System.Windows.Forms.TextBox txtprojecttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprojecttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprogramminglanguage;
        private System.Windows.Forms.ComboBox comboprojecttype;
        private System.Windows.Forms.ComboBox comboprogramminglanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtxtboxaddnewprojectdescription;
        private System.Windows.Forms.Button btnadprojectsubmit;
        private System.Windows.Forms.Button btnaddprojectupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
    }
}