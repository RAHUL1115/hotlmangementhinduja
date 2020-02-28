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
        public string room;
        public canclewin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string name = "" + listBox1.SelectedItem;
            if (name != "")
            {
                string[] names = name.Split(' ');
                string query = "delete from pre_book where fname = '" + names[0] + "'and lname = '" + names[1] + "' and room =" + room;
                if (Program.con.State == ConnectionState.Closed)
                    Program.con.Open();
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                canclewin_Load(null, null);
            }
        }

        public void canclewin_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string query = "select fname,lname from pre_book where room = " + room;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listBox1.Items.Add(sdr[0] + " " + sdr[1]);
            }
            cmd.Dispose();
            sdr.Close();
        }
    }
}
