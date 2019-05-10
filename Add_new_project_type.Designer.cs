namespace Bug_Trakking_System
{
    partial class Add_new_project_type
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
            this.lbladdnewprojecttype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladdnewprojecttype
            // 
            this.lbladdnewprojecttype.AutoSize = true;
            this.lbladdnewprojecttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewprojecttype.ForeColor = System.Drawing.Color.Yellow;
            this.lbladdnewprojecttype.Location = new System.Drawing.Point(421, 9);
            this.lbladdnewprojecttype.Name = "lbladdnewprojecttype";
            this.lbladdnewprojecttype.Size = new System.Drawing.Size(602, 64);
            this.lbladdnewprojecttype.TabIndex = 0;
            this.lbladdnewprojecttype.Text = "Add New Project Type";
            // 
            // Add_new_project_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1458, 669);
            this.Controls.Add(this.lbladdnewprojecttype);
            this.Name = "Add_new_project_type";
            this.Text = "addnewprojecttype";
            this.Load += new System.EventHandler(this.Add_new_project_type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdnewprojecttype;
    }
}