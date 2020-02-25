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
    public partial class mainmanagerwindow : Form
    {
        public mainmanagerwindow()
        {
            InitializeComponent();
        }

        private void mainmanagerwindow_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.switchacc();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
