using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

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
            Application.Exit();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Reports";
            toolTip1.Show(" ", bunifuImageButton3);
        }



        private void bunifuImageButton4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Attendance";
            toolTip1.Show(" ", bunifuImageButton4);
        }

        private void bunifuImageButton5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Salary";
            toolTip1.Show(" ", bunifuImageButton5);
     
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            reports_win1.BringToFront();
            reports_win1.Visible = true;
        }

        public void back()
        {
            reports_win1.SendToBack();
            reports_win1.Visible = false;
        }
    }
}
