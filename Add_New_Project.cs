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
       
        
        //SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
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
}
