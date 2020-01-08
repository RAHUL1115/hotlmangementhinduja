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
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        private void emphome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = homebutton.Location;
            hometab1.BringToFront();
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = findbutton.Location;
            find1.BringToFront();
        }

        private void currentbookingbutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = currentbookingbutton.Location;
        }

        private void prebookingbutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = prebookingbutton.Location;
        }

        private void canclebutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = canclebutton.Location;
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            selectedtabpannel.Location = checkoutbutton.Location;
        }
    }
}
