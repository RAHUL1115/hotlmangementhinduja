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
            bunifuTransition1.HideSync(this);
            SendToBack();
            Visible = false;
        }

       

        private void post_onItemSelected(object sender, EventArgs e)
        {

        }

       String month = DateTime.Now.Month.ToString();
       

        private void salary_win_Load(object sender, EventArgs e)
        {
            monthDropdown1.selectedIndex = Convert.ToInt32(month) - 1;
            selecthistorymonthDropdown1.selectedIndex = Convert.ToInt32(month) - 1;

            empname.Clear();
            string query = "select id from login where post != 'm' and month(doj) <= " + monthDropdown1.selectedValue + " and id not in (select emp_id from salary where formonth= " + monthDropdown1.selectedValue + " )";
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

            string query2 = "Select emp_id as 'Employee Id',date as Date,sget as Salary,formonth as Month from salary where Month(date)='" + selecthistorymonthDropdown1.selectedValue + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query2, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            salaryhistoryView.DataSource = ds;
            salaryhistoryView.ClearSelection();

        }

        private void PayButton_Click(object sender, EventArgs e)
        {

            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            string time1 = DateTime.Now.ToString("HH:mm");
            string query = "insert  into salary values('" + empname.selectedValue + "','"+date1+ "','"+bonustextbox.Text+"','"+(Convert.ToInt32(salarytextbox.Text)+ Convert.ToInt32(bonustextbox.Text) )+ "',"+monthDropdown1.selectedValue+")";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
           salary_win_Load(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SearchAttendButton_Click(object sender, EventArgs e)
        {
            string query2 = "Select emp_id as 'Employee Id',date as Date,sget as Salary,formonth as Month from salary where formonth='" + selecthistorymonthDropdown1.selectedValue + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query2, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            salaryhistoryView.DataSource = ds;
            salaryhistoryView.ClearSelection();
        }

        private void monthDropdown1_onItemSelected(object sender, EventArgs e)
        {
            empname.Clear();
            string query = "select id from login where post != 'm' and month(doj) <= " + monthDropdown1.selectedValue + " and id not in (select emp_id from salary where formonth= " + monthDropdown1.selectedValue + " )";
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
        }
    }
}
