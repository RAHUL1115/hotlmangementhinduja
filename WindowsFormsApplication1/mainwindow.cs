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
    }
}
