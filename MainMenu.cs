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

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void bugSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug_Solution bs = new Bug_Solution();
            bs.Show();


        }

        private void searchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void projectReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectreport pr = new projectreport();
            pr.Show();
        }

        private void bugReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugreport br = new bugreport();
            br.Show();
        }

        private void usersReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userreport ur = new userreport();
            ur.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutus about = new aboutus();
            about.Show();
        }

        private void gitHubmenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RajPujara/Bug_Tracking_System");
        }

        private void lognToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform lf = new loginform();
            lf.Show();
        }

        private void bugSolutionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bug_Solution_Report bsr = new Bug_Solution_Report();
            bsr.Show();
        }
    }
}
