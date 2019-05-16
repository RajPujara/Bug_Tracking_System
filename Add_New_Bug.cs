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
using System.IO;
using System.Drawing.Imaging;
using DataAccessLayer;
using System.Data.Sql;

namespace Bug_Trakking_System
{
    public partial class addnewbug : Form
    {
       

        ManageBugClass bc = new ManageBugClass();
        ProjectClass pc = new ProjectClass();
        public addnewbug()
        {
            InitializeComponent();
            comboBox1.DataSource = pc.getallprojects();
            comboBox1.DisplayMember = "project_title";
            comboBox1.ValueMember = "project_id";
            comboBox1.SelectedIndex = -1;
        }

        private void addnewbug_Load(object sender, EventArgs e)
        {

        }
        //public void clearbox()
        //{
        //    txttitle.Text = "";
        //    comboaddnewbugselectproject.Text = "";
        //    comboaddnewbugselecttype.Text = "";
        //    comboaddnewbugassignedto.Text = "";
        //    comboaddnewbugstatus.Text = "";
        //    richtextboxaddnewbugdescription.Text = "";
        //    txtbugclass.Text = "";
        //    txtlinenumber.Text = "";
        //    txtbugmethod.Text = "";

        //}

        private void btnsavebug_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picerror.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            int res = bc.managebug(0, datetime.Text, Int32.Parse(comboBox1.SelectedValue.ToString()), txtbugname.Text, txtbugclass.Text, txtbugmethod.Text, txtcode.Text, textBox1.Text, txtlinenumber.Text, cmbidentifyby.Text, photo, 1);
            if(res>0)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Eror");
            }
            //sc.Open();
            //int res = com.ExecuteNonQuery();
            //sc.Close();
            //if (res>=1)
            //{
            //    MessageBox.Show("Hait balla balla vayo");
            //}
            //else
            //{
            //    MessageBox.Show("I quit");
            //}




        }

        private void btnresetbug_Click(object sender, EventArgs e)
        {
            //clearbox();
        }

        private void btnbugsnapshot_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            

        }
    }
}
