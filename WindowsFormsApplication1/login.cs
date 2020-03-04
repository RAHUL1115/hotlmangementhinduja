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
    public partial class loginwindow : Form
    {
        public loginwindow()
        {
            InitializeComponent();
            if (Program.con.State == ConnectionState.Open) { databaseloading.Dispose(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread wt = new System.Threading.Thread(connThreadFn);
            wt.Start();
        }

        private void connThreadFn()
        {
            if (Program.con.State == ConnectionState.Closed) { Program.con.Open(); }
            try
            {
                Program.li.databaseloading.Invoke((Action)delegate { Program.li.databaseloading.Dispose(); });
            }
            catch (Exception e)
            { }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {Application.Exit();}

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            Program.onclick();
        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton_Click(null, null);
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            String query = "select * from login where id='" + logintxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr[1].ToString() == passtxt.Text)
                {
                    Program.inf.id = logintxt.Text;
                    this.Dispose();
                    if (sdr[2].ToString() == "m")
                    {
                        Program.onclick1();
                        sdr.Close();
                        cmd.Dispose();
                    }
                    else {
                        if (sdr[2].ToString() == "o")
                        {
                            Program.onclick();
                            sdr.Close();
                        }
                        else
                        {
                            label1.Text = "invalid user";
                            sdr.Close();
                        }
                    }       
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

        private void forget_Click(object sender, EventArgs e)
        {
            forget1.Visible = true;
            forget1.BringToFront();
        }
    }
}
