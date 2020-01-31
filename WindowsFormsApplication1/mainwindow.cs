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
            hometab2.BringToFront();
            label3.Text = Program.inf.id;
            //hometab2.bunifuThinButton21_Click(hometab2.bunifuThinButton21, null);
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
                    if (selectedtabpannel.Location.Y < ((BunifuFlatButton)sender).Location.Y)
                    {
                        selectedtabpannel.Location = ((BunifuFlatButton)sender).Location;
                        break;
                    }
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
                    if (selectedtabpannel.Location.Y > ((BunifuFlatButton)sender).Location.Y)
                    {
                        selectedtabpannel.Location = ((BunifuFlatButton)sender).Location;
                        break;
                    }
                }
                watch.Stop();
                label2.Text = watch.ElapsedMilliseconds + "ms";
            }
            selectedtabpannel.Location = ((BunifuFlatButton)sender).Location;
          
            
            switch (s)
            {
                case "homebutton":
                    hometab2.BringToFront();
                    break;
                case "findbutton":
                    find2.BringToFront();
                    break;
                case "Servicesbutton":
                    break;
                case "cancleservice":
                    break;
                case "canclebutton":
                    break;
                case "checkoutbutton":
                    checkout1.BringToFront();
                    break;
                default:
                    break;
            }
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.switchacc();
        }

        private void hometab2_Load(object sender, EventArgs e)
        {

        }

        private void find2_Load(object sender, EventArgs e)
        {

        }
    }
}
