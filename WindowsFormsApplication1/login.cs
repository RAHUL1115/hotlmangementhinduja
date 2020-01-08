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
            //this.Dispose();
            //Program.onclick();
            Program.con.Open();
            String query = "select * from current_booking where Id='" + logintxt.Text + "'";
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
                    label1.Text = "worng password";
                }
            }
            else
            {
                label1.Text = "wrong username";
            }
        }
        //}

        //closebutton
        //{
        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
            passtxt.UseSystemPasswordChar = false;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            passtxt.UseSystemPasswordChar = true;
        }
        //}
    }
}
