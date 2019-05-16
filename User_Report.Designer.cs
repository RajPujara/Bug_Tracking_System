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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datagridviewuserreport
            // 
            this.datagridviewuserreport.ColumnHeadersHeight = 50;
            this.datagridviewuserreport.Location = new System.Drawing.Point(1, 76);
            this.datagridviewuserreport.Name = "datagridviewuserreport";
            this.datagridviewuserreport.RowHeadersWidth = 47;
            this.datagridviewuserreport.RowTemplate.Height = 28;
            this.datagridviewuserreport.Size = new System.Drawing.Size(1542, 601);
            this.datagridviewuserreport.TabIndex = 2;
            this.datagridviewuserreport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewuserreport_CellContentClick);
            // 
            // userreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1542, 669);
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
    }
}