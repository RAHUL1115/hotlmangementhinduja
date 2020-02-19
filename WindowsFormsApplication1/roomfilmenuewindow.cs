using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class roomfilmenuewindow : Form
    {
        public string room;
        public roomfilmenuewindow()
        {
            InitializeComponent();
        }

        private void roomfilmenuewindow_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
            {
                Program.con.Open();
            }
            string query = room;
            SqlCommand cmd = new SqlCommand(query, Program.con);
            cmd.ExecuteNonQuery();
            Dispose();
            Program.ep.refresh();
        }
    }
}
