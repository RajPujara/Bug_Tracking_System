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
            int r = mp.manageprojects(0, txtprojecttitle.Text, Int32.Parse(comboprojecttype.Text), Int32.Parse(comboprogramminglanguage.Text), richtxtboxaddnewprojectdescription.Text, DateTime.Now.ToString(), DateTime.Now.ToString(), 1);
            if (r >= 1)
            {
                MessageBox.Show("project Added Successfully");
            }
            else
            {
                MessageBox.Show("Fail");
            }



            //SqlConnection sc = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
            //SqlCommand com = new SqlCommand("INSERT INTO project (project_title,project_type_id,programming_language_id,description,created_at,updated_at) VALUES (@project_title,@project_type_id,@programming_language_id,@description,@created_at,@updated_at)", sc);
            //com.CommandType = CommandType.Text;
            //com.Parameters.AddWithValue("@project_title", txtprojecttitle.Text);
            //com.Parameters.AddWithValue("@project_type_id", Int32.Parse(comboprojecttype.SelectedValue.ToString()));
            //com.Parameters.AddWithValue("programming_language_id", Int32.Parse(comboprogramminglanguage.SelectedValue.ToString()));
            //com.Parameters.AddWithValue("@description", richtxtboxaddnewprojectdescription.Text);
            clearbox();
        }
        public void clearbox()
        {
            txtprojecttitle.Text = "";
            comboprojecttype.Text = "";
            comboprogramminglanguage.Text = "";
            richtxtboxaddnewprojectdescription.Text = "";
        }

        private void btnaddprojectreset_Click(object sender, EventArgs e)
        {
            clearbox();
        }
    }

    internal class Manageproject
    {
    }

    internal class manageproject
    {
    }
}
