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
    public partial class current_book : UserControl
    {
        public current_book()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Program.con.State == ConnectionState.Closed)
            {
                Program.con.Open();
                String query = "insert into curr_book values('" + name.Text + "','" + Convert.ToInt32(contact.Text) + "','" + address.Text + "','" + room_type.selectedValue + "','" + Convert.ToInt32(num_of_pep.Text) + "','" + Convert.ToInt32(room_no.Text) + "')";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
            }
            else
            { Program.con.Close(); }
        }
    }
}
