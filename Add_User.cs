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

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=***********");




        public addnewuser()
        {
            InitializeComponent();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }

        private void btnuserregistrationreset_Click(object sender, EventArgs e)
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

        private void btnuserregistrationsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string name = txtuserregistrationname.Text.ToString();
                string level = combolbluserregistrationlevel.SelectedItem.ToString();
                string username = txtregistrationusername.Text.ToString();
                string password = txtregistrationpassword.Text.ToString();
                string conformpassword = txtregistrationconformpassword.Text.ToString();
                string mobile = txtuserregistrationmobile.Text.ToString();
                string email = txtuserregistrationemail.Text.ToString();
                string dob = txtuserregistrationdob.Text.ToString();
                string address = txtuserregistrationaddress.Text.ToString();
            }
                SqlCommand sc = new SqlCommand();
            

            catch () {
            }
}
        }
    }

