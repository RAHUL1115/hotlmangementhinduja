using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class reports_win : UserControl
    {
        public reports_win()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                String query = "select top 1 (select count(regid) from history where state='Checkout' and MONTH(cindate) = " + selectmonth.selectedValue + " )+(select count(regid) from current_book where regid is not null and MONTH(cindate) = " + selectmonth.selectedValue + " ),(select count(regid) from history where state = 'cancle' and MONTH(cindate) = " + selectmonth.selectedValue + "),(select count(regid) from history where state='Checkout' and MONTH(cindate) = " + selectmonth.selectedValue + " ),(select sum(paid) from history where MONTH(cindate) = " + selectmonth.selectedValue + " ) from history";

                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    label1_1.Text = sdr[0].ToString();
                    label1_1.Visible = true;
                    label2_1.Text = sdr[1].ToString();
                    label2_1.Visible = true;
                    label3_1.Text = sdr[2].ToString();
                    label3_1.Visible = true;
                    label5_1.Text = sdr[3].ToString();
                    label5_1.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(this);
            SendToBack();
            Visible = false;
        }
    }
}
