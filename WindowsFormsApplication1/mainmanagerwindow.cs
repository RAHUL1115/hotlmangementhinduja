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

        

        private void reports_Click(object sender, EventArgs e)
        {
           

            reports_win1.BringToFront();
            bunifuTransition1.ShowSync(reports_win1,false);
            reports_win1.Visible = true;

        }


        private void attendence_Click(object sender, EventArgs e)
        {
            attendance_win1.BringToFront();
            attendance_win1.Visible = true;
        }

        private void salary_Click(object sender, EventArgs e)
        {
            salary_win1.BringToFront();
            salary_win1.Visible = true;
        }

        private void employees_Click(object sender, EventArgs e)
        {
            employee_win1.BringToFront();
            employee_win1.Visible = true;
        }

        private void empperformance_Click(object sender, EventArgs e)
        {
            emp_performance_win1.BringToFront();
            emp_performance_win1.Visible = true;
        }
    }
    
}
