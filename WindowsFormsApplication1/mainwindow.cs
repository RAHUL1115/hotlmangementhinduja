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

        private void tabbuttonclick(object sender, EventArgs e)
        {
            string s = ((BunifuFlatButton)sender).Name;
            if (selectedtabpannel.Location.Y > ((BunifuFlatButton)sender).Location.Y)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                while (selectedtabpannel.Location.Y != ((BunifuFlatButton)sender).Location.Y)
                {
                    selectedtabpannel.Location = new Point(0,selectedtabpannel.Location.Y - 4);
                }
                watch.Stop();
                label2.Text = watch.ElapsedMilliseconds+"ms";
            }
            else if (selectedtabpannel.Location.Y < ((BunifuFlatButton)sender).Location.Y)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                while (selectedtabpannel.Location.Y != ((BunifuFlatButton)sender).Location.Y)
                {
                    selectedtabpannel.Location = new Point(0, selectedtabpannel.Location.Y + 4);
                }
                watch.Stop();
                label2.Text = watch.ElapsedMilliseconds + "ms";
            }
            selectedtabpannel.Location = ((BunifuFlatButton)sender).Location;
            switch (s)
            {
                case "homebutton":
                    hometab1.BringToFront();
                    break;
                case "findbutton":
                    find1.BringToFront();
                    break;
                case "currentbookingbutton":
                    break;
                case "prebookingbutton":
                    break;
                case "canclebutton":
                    break;
                case "checkoutbutton":
                    break;
                default:
                    break;
            }
        }

    }
}
