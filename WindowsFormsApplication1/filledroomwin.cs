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
    public partial class filledroomwin : Form
    {
        public string room;
        public filledroomwin()
        {
            InitializeComponent();
        }

        private void servicebut_Click(object sender, EventArgs e)
        {
            services1.BringToFront();
            services1.Visible = true;
        }

        private void canbut_Click(object sender, EventArgs e)
        {
            canclewin1.BringToFront();
            canclewin1.Visible = true;
        }

        private void coutbut_Click(object sender, EventArgs e)
        {
            checkout1.BringToFront();
            checkout1.Visible = true;
        }

        private void filledroomwin_Load(object sender, EventArgs e)
        {
            room = Program.inf.room;
            roomlab.Text = room;
            SqlCommand cmd = new SqlCommand("select concat(fname,' ',lname) from current_book where room = " + room, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                namel.Text = ""+sdr[0];
            }

        }

        private void filledroomwin_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
