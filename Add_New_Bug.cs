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
        
        public addnewbug()
        {
            InitializeComponent();
        }

        private void addnewbug_Load(object sender, EventArgs e)
        {

        }

        private void btnsavebug_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("Manageprojects", sqlcon);
        }
    }
}
