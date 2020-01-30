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

using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    public partial class hometab : UserControl
    {
        public hometab()
        {
            InitializeComponent();
            current_book1.Visible = false;
        }

        private void room1_Click(object sender, EventArgs e)
        {
            current_book1.label5.Text = "Room No : "+((BunifuThinButton2)sender).ButtonText;
            current_book1.BringToFront();
            current_book1.Visible = true;
        }

        private void hometab_Load(object sender, EventArgs e)
        {
            
            //UPDATE current_book SET fname = 'ghh' FROM current_book WHERE current_book.room = 2
            //string statement = "";
            //SqlCommand cmd = new SqlCommand(statement,Program.con);

        }

        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string date1 = "'"+hometabcal1.SelectionRange.Start.ToString("yyyy-MM-dd")+ "'";
            string date2 = "'"+hometabcal2.SelectionRange.Start.ToString("yyyy-MM-dd")+"'";
            Bunifu.Framework.UI.BunifuThinButton2[] roombutton = { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13, room14, room15, room16, room17, room18, room19, room20, room21, room22, room23, room24, room25 };
            Label[] roomlabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25 };
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            string statement = "select room,CONVERT(varchar, coutdate, 101) as coutdate from current_book where (cindate BETWEEN "+date1+ " and " + date2 + ") or (coutdate BETWEEN " + date1 + " and " + date2 + ")";
            SqlCommand cmd = new SqlCommand(statement, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = sdr[1].ToString();
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
            string statement2 = "select room,CONVERT(varchar, coutdate, 101) as coutdate from pre_book where (cindate BETWEEN " + date1 + " and " + date2 + ") or (coutdate BETWEEN " + date1 + " and " + date2 + ") ORDER BY cintime";
            cmd.Dispose();
            sdr.Close();
            cmd = new SqlCommand(statement2, Program.con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].ForeColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = sdr[1].ToString();
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
        }
    }
}
