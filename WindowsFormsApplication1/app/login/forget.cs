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
    public partial class forget : UserControl
    {
        public forget()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        private void getpass_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            String query = "select pass from login where id='" + logintxt.Text + "' and email = '"+emailtext.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = ""+sdr[0];
            }
            else 
            {
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = "invaliid details";
            }
        }
    }
}
