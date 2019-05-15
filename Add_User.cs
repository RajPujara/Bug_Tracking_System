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
using DataAccessLayer;
using System.Text.RegularExpressions;

namespace Bug_Trakking_System
{
    public partial class addnewuser : Form
    {
        UserClass uc = new UserClass();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
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
            txtuserregistrationname.Text = "";

        }
        private void btnuserregistrationreset_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        private void btnuserregistrationsubmit_Click(object sender, EventArgs e)
        {
            //clearbox();
            if (txtuserregistrationname.Text == "" || txtregistrationpassword.Text == "")
            {
                MessageBox.Show("please fill mendetory field");
            }
            else if (txtregistrationpassword.Text != txtregistrationconformpassword.Text)
            {
                MessageBox.Show("Passwword do not match");
            }
            else 
            {
                if (!isemailvalid())
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    int r = uc.manageusers(0, txtregistrationusername.Text, txtregistrationpassword.Text, combolbluserregistrationlevel.Text, txtuserregistrationmobile.Text, txtuserregistrationemail.Text
                        , txtuserregistrationdob.Text, txtuserregistrationaddress.Text, DateTime.Now.ToString(), txtuserregistrationname.Text, DateTime.Now.ToString(), 1);
                    if (r >= 1)
                    {
                        MessageBox.Show("User Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
                //SqlConnection sc = new SqlConnection();
                //SqlCommand com = new SqlCommand();
                //sc.ConnectionString = ("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
                //sc.Open();

                //com.Connection = sc;
                //com.CommandText = @"INSERT INTO users (username, password, user_level, mobile, email, DOB, address, full_name) VALUES (@username, @password, @user_level, @mobile, @email, @DOB, @address,@fullname)";
                //com.Parameters.AddWithValue("@username", txtregistrationusername.Text);
                //com.Parameters.AddWithValue("@password", txtregistrationpassword.Text);
                //com.Parameters.AddWithValue("@user_level", combolbluserregistrationlevel.Text);
                //com.Parameters.AddWithValue("@mobile", txtuserregistrationmobile.Text);
                //com.Parameters.AddWithValue("@email", txtuserregistrationemail.Text);
                //com.Parameters.AddWithValue("@DOB", txtuserregistrationdob.Text);
                //com.Parameters.AddWithValue("@address", txtuserregistrationaddress.Text);
                //com.Parameters.AddWithValue("@fullname", txtuserregistrationname.Text);
                //com.ExecuteNonQuery();
                //sc.Close();
            }
        }

        private void txtuserregistrationname_TextChanged(object sender, EventArgs e)
        {

        }

        private void combolbluserregistrationlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnchnagepassword_Click(object sender, EventArgs e)
        {
            
        }

        private void txtuserregistrationemail_TextChanged(object sender, EventArgs e)
        {
            

        }

        public bool isemailvalid()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtuserregistrationemail.Text.Trim());
            return isValid;
        }
    }
    }

