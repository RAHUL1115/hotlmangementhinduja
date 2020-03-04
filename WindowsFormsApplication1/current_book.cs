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
    public partial class current_book : UserControl
    {
        public string room;
        public current_book()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
            {
                Program.con.Open();
            }
            string date1 = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string query = "update current_book set fname='" + fnametextbox.Text + "',lname='" + lnametextbox.Text + "',email='" + emailtextbox.Text + "',address='" + addresstextbox.Text + "',cintime=CONVERT(TIME, GETDATE()),cindate=CONVERT(date, GETDATE()),coutdate='" + date1 + "',no_pep=" + peopleselect.selectedValue + ", regid=replace(replace(replace(convert(varchar,getdate(),20),' ',''),':',''),'-','') where room =" + room ;
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            messageboxcs mb = new messageboxcs();
            mb.Show();
            this.Visible = false;
            mb.bunifuCustomLabel1.Text = "room no "+room+" is booked";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            label5.ResetText();
        }

        private void current_book_Leave(object sender, EventArgs e)
        {

        }
    }
}
