namespace Bug_Trakking_System
{
    partial class Add_new_bug_type
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
            this.lbladdnewbugtype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladdnewbugtype
            // 
            this.lbladdnewbugtype.AutoSize = true;
            this.lbladdnewbugtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewbugtype.ForeColor = System.Drawing.Color.Yellow;
            this.lbladdnewbugtype.Location = new System.Drawing.Point(395, 9);
            this.lbladdnewbugtype.Name = "lbladdnewbugtype";
            this.lbladdnewbugtype.Size = new System.Drawing.Size(522, 64);
            this.lbladdnewbugtype.TabIndex = 0;
            this.lbladdnewbugtype.Text = "Add New Bug Type";
            // 
            // Add_new_bug_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1493, 669);
            this.Controls.Add(this.lbladdnewbugtype);
            this.Name = "Add_new_bug_type";
            this.Text = "Add_new_bug_type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdnewbugtype;
    }
}