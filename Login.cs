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
using MainMenu = Bug_Trakking_System.MainMenu;

namespace BugTrakkingSystem
{
    public partial class loginform : Form
    {
        SqlConnection con = new SqlConnection();
        public loginform()
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";

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

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;Integrated Security=true");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username = '" + txtusername.Text
                + "'and password = '" + txtpassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter correct username or password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
    }
}

   

