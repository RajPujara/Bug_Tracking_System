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
using System.Data.OleDb;
using System.Data.SqlClient;
using Bug_Trakking_System;
using DataAccessLayer;
using MainMenu = Bug_Trakking_System.MainMenu;

namespace BugTrakkingSystem
{
    public partial class loginform : Form
    {
        UserClass uc = new UserClass();
        public loginform()
        {
           

            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string role = uc.role(txtusername.Text, txtpassword.Text);
            if (role=="admin")
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();
            }
            else if (role=="tester")
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.btnadduser.Enabled = false;
                mm.btnbugsreport.Enabled = false;
                mm.btnprojectreport.Enabled = false;
                mm.btnusersreport.Enabled = false;
                mm.btnaddproject.Enabled = false;
                mm.dashboardToolStripMenuItem.Enabled = false;
                mm.administratorToolStripMenuItem.Enabled = false;
                mm.reportsToolStripMenuItem.Enabled = false;
                mm.Show();
            }
            else if (role=="developer")
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.btnadduser.Enabled = false;
                
                mm.Show();
            }
            else
            {
                MessageBox.Show("You donot have permission");
            }

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;Integrated Security=true");
            //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + txtusername.Text
            //    + "'and password = '" + txtpassword.Text + "'", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{

            //    MainMenu mm = new MainMenu();
            //    mm.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Please enter correct username or password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchnagepassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
        }
    }
}

   

