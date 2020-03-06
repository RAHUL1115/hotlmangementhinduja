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
    public partial class emp_performance_win : UserControl
    {
        public emp_performance_win()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        private void show_feedback_Click(object sender, EventArgs e)
        {
            string query = "select regid as 'Registration id', name as Name, feedback_text as Feedback, star as Rating, empid as 'Employee Id',estar as 'Employees RSating' from f_table";
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            feedbackview.DataSource = ds;
        }

        private void emp_perform_Click(object sender, EventArgs e)
        {
            string masterquery = "select id from login where post != 'm'";
            SqlCommand cmd = new SqlCommand(masterquery, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable ds = new DataTable();
            while (sdr.Read())
            {
                string query = "select (select id  from login where id = '"+sdr[0]+ "')as 'Employee name', ((((select count(emp_name) from attendance where emp_name = '" + sdr[0]+"' and at_state = 'P')*5)/ (select count(emp_name) from attendance where emp_name = '"+sdr[0]+"'))+ (select avg(estar)from f_table where empid = '"+sdr[0]+"')) as ratings";
                SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
                sd.Fill(ds);
            }
            feedbackview.DataSource = ds;

        }

        private void feedbackview_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
