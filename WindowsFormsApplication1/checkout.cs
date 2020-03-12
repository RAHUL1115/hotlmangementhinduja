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
        public string room1="0";
        public string total;
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
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            room1 = Program.inf.room;
            roomlabel.Text = Program.inf.room;
            roomlabel.Visible = true;
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "select fname, lname, ((DATEDIFF(day, cindate, '" + date1 + "')+1)*500), (select sum(price) from services where regid = cb.regid) from current_book as cb where room = " + Program.inf.room; ;
            //query = "select * from login";
            SqlCommand cmd1 = new SqlCommand(query, Program.con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr1.Read())
            {
                namelabel.Text = sdr1[0] + " " + sdr1[1];
                namelabel.Visible = true;
                amountlabel.Text = "" + sdr1[2];
                amountlabel.Visible = true;
                slabel.Text = "" + sdr1[2];
                slabel.Visible = true;
                try
                {
                    total = "" + (Convert.ToInt32(sdr1[2]) + Convert.ToInt32(sdr1[3]));
                }
                catch(Exception)
                {
                    slabel.Text = "0";
                    total = "" + (Convert.ToInt32(sdr1[2]) + 0);
                }
                totallabel.Text = total;
                totallabel.Visible = true;
            }
        }

        private void MainCheckoutButton_Click(object sender, EventArgs e)
        {
            string query1 = "select *,CONVERT(varchar,cindate,23) from current_book where room=" + room1;
            string query2 = " ";
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd1 = new SqlCommand(query1, Program.con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr1.Read())
            {
                string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                string time1 = DateTime.Now.ToString("HH:mm");
                query2 = "insert into history values(" + room1 + ",'" + sdr1[2] + "', '" + sdr1[3] + "', '" + sdr1[4] + "', '" + sdr1[5] + "', '" + sdr1[6] + "', '" + sdr1[12] + "','" + time1 + "' , '" + date1 + "', " + sdr1[9] + "," + totallabel.Text + ",'Checkout','"+sdr1[10]+ "','" + sdr1[11] + "')";
            }
            cmd1.Dispose();
            sdr1.Close();
            string query = "update current_book set fname = null,lname = null ,email = null ,address = null,cintime = null,cindate = null ,coutdate = null,no_pep = null,cinstate=null,regid=null where room = " + room1 + "; " + query2;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            messageboxcs mb = new messageboxcs();
            mb.bunifuCustomLabel1.Text = "room no " + room1 + " is checked out";
            mb.Show();
        }

        private void discounttextbox_OnValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(discounttextbox.Text) > 100)
                {
                    discounttextbox.Text = "100";
                }
                totallabel.Text = "" + (Convert.ToInt32(total) - ((Convert.ToInt32(total) * Convert.ToInt32(discounttextbox.Text)) / 100));
            }
            catch (Exception)
            {
                totallabel.Text = "" + (Convert.ToInt32(total));
            }
        }
    }
}
