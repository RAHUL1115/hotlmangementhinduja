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
    public partial class pre_book : UserControl
    {
        public string room;
        public pre_book()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            label5.ResetText();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
            {
                Program.con.Open();
            }
            string date1 = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd");
            string query = "insert into pre_book values("+room +",'" + fnametextbox.Text + "','" + lnametextbox.Text + "','" + emailtextbox.Text + "','" + addresstextbox.Text +"', CONVERT(TIME, GETDATE()),'"+date1+"', '" + date2 + "'," + peopleselect.selectedValue + ")";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            messageboxcs mb = new messageboxcs();
            mb.Show();
            this.Visible = false;
            mb.bunifuCustomLabel1.Text = "room no " + room + " is booked";
        }
    }
}
