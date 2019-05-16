using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        HelperClass hc = new HelperClass();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //public void clearBox()
        //{
        //    txtaddnewbugtitle.Text = "";
        //    comboaddnewbugselectproject.Text = "";
        //    comboaddnewbugstatus.Text = "";
        //    richtextboxaddnewbugdescription.Text = "";
        //    txtboxclassbugsolution.Text = "";
        //   btnsolutionsnapshot.Text = "";
            
        //    txtbuglinenumber.Text = "";
        //    txtbuglinenumber.Text = "";
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //clearBox();

        }

        private void btnsolutionsnapshot_Click(object sender, EventArgs e)
        {
           // DialogResult result = openFileDialog1.ShowDialog();// show the dialog.
            //if (result==DialogResult.OK)//Test result
            {
              using(OpenFileDialog openDialog = new OpenFileDialog() {Filter= "JPEG|*.jpg|*.png", ValidateNames=true,Multiselect=false })
                {
                    //if (openDialog.ShowDialog() == DialogResult.OK)
                    //{
                    //    fileName = openDialog.FileName;
                    //    btnsolutionsnapshot.Text = fileName;
                    //    lblbugsnapshot.Image = Image.FromFile(fileName);
                    //}
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
                    //if (openDialog.ShowDialog() == DialogResult.OK)
                    //{
                    //    fileName = openDialog.FileName;
                    //    btnsolutionsnapshot.Text = fileName;
                        
                    //}
                }
                {

                }
            }
        }

        private void lblsavenewbug_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
           // pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picsolution.Image = new Bitmap(open.FileName);
                
            }

            //try
            //{
            //    try
            //    {
            //        OpenFileDialog ofd = new OpenFileDialog();
            //        if (ofd.ShowDialog() == DialogResult.OK)
            //        {
            //            picsolution.Image = Image.FromFile(ofd.FileName);

            //        }
            //        else
            //        {
            //            MessageBox.Show("Please select a Bug picture");
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnsavebug_Click(object sender, EventArgs e)
        {

        }
    }
}
