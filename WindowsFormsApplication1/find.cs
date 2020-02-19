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
            listBox1.Items.Clear();
            bunifuThinButton21.Visible = false;
            if (radioButton1.Checked)
            {
                String query = "select * from current_book where fname like '%" + bunifuMaterialTextbox1.Text + "%' or lname like '%" + bunifuMaterialTextbox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add("Room no : "+sdr[0]+" Name : "+ sdr[2] + " " + sdr[3]);
                }
                sdr.Close();

            }
            else
            {
                if(!bunifuMaterialTextbox1.Text.All(char.IsDigit))
                {
                    messageboxcs mb = new messageboxcs();
                    mb.Show();
                    mb.bunifuCustomLabel1.Text = "enter valid room no";
                    bunifuThinButton21.Visible = true;
                    return;
                }
                String query = "select * from current_book where room = " + bunifuMaterialTextbox1.Text +" and fname is not null";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add("Room no : " + sdr[0] + " Name : " + sdr[2] + " " + sdr[3]);
                }
                sdr.Close();
            }
            bunifuThinButton21.Visible = true;
        }
    }
}
