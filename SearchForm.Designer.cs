namespace Bug_Trakking_System
{
    partial class SearchForm
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
            this.lblsearchform = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.datagridsolution = new System.Windows.Forms.DataGridView();
            this.btnsolution = new System.Windows.Forms.Button();
            this.txtsolution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnprojectid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbugid = new System.Windows.Forms.Button();
            this.txtbugid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsolution)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsearchform
            // 
            this.lblsearchform.AutoSize = true;
            this.lblsearchform.BackColor = System.Drawing.Color.Teal;
            this.lblsearchform.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchform.ForeColor = System.Drawing.Color.Yellow;
            this.lblsearchform.Location = new System.Drawing.Point(427, 9);
            this.lblsearchform.Name = "lblsearchform";
            this.lblsearchform.Size = new System.Drawing.Size(590, 55);
            this.lblsearchform.TabIndex = 1;
            this.lblsearchform.Text = "Welcome to Search Form";
            this.lblsearchform.Click += new System.EventHandler(this.lblsearchform_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.datagridsolution);
            this.tabPage4.Controls.Add(this.btnsolution);
            this.tabPage4.Controls.Add(this.txtsolution);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1536, 579);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Solution";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // datagridsolution
            // 
            this.datagridsolution.AllowUserToAddRows = false;
            this.datagridsolution.AllowUserToDeleteRows = false;
            this.datagridsolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridsolution.Location = new System.Drawing.Point(0, 69);
            this.datagridsolution.Name = "datagridsolution";
            this.datagridsolution.ReadOnly = true;
            this.datagridsolution.RowTemplate.Height = 28;
            this.datagridsolution.Size = new System.Drawing.Size(1477, 449);
            this.datagridsolution.TabIndex = 9;
            // 
            // btnsolution
            // 
            this.btnsolution.Location = new System.Drawing.Point(385, 21);
            this.btnsolution.Name = "btnsolution";
            this.btnsolution.Size = new System.Drawing.Size(140, 42);
            this.btnsolution.TabIndex = 8;
            this.btnsolution.Text = "Search";
            this.btnsolution.UseVisualStyleBackColor = true;
            this.btnsolution.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtsolution
            // 
            this.txtsolution.Location = new System.Drawing.Point(176, 25);
            this.txtsolution.Multiline = true;
            this.txtsolution.Name = "txtsolution";
            this.txtsolution.Size = new System.Drawing.Size(160, 33);
            this.txtsolution.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Solution ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1536, 579);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Project";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1475, 544);
            this.dataGridView3.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.btnprojectid);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1475, 86);
            this.panel3.TabIndex = 6;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(396, 24);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(140, 42);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnprojectid
            // 
            this.btnprojectid.Location = new System.Drawing.Point(187, 28);
            this.btnprojectid.Multiline = true;
            this.btnprojectid.Name = "btnprojectid";
            this.btnprojectid.Size = new System.Drawing.Size(160, 33);
            this.btnprojectid.TabIndex = 4;
            this.btnprojectid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project Nmae";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1536, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1485, 534);
            this.dataGridView2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnbugid);
            this.panel2.Controls.Add(this.txtbugid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 86);
            this.panel2.TabIndex = 5;
            // 
            // btnbugid
            // 
            this.btnbugid.Location = new System.Drawing.Point(396, 24);
            this.btnbugid.Name = "btnbugid";
            this.btnbugid.Size = new System.Drawing.Size(140, 42);
            this.btnbugid.TabIndex = 5;
            this.btnbugid.Text = "Search";
            this.btnbugid.UseVisualStyleBackColor = true;
            this.btnbugid.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbugid
            // 
            this.txtbugid.Location = new System.Drawing.Point(187, 28);
            this.txtbugid.Multiline = true;
            this.txtbugid.Name = "txtbugid";
            this.txtbugid.Size = new System.Drawing.Size(160, 33);
            this.txtbugid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bug Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1544, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1493, 669);
            this.Controls.Add(this.lblsearchform);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsolution)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsearchform;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView datagridsolution;
        private System.Windows.Forms.Button btnsolution;
        private System.Windows.Forms.TextBox txtsolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox btnprojectid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbugid;
        private System.Windows.Forms.TextBox txtbugid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}