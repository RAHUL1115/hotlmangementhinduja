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
    public partial class services : UserControl
    {
        public string room;
        public services()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            string time1 = DateTime.Now.ToString("HH:mm");
            if (fooddropdown.selectedIndex != -1 && quantitydropdown.selectedIndex != -1)
            {
                string query1 = "insert into services values((select regid from current_book where room=" + room + "),'" + fooddropdown.selectedValue + "','" + date1 + "','" + time1 + "'," + quantitydropdown.selectedValue + ",'Ongoing');";
                SqlCommand cmd = new SqlCommand(query1, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            if (roomcleancheckBox.Checked)
            {
                string query2 = "insert into services values((select regid from current_book where room=" + room + "),'Room Cleaning','" + date1 + "','" + time1 + "',null,'Ongoing')";
                SqlCommand cmd = new SqlCommand(query2, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }


            string query = "select sname,quantity,time,state from services";
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            serviceview.DataSource = ds;


        }

        private void services_Load(object sender, EventArgs e)
        {
            
            string query = "select sname,quantity,time,state from services";
            
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            
            serviceview.DataSource = ds;
            serviceview.RowHeadersVisible = false;
           
        }

        private void serviceview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void servicecancle_Click(object sender, EventArgs e)
        {
            string[] delelement = new string[3];
            serviceview.SelectedRows.CopyTo(delelement,0);
            foreach (string row in delelement)
            {
                label1.Text += row;
            }
        }
    }
    
}
