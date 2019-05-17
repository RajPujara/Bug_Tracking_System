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
    public partial class projectreport : Form 
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;Integrated Security=true;");
        public projectreport()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            SqlDataAdapter adt;
            conn.Open();
            DataTable dt = new DataTable();
            adt = new SqlDataAdapter("SELECT * FROM project_table", conn);
            adt.Fill(dt);
            datagridviewprojectreport.DataSource = dt;
            conn.Close();
        }

        private void Project_Report_Load(object sender, EventArgs e)
        {

        }

        private void datagridviewprojectreport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
