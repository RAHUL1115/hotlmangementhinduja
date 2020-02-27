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
    public partial class roomfilmenuewindow : Form
    {
        public string room;
        public string roomno;
        public roomfilmenuewindow()
        {
            InitializeComponent();
        }

        private void roomfilmenuewindow_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cancle_click(object sender, EventArgs e)
        {
            canclewin1.BringToFront();
            canclewin1.Visible = true;
            //if (Program.con.State == ConnectionState.Closed)
            //{
            //    Program.con.Open();
            //}
            //string query = room;
            //SqlCommand cmd = new SqlCommand(query, Program.con);
            //cmd.ExecuteNonQuery();
            //Dispose();
            //cmd.Dispose();
            //Program.ep.refresh();
        }

        private void servicesbutton_Click(object sender, EventArgs e)
        {
            services1.BringToFront();
            services1.Visible = true;
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            checkout1.BringToFront();
            checkout1.Visible = true;
        }

        private void roomfilmenuewindow_Load(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            String query1 = "select fname,lname from current_book where room=" + roomno;
            SqlCommand cmd1 = new SqlCommand(query1, Program.con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr1.Read())
            {
                namel.Text = sdr1[0] + " " + sdr1[1];
            }
        }
    }
}
