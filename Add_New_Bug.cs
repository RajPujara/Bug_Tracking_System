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
    public partial class addnewbug : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
        public addnewbug()
        {
            InitializeComponent();
        }

        private void addnewbug_Load(object sender, EventArgs e)
        {

        }
        public void clearbox()
        {
            txtaddnewbugtitle.Text = "";
            comboaddnewbugselectproject.Text = "";
            comboaddnewbugselecttype.Text = "";
            comboaddnewbugassignedto.Text = "";
            comboaddnewbugstatus.Text = "";
            richtextboxaddnewbugdescription.Text = "";
            datetime.Text = "";
            txtbuglinenumber.Text = "";
            txtbugmethod.Text = "";

        }

        private void btnsavebug_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("Managebugs", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@title", txtaddnewbugtitle.Text.Trim());
            
        }

        private void btnresetbug_Click(object sender, EventArgs e)
        {
            clearbox();
        }
    }
}
