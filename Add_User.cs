using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bug_Trakking_System
{
    public partial class addnewuser : Form
    {

        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");

       


        public addnewuser()
        {
            InitializeComponent();
            
        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }
        public void clearbox()
        {
            txtuserregistrationname.Text = "";
            combolbluserregistrationlevel.Text = "";
            txtregistrationusername.Text = "";
            txtregistrationpassword.Text = "";
            txtregistrationconformpassword.Text = "";
            txtuserregistrationmobile.Text = "";
            txtuserregistrationemail.Text = "";
            txtuserregistrationdob.Text = "";
            txtuserregistrationaddress.Text = "";

        }
        private void btnuserregistrationreset_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        private void btnuserregistrationsubmit_Click(object sender, EventArgs e)
        {
            if (txtuserregistrationname.Text == "" || txtregistrationpassword.Text == "")
            {
                MessageBox.Show("please fill mendetory field");
            }
            else if (txtregistrationpassword.Text != txtregistrationconformpassword.Text)
            {
                MessageBox.Show("Passwword donot match");
            }
            else
            {
                //using (SqlConnection sqlcon = new SqlConnection(connectionString))
               // {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("ManageUsers", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@username",txtuserregistrationname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@password",txtregistrationpassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@conformpassword",txtregistrationconformpassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@mobile",txtuserregistrationmobile.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@email",txtuserregistrationemail.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@DOB",txtuserregistrationdob.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@DOB",txtuserregistrationaddress.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successful");
                    clearbox();
                //}

            }
        }

        private void txtuserregistrationname_TextChanged(object sender, EventArgs e)
        {

        }

        private void combolbluserregistrationlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
    }

