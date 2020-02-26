﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Bunifu.Framework.UI;

namespace WindowsFormsApplication1
{
    public partial class hometab : UserControl
    {
        private Hashtable controlHashtable;

        public hometab()
        {
            InitializeComponent();
            this.controlHashtable = new Hashtable();
            foreach(Control c in this.Controls)
            {
                this.controlHashtable.Add(c.Name, c);
            }
        }
        private void resetlabbut(BunifuThinButton2[] roombutton, Label[] roomlabel)
        {
            for (int i = 0; i < 25; i++)
            {
                roombutton[i].IdleLineColor = Color.SeaGreen;
                roomlabel[i].Text = "";
            }
        }

        private Control GetlabelByName(string name)
        {
            return this.controlHashtable[name] as Label;
        }

        private Control GetbuttonByName(string name)
        {
            return this.controlHashtable[name] as BunifuThinButton2;
        }

        private void Roomnobutton_Click(object sender, EventArgs e)
        {
            Refresh();
            if (hometabcal1.SelectionRange.Start == DateTime.Today)
            {
                if (((BunifuThinButton2)sender).IdleLineColor != Color.Red)
                {
                    current_book1.label5.Text = "Room No : " + ((BunifuThinButton2)sender).ButtonText;
                    current_book1.room = ((BunifuThinButton2)sender).ButtonText;
                    current_book1.BringToFront();
                    current_book1.Visible = true;
                    current_book1.monthCalendar1.SelectionRange = hometabcal2.SelectionRange;
                }
                else
                {
                    roomfilmenuewindow rfw = new roomfilmenuewindow();
                    rfw.room = "update current_book set fname = null,lname= null ,email= null ,address= null,cintime= null,cindate= null ,coutdate= null,no_pep= null where room =" + ((BunifuThinButton2)sender).ButtonText;
                    rfw.Show();
                }
            }
            else
            {
                if (((BunifuThinButton2)sender).IdleLineColor != Color.Red)
                {
                    pre_book1.label5.Text = "Room No : " + ((BunifuThinButton2)sender).ButtonText;
                    pre_book1.room = ((BunifuThinButton2)sender).ButtonText;
                    pre_book1.BringToFront();
                    pre_book1.Visible = true;
                    pre_book1.monthCalendar1.SelectionRange = hometabcal1.SelectionRange;
                    pre_book1.monthCalendar2.SelectionRange = hometabcal2.SelectionRange;
                }
                else
                {

                }
            }
        }
        public void refreshbutton_Click(object sender, EventArgs e)
        {
            refreshbutton.Visible = false;
            if (hometabcal1.TodayDate > hometabcal1.SelectionRange.Start)
            {
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = "select todays date or above";
                return;
            }
            if (hometabcal1.SelectionRange.Start > hometabcal2.SelectionRange.Start)
            {
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = "end date";
                return;
            }
            string date1 = hometabcal1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string date2 = hometabcal2.SelectionRange.Start.ToString("yyyy-MM-dd");
            string statement = "select room,CONVERT(varchar, coutdate, 101) as coutdate from current_book where (cindate BETWEEN '" + date1 + "' and '" + date2 + "' ) or (coutdate BETWEEN '" + date1 + "' and '" + date2 + "' )";
            string statement2 = "select room,CONVERT(varchar, coutdate, 101) as coutdate from pre_book where (cindate BETWEEN '" + date1 + "' and '" + date2 + "' ) or (coutdate BETWEEN '" + date1 + "' and '" + date2 + "' ) ORDER BY cintime";
            if (hometabcal1.SelectionRange.Start == hometabcal2.SelectionRange.Start)
            {
                statement = "select room,CONVERT(varchar, coutdate, 101) as coutdate from current_book where '" + date1 + "' BETWEEN cindate and coutdate ";
                statement2 = "select room,CONVERT(varchar, coutdate, 101) as coutdate from pre_book where '" + date1 + "' BETWEEN cindate and coutdate ORDER BY cintime";
            }
            Bunifu.Framework.UI.BunifuThinButton2[] roombutton = { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13, room14, room15, room16, room17, room18, room19, room20, room21, room22, room23, room24, room25 };
            Label[] roomlabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25 };
            resetlabbut(roombutton, roomlabel);
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(statement, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = sdr[1].ToString();
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
            cmd.Dispose();
            sdr.Close();
            cmd = new SqlCommand(statement2, Program.con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].ForeColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = sdr[1].ToString();
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
            cmd.Dispose();
            sdr.Close();
            refreshbutton.Visible = true;
        }

        private void findsearchbutton_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuThinButton2[] roombutton = { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13, room14, room15, room16, room17, room18, room19, room20, room21, room22, room23, room24, room25 };
            Label[] roomlabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25 };
            resetlabbut(roombutton, roomlabel);
            String query = "";
            if (findtextbox.Text.All(char.IsDigit))
            {
                if (Convert.ToInt32(findtextbox.Text) < 26)
                    query = "select room, fname, lname from current_book where room = " + findtextbox.Text + " and fname is not null";
                else
                {
                    messageboxcs mb = new messageboxcs();
                    mb.Show();
                }
                    
            }
            else
            {
                query = "select room, fname, lname from current_book where fname like '%" + findtextbox.Text + "%' or lname like '%" + findtextbox.Text + "%'";
            }
            if (!(query == ""))
            {
                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    while (sdr.Read())
                    {
                        GetlabelByName("label" + sdr[0]).Visible = true;
                        GetlabelByName("label" + sdr[0]).Text = "" + sdr[1] + " " + sdr[2];
                    }
                }
                else
                {
                    messageboxcs mb = new messageboxcs();
                    mb.Show();
                }
                sdr.Close();

            }
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
