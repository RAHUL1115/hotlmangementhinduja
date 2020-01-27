using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    public partial class hometab : UserControl
    {
        public hometab()
        {
            InitializeComponent();
            current_book1.Visible = false;
        }

        private void room1_Click(object sender, EventArgs e)
        {
            current_book1.label5.Text = "Room No : "+((BunifuThinButton2)sender).ButtonText;
            current_book1.BringToFront();
            current_book1.Visible = true;
        }
    }
}
