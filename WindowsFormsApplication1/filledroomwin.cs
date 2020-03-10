using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void canbut_Click(object sender, EventArgs e)
        {
            canclewin1.BringToFront();
            canclewin1.Visible = true;
        }

        private void coutbut_Click(object sender, EventArgs e)
        {

        }

        private void filledroomwin_Load(object sender, EventArgs e)
        {
            room = Program.inf.room;
            roomlab.Text = room;
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
