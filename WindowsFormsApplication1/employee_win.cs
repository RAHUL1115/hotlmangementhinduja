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
    public partial class employee_win : UserControl
    {
        public employee_win()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(this);
            SendToBack();
            Visible = false;
        }

        private void employee_win_Load(object sender, EventArgs e)
        {
            EmpName.Clear();
            if (Program.con.State == ConnectionState.Closed) { Program.con.Open(); }
            string query = "select id from login";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                EmpName.AddItem("" + sdr[0]);
                while (sdr.Read())
                {
                    EmpName.AddItem("" + sdr[0]);
                }
            }

            sdr.Close();
            cmd.Dispose();

        }
        string date1 = DateTime.Now.ToString("yyyy-MM-dd");
        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            string query = "insert  into login values('"+idtextbox.Text+"','"+passtextbox.Text+"','o','"+emailtextbox.Text+"','"+fullnametextbox.Text+"','"+addrestextbox.Text+"','"+monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")+"','"+date1+"')";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();

            messageboxcs mb = new messageboxcs();
            mb.bunifuCustomLabel1.Text = "Employee Added";
            mb.Show();
            employee_win_Load(null, null);
        }

        private void RemoveEmpButton_Click(object sender, EventArgs e)
        {
            string query = "delete from login where id ='"+EmpName.selectedValue+"' and post != 'm'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();

            messageboxcs mb = new messageboxcs();
            mb.bunifuCustomLabel1.Text = "Employee Removed";
            mb.Show();
            employee_win_Load(null, null);
        }
    }
}
