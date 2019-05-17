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
using System.Data.Sql;


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
            txtfullname.Text = "";
            txtpassword.Text = "";
            txtusername.Text = "";
            txtconformpassword.Text = "";
            cmbrole.Text = "";

        }
        private void btnuserregistrationreset_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        public bool isvalid()
        {
            if (txtfullname.Text==""|| txtusername.Text==""||txtpassword.Text==""||txtconformpassword.Text=="")
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        private void btnuserregistrationsubmit_Click(object sender, EventArgs e)
        {
            if (isvalid() == true)
            {
                AddUser();
            }
            else
            {
                MessageBox.Show( "Please fill the form!!");
            }
        }

        private void AddUser()
        {
            if (txtpassword.Text == txtconformpassword.Text)
            {
                int res = uc.manageusers(0, txtfullname.Text, txtusername.Text, txtpassword.Text, cmbrole.Text, 1);
                if (res > 0)
                {

                    MessageBox.Show("New user added successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Password didn't match");
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

        

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
        






        private void btndelete_Click(object sender, EventArgs e)
        {
            //userreport ur = new userreport();
            //ur.Show();
            //string selected_cid = datagridviewuserreport.CurrentRow.cells["ID"].Value.Tostring();
            //string selected_cun = datagridviewuserreport.CurrentRow.cells["username"].Value.Tostring();
            //string selected_cpp = datagridviewuserreport.CurrentRow.cells["password"].Value.Tostring();
            //string selected_cmb = datagridviewuserreport.CurrentRow.cells["mobile"].Value.Tostring();
            //string selected_ceml = datagridviewuserreport.CurrentRow.cells["email"].Value.Tostring();
            //string selected_cdob = datagridviewuserreport.CurrentRow.cells["DOB"].Value.Tostring();
            //string selected_cadd = datagridviewuserreport.CurrentRow.cells["address"].Value.Tostring();
            //string selected_ccre = datagridviewuserreport.CurrentRow.cells["created_at"].Value.Tostring();
            //string selected_cupd = datagridviewuserreport.CurrentRow.cells["updated_at"].Value.Tostring();
            //string selected_cfn = datagridviewuserreport.CurrentRow.cells["full_name"].Value.Tostring();

            //string delete_row = "delete * from users where id = '" + selected_cid + "'AND username='" + selected_cun + "' AND  password='" + selected_cpp + "' ' AND  mobile='" + selected_cmb + "' ' AND  email='" + selected_ceml + "' ' AND  DOB='" + selected_cdob + "' ' AND  address='" + selected_cadd + "' ' AND  created_at='" + selected_ccre + "' ' AND  updated_at='" + selected_cupd + "' ' AND  full_name='" + selected_cfn + "' ";
            //int count = DataAccess.execute(delete_row);



        }



        private void txtuserregistrationdob_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtuserregistrationmobile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtuserregistrationmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch!=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtuserregistrationdob_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtuserregistrationdob_Validating(object sender, CancelEventArgs e)
        {
            
        }

        
    }
}

