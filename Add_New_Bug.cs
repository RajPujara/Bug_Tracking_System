﻿using System;
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
            txtbugclass.Text = "";
            txtbuglinenumber.Text = "";
            txtbugmethod.Text = "";

        }

        private void btnsavebug_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source=DESKTOP-ADDN5I4;Initial Catalog=project;User ID=sa;Password=passion_10");
            sc.Open();
            com.Connection = sc;
            com.CommandText = @"INSERT INTO bug(title,project_id,bug_type_id,assigned_to,bug_status,description,class,image_path,image_url,date,line_number,method)";
            com.Parameters.AddWithValue("@title", txtaddnewbugtitle.Text);
            com.Parameters.AddWithValue("@project_id", txtaddnewbugtitle.Text);
        }

        private void btnresetbug_Click(object sender, EventArgs e)
        {
            clearbox();
        }
    }
}
