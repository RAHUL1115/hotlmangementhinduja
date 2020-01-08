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
    public partial class find : UserControl
    {
        public find()
        {
            InitializeComponent();
        }
        private void find_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "by name";
            }
            else
            {
                label1.Text = "by room";
            }
        }
    }
}
