using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class checkout : UserControl
    {
        public string room;
        public checkout()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            roomlabel.Text = room;
            roomlabel.Visible = true;

        }

        private void MainCheckoutButton_Click(object sender, EventArgs e)
        {
            string query1 = "select *,CONVERT(varchar,cindate,23) from current_book where room=" + room;
            string query2 = " ";
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd1 = new SqlCommand(query1, Program.con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr1.Read())
            {
                string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                string time1 = DateTime.Now.ToString("HH:mm");
                query2 = "insert into history values(" + room + ",'" + sdr1[2] + "', '" + sdr1[3] + "', '" + sdr1[4] + "', '" + sdr1[5] + "', '" + sdr1[6] + "', '" + sdr1[11] + "','" + time1 + "' , '" + date1 + "', " + sdr1[9] + "," + totallabel.Text + ",'Checkout')";
            }
            cmd1.Dispose();
            sdr1.Close();
            string query = "update current_book set fname = null,lname = null ,email = null ,address = null,cintime = null,cindate = null ,coutdate = null,no_pep = null where room = " + room + "; " + query2;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            messageboxcs mb = new messageboxcs();
            mb.bunifuCustomLabel1.Text = "room no " + room + " is checked out";
            mb.Show();
        }
    }
}
