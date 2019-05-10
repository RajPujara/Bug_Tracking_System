namespace Bug_Trakking_System
{
    partial class aboutus
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
            this.lblaboutbugtrakkingsystem = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblaboutbugtrakkingsystem
            // 
            this.lblaboutbugtrakkingsystem.AutoSize = true;
            this.lblaboutbugtrakkingsystem.BackColor = System.Drawing.Color.Teal;
            this.lblaboutbugtrakkingsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboutbugtrakkingsystem.ForeColor = System.Drawing.Color.Yellow;
            this.lblaboutbugtrakkingsystem.Location = new System.Drawing.Point(404, 9);
            this.lblaboutbugtrakkingsystem.Name = "lblaboutbugtrakkingsystem";
            this.lblaboutbugtrakkingsystem.Size = new System.Drawing.Size(745, 64);
            this.lblaboutbugtrakkingsystem.TabIndex = 2;
            this.lblaboutbugtrakkingsystem.Text = "About Bug Trakking System";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1455, 594);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "write here about bug trakking system";
            // 
            // aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1458, 669);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblaboutbugtrakkingsystem);
            this.IsMdiContainer = true;
            this.Name = "aboutus";
            this.Text = "AboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaboutbugtrakkingsystem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}