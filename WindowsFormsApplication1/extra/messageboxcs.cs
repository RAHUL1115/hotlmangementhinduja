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
    public partial class messageboxcs : Form
    {
        public char cases = ' ';
        public messageboxcs()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Dispose();
            switch (cases)
            {
                case 'h':
                    Program.inf.refreshhome();
                    break;
                default:
                    break;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Dispose();
            switch (cases)
            {
                case 'h':
                    Program.inf.refreshhome();
                    break;
                default:
                    break;
            }
        }

        private void messageboxcs_Deactivate(object sender, EventArgs e)
        {
            Dispose();
            switch (cases)
            {
                case 'h':
                    Program.inf.refreshhome();
                    break;
                default:
                    break;
            }
        }

        private void messageboxcs_Load(object sender, EventArgs e)
        {
           
        }
    }
}
