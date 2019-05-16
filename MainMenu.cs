using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrakkingSystem;

namespace Bug_Trakking_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewproject addproject = new addnewproject();
            addproject.Show();
            
        }

        private void addNewBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewbug addbug = new addnewbug();
            addbug.Show();
            
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewuser adduser = new addnewuser();
            adduser.Show();
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutus about = new aboutus();
            about.Show();
        }

        private void lognToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform login = new loginform();
            login.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewProjectTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_new_project_type addnewprojecttype = new Add_new_project_type();
            addnewprojecttype.Show();

        }

        private void programmingLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programming_language programminglanguage = new Programming_language();
            programminglanguage.Show();
        }

        private void addNewBugTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_new_bug_type addnewbugtype = new Add_new_bug_type();
            addnewbugtype.Show();
        }

        private void projectReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectreport projectreport = new projectreport();
            projectreport.Show();
        }

        private void bugReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugreport bugreport = new bugreport();
            bugreport.Show();
        }

        private void usersReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userreport userreport = new userreport();
            userreport.Show();
        }

        private void btnaddproject_Click(object sender, EventArgs e)
        {
            addnewproject addproject = new addnewproject();
            addproject.Show();
        }

        private void btnprojectreport_Click(object sender, EventArgs e)
        {
            projectreport projectreport = new projectreport();
            projectreport.Show();
        }

        private void btnaddbugs_Click(object sender, EventArgs e)
        {
            addnewbug addbug = new addnewbug();
            addbug.Show();
        }

        private void btnbugsreport_Click(object sender, EventArgs e)
        {
            bugreport bugreport = new bugreport();
            bugreport.Show();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            addnewuser adduser = new addnewuser();
            adduser.Show();
        }

        private void btnusersreport_Click(object sender, EventArgs e)
        {
            userreport userreport = new userreport();
            userreport.Show();
        }

        private void bugSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug_Solution bugsolution = new Bug_Solution();
            bugsolution.Show();
        }

        private void searchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.Show();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gitHubmenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RajPujara/Bug_Tracking_System");
        }
    }
}
