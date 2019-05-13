using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Trakking_System
{
    
    public partial class Bug_Solution : Form
    {
        public string fileName;
        public Bug_Solution()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void clearBox()
        {
            txtaddnewbugtitle.Text = "";
            comboaddnewbugselectproject.Text = "";
            comboaddnewbugstatus.Text = "";
            richtextboxaddnewbugdescription.Text = "";
            txtboxclassbugsolution.Text = "";
            btnsolutionsnapshot.Text = "";
            btnsnapshotofsolutioncode.Text = "";
            txtbuglinenumber.Text = "";
            txtbuglinenumber.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearBox();

        }

        private void btnsolutionsnapshot_Click(object sender, EventArgs e)
        {
           // DialogResult result = openFileDialog1.ShowDialog();// show the dialog.
            //if (result==DialogResult.OK)//Test result
            {
              using(OpenFileDialog openDialog = new OpenFileDialog() {Filter= "JPEG|*.jpg|*.png", ValidateNames=true,Multiselect=false })
                {
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openDialog.FileName;
                        btnsolutionsnapshot.Text = fileName;
                        lblbugsnapshot.Image = Image.FromFile(fileName);
                    }
                }
                {
                    
                }
            }
        }

        private void btnsnapshotofsolutioncode_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog openDialog = new OpenFileDialog() { Filter = "JPEG|*.jpg|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openDialog.FileName;
                        btnsolutionsnapshot.Text = fileName;
                        lblbugsolutioncode.Image = Image.FromFile(fileName);
                    }
                }
                {

                }
            }
        }
    }
}
