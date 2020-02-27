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

        private void switchacc_click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.switchacc();
        }

        private void close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            string name = ((Bunifu.Framework.UI.BunifuImageButton)sender).Name;
            switch (name)
            {
                case "reports":
                    reports_win1.BringToFront();
                    reports_win1.Visible = true;
                    break;
                case "attendence":
                    attendance_win1.BringToFront();
                    attendance_win1.Visible = true;
                    break;
                case "salary":
                    salary_win1.BringToFront();
                    salary_win1.Visible = true;
                    break;
                case "employees":
                    employee_win1.BringToFront();
                    employee_win1.Visible = true;
                    break;
                case "something":
                    break;
                default:
                    break;
            }
        }

    }
}
