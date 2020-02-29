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
    public partial class canclewin : UserControl
    {
        public string room;
        public canclewin()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }
        public void canclewin_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string query1 = "select  fname, lname from pre_book where room = "+room +" ";
            string query = "select fname, lname from pre_book";
            //query = query1;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listBox1.Items.Add(sdr[0] + " " + sdr[1]);
            }
            cmd.Dispose();
            sdr.Close();
        }

        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query3 = "";
            string name = "" + listBox1.SelectedItem;
            if (name != "")
            {
                string query1 = "select *,CONVERT(varchar,cindate,23) from pre_book";
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                SqlCommand cmd1 = new SqlCommand(query1, Program.con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                if(sdr1.Read())
                {
                    string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                    string time1 = DateTime.Now.ToString("HH:mm");
                    query3 = "insert into history values("+sdr1[0]+",'"+ sdr1[1] + "', '"+ sdr1[2] + "', '"+ sdr1[3] + "', '" + sdr1[4] + "', '" + sdr1[5] + "', '" + sdr1[9] + "','" + time1 + "' , '" + date1 + "', "+sdr1[8] + "," + 0 + ",'cancle')";
                }
                cmd1.Dispose();
                sdr1.Close();
                string[] names = name.Split(' ');
                string query = "delete from pre_book where fname = '" + names[0] + "' and lname = '" + names[1] + "' and room =" + room +"; "+query3;
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                canclewin_Load(null, null);
            }
        }
    }
}

