namespace Bug_Trakking_System
{
    partial class addnewbug
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
            this.lbladdnewbugtitle = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.btnresetbug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbugclass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbugmethod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlinenumber = new System.Windows.Forms.TextBox();
            this.btnsavebug = new System.Windows.Forms.Button();
            this.lblbugname = new System.Windows.Forms.Label();
            this.txtbugname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblidentifyby = new System.Windows.Forms.Label();
            this.cmbidentifyby = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picerror = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.lblproject = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picerror)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Bug";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbladdnewbugtitle
            // 
            this.lbladdnewbugtitle.AutoSize = true;
            this.lbladdnewbugtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewbugtitle.Location = new System.Drawing.Point(32, 108);
            this.lbladdnewbugtitle.Name = "lbladdnewbugtitle";
            this.lbladdnewbugtitle.Size = new System.Drawing.Size(66, 29);
            this.lbladdnewbugtitle.TabIndex = 1;
            this.lbladdnewbugtitle.Text = "Title";
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(278, 108);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(222, 32);
            this.txttitle.TabIndex = 2;
            // 
            // btnresetbug
            // 
            this.btnresetbug.BackColor = System.Drawing.Color.Teal;
            this.btnresetbug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetbug.ForeColor = System.Drawing.Color.White;
            this.btnresetbug.Location = new System.Drawing.Point(400, 551);
            this.btnresetbug.Name = "btnresetbug";
            this.btnresetbug.Size = new System.Drawing.Size(120, 53);
            this.btnresetbug.TabIndex = 7;
            this.btnresetbug.Text = "Reset";
            this.btnresetbug.UseVisualStyleBackColor = false;
            this.btnresetbug.Click += new System.EventHandler(this.btnresetbug_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // txtbugclass
            // 
            this.txtbugclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugclass.Location = new System.Drawing.Point(278, 237);
            this.txtbugclass.Name = "txtbugclass";
            this.txtbugclass.Size = new System.Drawing.Size(222, 32);
            this.txtbugclass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Method";
            // 
            // txtbugmethod
            // 
            this.txtbugmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugmethod.Location = new System.Drawing.Point(278, 172);
            this.txtbugmethod.Name = "txtbugmethod";
            this.txtbugmethod.Size = new System.Drawing.Size(222, 32);
            this.txtbugmethod.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // datetime
            // 
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(278, 312);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(222, 26);
            this.datetime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Line Number";
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlinenumber.Location = new System.Drawing.Point(278, 372);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(222, 32);
            this.txtlinenumber.TabIndex = 2;
            // 
            // btnsavebug
            // 
            this.btnsavebug.BackColor = System.Drawing.Color.Orange;
            this.btnsavebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavebug.ForeColor = System.Drawing.Color.White;
            this.btnsavebug.Location = new System.Drawing.Point(37, 551);
            this.btnsavebug.Name = "btnsavebug";
            this.btnsavebug.Size = new System.Drawing.Size(181, 53);
            this.btnsavebug.TabIndex = 7;
            this.btnsavebug.Text = "SaveBug";
            this.btnsavebug.UseVisualStyleBackColor = false;
            this.btnsavebug.Click += new System.EventHandler(this.btnsavebug_Click);
            // 
            // lblbugname
            // 
            this.lblbugname.AutoSize = true;
            this.lblbugname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbugname.Location = new System.Drawing.Point(32, 437);
            this.lblbugname.Name = "lblbugname";
            this.lblbugname.Size = new System.Drawing.Size(135, 29);
            this.lblbugname.TabIndex = 1;
            this.lblbugname.Text = "Bug Name";
            // 
            // txtbugname
            // 
            this.txtbugname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugname.Location = new System.Drawing.Point(278, 437);
            this.txtbugname.Name = "txtbugname";
            this.txtbugname.Size = new System.Drawing.Size(222, 32);
            this.txtbugname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class Library";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(969, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 32);
            this.textBox1.TabIndex = 2;
            // 
            // lblidentifyby
            // 
            this.lblidentifyby.AutoSize = true;
            this.lblidentifyby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentifyby.Location = new System.Drawing.Point(728, 183);
            this.lblidentifyby.Name = "lblidentifyby";
            this.lblidentifyby.Size = new System.Drawing.Size(165, 29);
            this.lblidentifyby.TabIndex = 11;
            this.lblidentifyby.Text = "Identified By:";
            // 
            // cmbidentifyby
            // 
            this.cmbidentifyby.FormattingEnabled = true;
            this.cmbidentifyby.Location = new System.Drawing.Point(969, 187);
            this.cmbidentifyby.Name = "cmbidentifyby";
            this.cmbidentifyby.Size = new System.Drawing.Size(297, 28);
            this.cmbidentifyby.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code";
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcode.Location = new System.Drawing.Point(969, 274);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(297, 139);
            this.txtcode.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Error Snapshot";
            // 
            // picerror
            // 
            this.picerror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picerror.Location = new System.Drawing.Point(969, 491);
            this.picerror.Name = "picerror";
            this.picerror.Size = new System.Drawing.Size(297, 181);
            this.picerror.TabIndex = 15;
            this.picerror.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.DimGray;
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(742, 567);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(146, 55);
            this.btnbrowse.TabIndex = 16;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // lblproject
            // 
            this.lblproject.AutoSize = true;
            this.lblproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproject.Location = new System.Drawing.Point(22, 70);
            this.lblproject.Name = "lblproject";
            this.lblproject.Size = new System.Drawing.Size(96, 29);
            this.lblproject.TabIndex = 1;
            this.lblproject.Text = "Project";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // addnewbug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1472, 701);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.picerror);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbidentifyby);
            this.Controls.Add(this.lblidentifyby);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.btnsavebug);
            this.Controls.Add(this.btnresetbug);
            this.Controls.Add(this.txtbugmethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbugname);
            this.Controls.Add(this.lblbugname);
            this.Controls.Add(this.txtlinenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbugclass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblproject);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lbladdnewbugtitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "addnewbug";
            this.Load += new System.EventHandler(this.addnewbug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladdnewbugtitle;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btnresetbug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbugclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbugmethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlinenumber;
        private System.Windows.Forms.Button btnsavebug;
        private System.Windows.Forms.Label lblbugname;
        private System.Windows.Forms.TextBox txtbugname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblidentifyby;
        private System.Windows.Forms.ComboBox cmbidentifyby;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picerror;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label lblproject;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}