﻿using EASendMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (500);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        //logintbutton
        //{
        private void button1_Click(object sender, EventArgs e)
        {
            if(Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            String query = "select * from login where id='" + logintxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            mainwindow ep = new mainwindow();
            ep.label3.Text = logintxt.Text;
            if (sdr.Read())
            {
                if (sdr[1].ToString() == passtxt.Text)
                {
                    Program.inf.id = logintxt.Text;
                    sdr.Close();
                    Program.con.Close();
                    this.Dispose();
                    Program.onclick();
                    
                }
                else
                {
                    label1.Text = "wrong password";
                    sdr.Close();
                }
            }
            else
            {
                label1.Text = "wrong username";
                sdr.Close();
            }
        }
        //}

           
        private void label1_Click(object sender, EventArgs e)
        {

            functions fc = new functions();
            fc.user = logintxt.Text;
            this.Dispose();
            Program.onclick();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            loadingcontrol1.Dispose();
        }
    }
}
