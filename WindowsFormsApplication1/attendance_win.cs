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
    public partial class attendance_win : UserControl
    {
        public attendance_win()
        {
            InitializeComponent();
        }

        

        private void back_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

       
        private void attendance_win_Load(object sender, EventArgs e)
        {
            AddAttendanceName.Clear();
            if (Program.con.State == ConnectionState.Closed) { Program.con.Open(); }
            string query = "select id from login where id not in (select emp_name from attendance where date = convert(varchar, getdate(), 23) and at_state = '"+ attendencesate.selectedValue + "')  ";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                AddAttendanceName.AddItem("" + sdr[0]);
                while (sdr.Read())
                {
                    AddAttendanceName.AddItem("" + sdr[0]);
                }
            }

            sdr.Close();
            cmd.Dispose();

            SearchName.Clear();
            string query2 = "select id from login";
            cmd = new SqlCommand(query2, Program.con);
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                SearchName.AddItem("" + sdr[0]);
                while (sdr.Read())
                {
                    SearchName.AddItem("" + sdr[0]);
                }
            }
            sdr.Close();
            cmd.Dispose();

            
        }

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed) { Program.con.Open(); }
            try
            {
                string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                string time1 = DateTime.Now.ToString("HH:mm");
                string query = "insert  into attendance values('" + AddAttendanceName.selectedValue + "','" + date1 + "','" + time1 + "','P')";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                attendance_win_Load(null, null);

                string query2 = "Select * from attendance where date='"+date1+"'";
                SqlDataAdapter sd = new SqlDataAdapter(query2, Program.con);
                DataTable ds = new DataTable();
                sd.Fill(ds);

                todayattendView.DataSource = ds;
            }
            catch (Exception)
            {
                attendance_win_Load(null, null);
            }
        }

        //int cal=(sdr[1]*5)/sdr[0]
        private void SearchAttendButton_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed) { Program.con.Open(); }
            string query2 = "Select * from attendance where MONTH(date) ="+SearchMonth.selectedValue+" and emp_name='"+SearchName.selectedValue+"'";
            SqlDataAdapter sd = new SqlDataAdapter(query2,Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            historyattendView.DataSource = ds;
            attendance_win_Load(null, null);

        }
    }
}
