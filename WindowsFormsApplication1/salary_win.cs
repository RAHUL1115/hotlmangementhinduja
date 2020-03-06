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
    public partial class salary_win : UserControl
    {
        public salary_win()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

       

        private void post_onItemSelected(object sender, EventArgs e)
        {

        }

        private void salary_win_Load(object sender, EventArgs e)
        {
            empname.Clear();
            string query = "select id from login where id not in (select emp_id from salary where date = convert(varchar, getdate(), 23) )";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                empname.AddItem("" + sdr[0]);
                while (sdr.Read())
                {
                    empname.AddItem("" + sdr[0]);
                }
            }
            DateTime dt = DateTime.Now;
            String date = dt.Month.ToString();

            monthDropdown1.selectedIndex = Convert.ToInt32(date) - 1;
            selecthistorymonthDropdown1.selectedIndex = Convert.ToInt32(date) - 1;

            string query2 = "Select * from salary where Month(date)='" + selecthistorymonthDropdown1.selectedValue + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query2, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            salaryhistoryView.DataSource = ds;

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            string time1 = DateTime.Now.ToString("HH:mm");
            string query = "insert  into salary values('" + empname.selectedValue + "','"+date1+ "','"+bonustextbox+"','"+salarytextbox+"','','P')";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
           salary_win_Load(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SearchAttendButton_Click(object sender, EventArgs e)
        {
            string query2 = "Select * from salary where Month(date)='" + selecthistorymonthDropdown1.selectedValue + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query2, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            salaryhistoryView.DataSource = ds;
        }
    }
}
