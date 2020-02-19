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
            string query = "update current_book set fname='" + bunifuMaterialTextbox1.Text + "',lname='" + bunifuMaterialTextbox2.Text + "',email='" + bunifuMaterialTextbox3.Text + "',address='" + bunifuMaterialTextbox4.Text + "',cintime=CONVERT(TIME, GETDATE()),cindate=CONVERT(date, GETDATE()),coutdate='" + date1 + "',no_pep=" + bunifuMaterialTextbox6.Text + " where room =" + room;
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            //this.Visible = false;
        }
    }
}
