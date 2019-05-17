using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLogicLayer;

namespace Bug_Trakking_System
{
    public partial class addnewproject : Form
    {

        ProjectClass mp = new ProjectClass();
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
        public addnewproject()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        
        private void addnewproject_Load(object sender, EventArgs e)
        {

        }

        private void btnadprojectsubmit_Click(object sender, EventArgs e)
        {
            if(txtprojecttitle.Text==""||richtxtboxaddnewprojectdescription.Text=="")
            {
                MessageBox.Show("Blank field");
            }
            else
            {
                addproject();
            }
           

        }

        private void addproject()
        {
            int res = mp.Manageprojects(0, txtprojecttitle.Text, dateTimePicker1.Text, dateTimePicker2.Text, richtxtboxaddnewprojectdescription.Text, 1);
            if (res > 0)
            {
                MessageBox.Show("New project added successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void clearbox()
        {
           
        }

        private void btnaddprojectreset_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class Manageproject
    {
    }

    internal class manageproject
    {
    }
}
