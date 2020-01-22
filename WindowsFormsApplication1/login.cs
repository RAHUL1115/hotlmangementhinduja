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

        }

        //logintbutton
        //{
        private void button1_Click(object sender, EventArgs e)
        {
            if(Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            String query = "select * from login where Id='" + logintxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr[1].ToString() == passtxt.Text)
                {
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
            this.Dispose();
            Program.onclick();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }
        //}
    }
}
