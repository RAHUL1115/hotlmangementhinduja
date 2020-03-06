using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class findwindow : UserControl
    {
        public findwindow()
        {
            InitializeComponent();
        }

        private void findsearchbutton_Click(object sender, EventArgs e)
        {
            string tablename = "";
            switch (tableselect.selectedIndex)
            {
                case 0:
                    tablename = "current_book";
                    break;
                case 1:
                    tablename = "pre_book";
                    break;
                case 2:
                    tablename = "history";
                    break;
                default:
                    tablename = "current_book";
                    break;


            }

            string query = "";
            if (findtextbox.Text != "")
            {
                if (findtextbox.Text.All(char.IsDigit))
                {
                    if (Convert.ToInt32(findtextbox.Text) < 26)
                        query = "select room as Room,regid as Regid  ,concat(fname,' ',lname)as Name,email as Email,cindate as 'Check In Date',coutdate as 'Checkout Date' ,address as Address from " + tablename + " where room = " + findtextbox.Text + " and fname is not null";
                    else
                    {
                        messageboxcs mb = new messageboxcs();
                        //mb.cases = 'e';
                        mb.bunifuCustomLabel1.Text = "Select room no. from 1-25";
                        mb.Show();
                    }

                }
                else
                {
                    query = "select room as Room,regid as Regid  ,concat(fname,' ',lname)as Name,email as Email,cindate as 'CheckIn Date',coutdate as 'Checkout Date' ,address as Address from " + tablename + " where fname like '%" + findtextbox.Text + "%' or lname like '%" + findtextbox.Text + "%'";
                }

                SqlDataAdapter sd = new SqlDataAdapter(query, Program.con);
                DataTable ds = new DataTable();
                sd.Fill(ds);

                findView.DataSource = ds;
            }
        }
    

        private void findwindow_Load(object sender, EventArgs e)
        {

        }

        private void findView_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void findtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findsearchbutton_Click(null, null);
            }
        }
    }
}
