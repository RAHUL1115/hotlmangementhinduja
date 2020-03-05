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
        public mainwindow()
        {
            InitializeComponent();
        }

        private void mainwindow_load(object sender, EventArgs e)
        {
            leftimgbutton.Visible = false;
            user_name.Text = Program.inf.id;
            refresh();
        }

        public void refresh()
        {
            hometab1.refreshbutton_Click(hometab1.refreshbutton, null);
        }

        private void exitbutton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void switchbutton_click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.switchacc();
        }

        private void leftimgbutton_Click(object sender, EventArgs e)
        {
            rightimgbutton.Visible = true;
            leftimgbutton.Visible = false;

            hometab1.BringToFront();
            anitab.ShowSync(hometab1);

            rightimgbutton.BringToFront();
            leftimgbutton.BringToFront();
            findwindow1.Visible = false;
        }

        private void rightimgbutton_Click(object sender, EventArgs e)
        {
            leftimgbutton.Visible = true;
            rightimgbutton.Visible = false;

            findwindow1.BringToFront();
            anitab1.ShowSync(findwindow1);

            rightimgbutton.BringToFront();
            leftimgbutton.BringToFront();
            hometab1.Visible = false;
        }
    }
}
