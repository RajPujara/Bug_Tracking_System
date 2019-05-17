namespace Bug_Trakking_System
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addnewbug = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugSolutionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lognToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gitHubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldashboardpage = new System.Windows.Forms.Label();
            this.btnusersreport = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnbugsreport = new System.Windows.Forms.Button();
            this.btnaddbugs = new System.Windows.Forms.Button();
            this.btnprojectreport = new System.Windows.Forms.Button();
            this.btnaddproject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bugAndSolutionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(196, 41);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProjectToolStripMenuItem,
            this.addnewbug,
            this.addUserToolStripMenuItem,
            this.bugSolutionToolStripMenuItem,
            this.searchFormToolStripMenuItem,
            this.bugAndSolutionReportToolStripMenuItem});
            this.administratorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(233, 41);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // addNewProjectToolStripMenuItem
            // 
            this.addNewProjectToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.addNewProjectToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProjectToolStripMenuItem.Name = "addNewProjectToolStripMenuItem";
            this.addNewProjectToolStripMenuItem.Size = new System.Drawing.Size(478, 42);
            this.addNewProjectToolStripMenuItem.Text = "Add New Project";
            this.addNewProjectToolStripMenuItem.Click += new System.EventHandler(this.addNewProjectToolStripMenuItem_Click);
            // 
            // addnewbug
            // 
            this.addnewbug.BackColor = System.Drawing.Color.SteelBlue;
            this.addnewbug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewbug.Name = "addnewbug";
            this.addnewbug.Size = new System.Drawing.Size(478, 42);
            this.addnewbug.Text = "Add New Bugs";
            this.addnewbug.Click += new System.EventHandler(this.addNewBugsToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(478, 42);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // bugSolutionToolStripMenuItem
            // 
            this.bugSolutionToolStripMenuItem.Name = "bugSolutionToolStripMenuItem";
            this.bugSolutionToolStripMenuItem.Size = new System.Drawing.Size(478, 42);
            this.bugSolutionToolStripMenuItem.Text = "Bug Solution";
            this.bugSolutionToolStripMenuItem.Click += new System.EventHandler(this.bugSolutionToolStripMenuItem_Click);
            // 
            // searchFormToolStripMenuItem
            // 
            this.searchFormToolStripMenuItem.Name = "searchFormToolStripMenuItem";
            this.searchFormToolStripMenuItem.Size = new System.Drawing.Size(478, 42);
            this.searchFormToolStripMenuItem.Text = "Search Form";
            this.searchFormToolStripMenuItem.Click += new System.EventHandler(this.searchFormToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectReportsToolStripMenuItem,
            this.bugReportsToolStripMenuItem,
            this.usersReportsToolStripMenuItem,
            this.bugSolutionReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(147, 41);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // projectReportsToolStripMenuItem
            // 
            this.projectReportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.projectReportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectReportsToolStripMenuItem.Name = "projectReportsToolStripMenuItem";
            this.projectReportsToolStripMenuItem.Size = new System.Drawing.Size(411, 42);
            this.projectReportsToolStripMenuItem.Text = "Project Reports";
            this.projectReportsToolStripMenuItem.Click += new System.EventHandler(this.projectReportsToolStripMenuItem_Click);
            // 
            // bugReportsToolStripMenuItem
            // 
            this.bugReportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.bugReportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugReportsToolStripMenuItem.Name = "bugReportsToolStripMenuItem";
            this.bugReportsToolStripMenuItem.Size = new System.Drawing.Size(411, 42);
            this.bugReportsToolStripMenuItem.Text = "Bug Reports";
            this.bugReportsToolStripMenuItem.Click += new System.EventHandler(this.bugReportsToolStripMenuItem_Click);
            // 
            // usersReportsToolStripMenuItem
            // 
            this.usersReportsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.usersReportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersReportsToolStripMenuItem.Name = "usersReportsToolStripMenuItem";
            this.usersReportsToolStripMenuItem.Size = new System.Drawing.Size(411, 42);
            this.usersReportsToolStripMenuItem.Text = "Users Reports";
            this.usersReportsToolStripMenuItem.Click += new System.EventHandler(this.usersReportsToolStripMenuItem_Click);
            // 
            // bugSolutionReportToolStripMenuItem
            // 
            this.bugSolutionReportToolStripMenuItem.Name = "bugSolutionReportToolStripMenuItem";
            this.bugSolutionReportToolStripMenuItem.Size = new System.Drawing.Size(411, 42);
            this.bugSolutionReportToolStripMenuItem.Text = "Bug Solution Report";
            this.bugSolutionReportToolStripMenuItem.Click += new System.EventHandler(this.bugSolutionReportToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem1});
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(98, 41);
            this.aboutUsToolStripMenuItem.Text = "Help";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.aboutUsToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(237, 42);
            this.aboutUsToolStripMenuItem1.Text = "AboutUs";
            this.aboutUsToolStripMenuItem1.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // lognToolStripMenuItem
            // 
            this.lognToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lognToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.lognToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lognToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lognToolStripMenuItem.Name = "lognToolStripMenuItem";
            this.lognToolStripMenuItem.Size = new System.Drawing.Size(134, 41);
            this.lognToolStripMenuItem.Text = "Logout";
            this.lognToolStripMenuItem.Click += new System.EventHandler(this.lognToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.lognToolStripMenuItem,
            this.gitHubmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1458, 81);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gitHubmenu
            // 
            this.gitHubmenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.gitHubmenu.ForeColor = System.Drawing.Color.White;
            this.gitHubmenu.Name = "gitHubmenu";
            this.gitHubmenu.Size = new System.Drawing.Size(135, 41);
            this.gitHubmenu.Text = "GitHub";
            this.gitHubmenu.Click += new System.EventHandler(this.gitHubmenu_Click);
            // 
            // lbldashboardpage
            // 
            this.lbldashboardpage.AutoSize = true;
            this.lbldashboardpage.BackColor = System.Drawing.Color.Teal;
            this.lbldashboardpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboardpage.ForeColor = System.Drawing.Color.Yellow;
            this.lbldashboardpage.Location = new System.Drawing.Point(271, 96);
            this.lbldashboardpage.Name = "lbldashboardpage";
            this.lbldashboardpage.Size = new System.Drawing.Size(918, 64);
            this.lbldashboardpage.TabIndex = 9;
            this.lbldashboardpage.Text = "Welcome To Bug Tracking System";
            // 
            // btnusersreport
            // 
            this.btnusersreport.BackColor = System.Drawing.Color.Teal;
            this.btnusersreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusersreport.ForeColor = System.Drawing.Color.White;
            this.btnusersreport.Location = new System.Drawing.Point(0, 534);
            this.btnusersreport.Name = "btnusersreport";
            this.btnusersreport.Size = new System.Drawing.Size(325, 65);
            this.btnusersreport.TabIndex = 3;
            this.btnusersreport.Text = "Users Report";
            this.btnusersreport.UseVisualStyleBackColor = false;
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.Teal;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.Location = new System.Drawing.Point(0, 463);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(325, 65);
            this.btnadduser.TabIndex = 4;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            // 
            // btnbugsreport
            // 
            this.btnbugsreport.BackColor = System.Drawing.Color.Teal;
            this.btnbugsreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbugsreport.ForeColor = System.Drawing.Color.White;
            this.btnbugsreport.Location = new System.Drawing.Point(0, 392);
            this.btnbugsreport.Name = "btnbugsreport";
            this.btnbugsreport.Size = new System.Drawing.Size(325, 65);
            this.btnbugsreport.TabIndex = 5;
            this.btnbugsreport.Text = "Bugs Report";
            this.btnbugsreport.UseVisualStyleBackColor = false;
            // 
            // btnaddbugs
            // 
            this.btnaddbugs.BackColor = System.Drawing.Color.Teal;
            this.btnaddbugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbugs.ForeColor = System.Drawing.Color.White;
            this.btnaddbugs.Location = new System.Drawing.Point(0, 321);
            this.btnaddbugs.Name = "btnaddbugs";
            this.btnaddbugs.Size = new System.Drawing.Size(325, 65);
            this.btnaddbugs.TabIndex = 6;
            this.btnaddbugs.Text = "Add New Bug";
            this.btnaddbugs.UseVisualStyleBackColor = false;
            // 
            // btnprojectreport
            // 
            this.btnprojectreport.BackColor = System.Drawing.Color.Teal;
            this.btnprojectreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprojectreport.ForeColor = System.Drawing.Color.White;
            this.btnprojectreport.Location = new System.Drawing.Point(0, 250);
            this.btnprojectreport.Name = "btnprojectreport";
            this.btnprojectreport.Size = new System.Drawing.Size(325, 65);
            this.btnprojectreport.TabIndex = 7;
            this.btnprojectreport.Text = "Project Report";
            this.btnprojectreport.UseVisualStyleBackColor = false;
            // 
            // btnaddproject
            // 
            this.btnaddproject.BackColor = System.Drawing.Color.Teal;
            this.btnaddproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproject.ForeColor = System.Drawing.Color.White;
            this.btnaddproject.Location = new System.Drawing.Point(0, 179);
            this.btnaddproject.Name = "btnaddproject";
            this.btnaddproject.Size = new System.Drawing.Size(325, 65);
            this.btnaddproject.TabIndex = 8;
            this.btnaddproject.Text = "Add Project";
            this.btnaddproject.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(331, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 487);
            this.panel1.TabIndex = 10;
            // 
            // bugAndSolutionReportToolStripMenuItem
            // 
            this.bugAndSolutionReportToolStripMenuItem.Name = "bugAndSolutionReportToolStripMenuItem";
            this.bugAndSolutionReportToolStripMenuItem.Size = new System.Drawing.Size(478, 42);
            this.bugAndSolutionReportToolStripMenuItem.Text = "Bug and Solution Report";
            this.bugAndSolutionReportToolStripMenuItem.Click += new System.EventHandler(this.bugAndSolutionReportToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldashboardpage);
            this.Controls.Add(this.btnusersreport);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.btnbugsreport);
            this.Controls.Add(this.btnaddbugs);
            this.Controls.Add(this.btnprojectreport);
            this.Controls.Add(this.btnaddproject);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem addNewProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addnewbug;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lognToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbldashboardpage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem bugSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubmenu;
        public System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        public System.Windows.Forms.Button btnusersreport;
        public System.Windows.Forms.Button btnadduser;
        public System.Windows.Forms.Button btnbugsreport;
        public System.Windows.Forms.Button btnaddbugs;
        public System.Windows.Forms.Button btnprojectreport;
        public System.Windows.Forms.Button btnaddproject;
        public System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugSolutionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugAndSolutionReportToolStripMenuItem;
    }
}