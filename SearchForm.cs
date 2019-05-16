using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Bug_Trakking_System
{
    public partial class SearchForm : Form
    {
        ManageBugClass mc = new ManageBugClass();
        ProjectClass pc = new ProjectClass();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = mc.bugbybugname(txtbugname.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = pc.projectbyprojectname(projectname.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = pc.projectbyprojectname(projectname.Text);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        Bug_SolutionClass bc = new Bug_SolutionClass();

        private void button4_Click(object sender, EventArgs e)
        {
            datagridsolution.DataSource = bc.solutionbysolutionid(Int32.Parse(txtsolution.Text));
        }
    }
}
