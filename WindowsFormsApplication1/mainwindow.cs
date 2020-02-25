using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    public partial class mainwindow : Form
    {
        public void refresh()
        {
            hometab2.refreshbutton_Click(hometab2.refreshbutton, null);
        }
        public mainwindow()
        {
            InitializeComponent();
        }

        private void emphome_Load(object sender, EventArgs e)
        {
            hometab2.BringToFront();
            label3.Text = Program.inf.id;
            refresh();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.switchacc();
        }

        private void hometab2_Load(object sender, EventArgs e)
        {

        }

        private void find2_Load(object sender, EventArgs e)
        {

        }
    }
}
