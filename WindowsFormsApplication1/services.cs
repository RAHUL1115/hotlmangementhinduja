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
        public string oid = "";

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
            addbutton.Visible = false;
            string date1 = DateTime.Now.ToString("yyyy-MM-dd");
            string time1 = DateTime.Now.ToString("HH:mm");
            int ammount=0;
           
                if (fooddropdown.selectedIndex != -1 && quantitydropdown.selectedIndex != -1)
                {
                    if (fooddropdown.selectedIndex == 0)
                    {
                        ammount = 200 * Convert.ToInt32(quantitydropdown.selectedValue);
                    }
                    if (fooddropdown.selectedIndex == 1)
                    {
                        ammount = 400 * Convert.ToInt32(quantitydropdown.selectedValue);
                    }
                    if (fooddropdown.selectedIndex == 2)
                    {
                        ammount = 600 * Convert.ToInt32(quantitydropdown.selectedValue);
                    }
                    string query1 = "insert into services values((select regid from current_book where room=" + room + "),'" + fooddropdown.selectedValue + "','" + date1 + "','" + time1 + "'," + quantitydropdown.selectedValue + ",'Ongoing', " + ammount + ",concat((select regid  from current_book where room=" + room + "),replace(convert(varchar, getdate(), 8),':',''),'"+fooddropdown.selectedIndex+"'),"+room+");";

                    SqlCommand cmd = new SqlCommand(query1, Program.con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                if (roomcleancheckBox.Checked)
                {
                    string query2 = "insert into services values((select regid from current_book where room=" + room + "),'Room Cleaning','" + date1 + "','" + time1 + "',null,'Ongoing',0,concat((select regid  from current_book where room=" + room + "),replace(convert(varchar, getdate(), 8),':',''),'" + fooddropdown.selectedIndex + "'),"+room+")";
                    SqlCommand cmd = new SqlCommand(query2, Program.con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            
            datarefresh();
            addbutton.Visible = true;
        }

        private void services_Load(object sender, EventArgs e)
        {
            room = Program.inf.room;
            string query = "select oid as 'Order id',sname as Service,quantity as Quantity,time as Time,state as State from services where room = "+room;
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            serviceview.DataSource = ds;
            serviceview.ClearSelection();     
            DataGridViewLinkColumn btn = new DataGridViewLinkColumn();
            btn.HeaderText = "Cancle";
            btn.Name = "cbutton";
            btn.Text = "Cancle";
            btn.UseColumnTextForLinkValue = true;
            serviceview.Columns.Add(btn);
            serviceview.ClearSelection();
        }

        private void serviceview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            oid = ""+serviceview.Rows[e.RowIndex].Cells[1].Value;
          
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string query = "delete from services where oid = '" + oid + "'";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                oid = "";
                datarefresh();
                Console.WriteLine(query);
            }

        }

        public void datarefresh()
        {
            room = Program.inf.room;
            string query = "select oid,sname,quantity,time,state from services where room = "+room;
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            serviceview.DataSource = ds;
            serviceview.ClearSelection();
        }
    }
    
}
