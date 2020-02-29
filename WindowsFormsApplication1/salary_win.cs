using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class salary_win : UserControl
    {
        public salary_win()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SendToBack();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void post_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
