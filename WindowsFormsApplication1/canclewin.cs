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
    public partial class canclewin : UserControl
    {
        public string regid;
        public canclewin()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }
        public void canclewin_Load(object sender, EventArgs e)
        {
            string query = "select  regid, fname, lname,cindate,coutdate from pre_book where room = " + Program.inf.room;
            string query1 = "select * from pre_book";
            query = query1;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            canclelist.DataSource = ds;
            canclelist.ClearSelection();
        }

        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query3 = "";
            if (regid != "")
            {
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                string query1 = "select *,CONVERT(varchar,cindate,23) from pre_book";
                SqlCommand cmd1 = new SqlCommand(query1, Program.con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                if (sdr1.Read())
                {
                    string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                    string time1 = DateTime.Now.ToString("HH:mm");
                    query3 = "insert into history values(" + sdr1[0] + ",'" + sdr1[1] + "', '" + sdr1[2] + "', '" + sdr1[3] + "', '" + sdr1[4] + "', '" + sdr1[5] + "', '" + sdr1[10] + "','" + time1 + "' , '" + date1 + "', " + sdr1[8] + "," + 0 + ",'cancle','prebook','" + sdr1[9] + "')";
                }
                cmd1.Dispose();
                sdr1.Close();
                string query = "delete from pre_book where regid = '" + regid + "' and room = " + Program.inf.room + "; " + query3;
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                canclewin_Load(null, null);
                canclelist.ClearSelection();
            }
        }

        private void canclelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            regid = ""+canclelist.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}

