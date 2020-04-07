using System;
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
        //hasttable
        private Hashtable controlHashtable;

        //user functions
        private Control GetlabelByName(string name)
        {
            return this.controlHashtable[name] as Label;
        }

        private Control GetbuttonByName(string name)
        {
            return this.controlHashtable[name] as BunifuThinButton2;
        }

        private void resetlabbut(BunifuThinButton2[] roombutton, Label[] roomlabel)
        {
            for (int i = 0; i < 25; i++)
            {
                roombutton[i].IdleLineColor = Color.SeaGreen;
                roombutton[i].IdleForecolor = Color.SeaGreen;
                roomlabel[i].ForeColor = Color.Black;
                roomlabel[i].Text = "";
            }
        }

        private void datevalidation(MonthCalendar d1, MonthCalendar d2)
        {
            if (d1.TodayDate > d1.SelectionRange.Start)
            {
                messageboxcs mb = new messageboxcs();
                mb.bunifuCustomLabel1.Text = "select todays date or above";
                mb.Show();
                refreshbutton.Visible = true;
                return;
            }
            if (d1.SelectionRange.Start > d2.SelectionRange.Start)
            {
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = "end date";
                refreshbutton.Visible = true;
                return;
            }
        }

        //event functions
        public hometab()
        {
            InitializeComponent();

            //creating hash table
            this.controlHashtable = new Hashtable();
            foreach(Control c in this.Controls)
            {
                this.controlHashtable.Add(c.Name, c);
            }
        }



        private void Roomnobutton_Click(object sender, EventArgs e)
        {
            //refresh room button state
            refreshbutton_Click(null, null);

            //cheking
            bool istoday = (hometabcal1.SelectionRange.Start == hometabcal1.TodayDate);
            bool isbuttonred = (((BunifuThinButton2)sender).IdleLineColor == Color.Red); 
            bool isgreen = (((BunifuThinButton2)sender).IdleForecolor == Color.Red);
            bool islabelred = (GetlabelByName("label" + (((BunifuThinButton2)sender).ButtonText)).ForeColor == Color.Red);

            //witch window will appre on button click decider

            //prebooked room chek in
            if (isgreen)
            {
                //get button text
                string room = ((BunifuThinButton2)sender).ButtonText;

                //query
                string query = "Select * from pre_book where room = "+((BunifuThinButton2)sender).ButtonText;
                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    query = "delete from pre_book where room = " + ((BunifuThinButton2)sender).ButtonText +"; ";
                    query += "update current_book set fname='" + sdr[1] + "',lname='" + sdr[2] + "',email='" + sdr[3] + "',address='" + sdr[4] + "',cintime=CONVERT(TIME, GETDATE()),cindate=CONVERT(date, GETDATE()),coutdate='" +sdr[7] + "',no_pep=" + sdr[8] + ",cinstate='prebook',regid=replace(replace(replace(convert(varchar,getdate(),20),' ',''),':',''),'-','') where room = " + ((BunifuThinButton2)sender).ButtonText;
                    SqlCommand cmd1 = new SqlCommand(query, Program.con);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }
                cmd.Dispose();
                sdr.Close();

                //message box show
                messageboxcs mb = new messageboxcs();
                mb.Show();
                mb.bunifuCustomLabel1.Text = "room no "+room+" is bookd";
            }

            //other
            else 
            {
                //get room no
                Program.inf.room = ((BunifuThinButton2)sender).ButtonText;

                //decider
                if (istoday)
                {
                    if (isbuttonred)
                    {
                        filledroomwin rfw = new filledroomwin();
                        rfw.room = Program.inf.room;
                        if (islabelred)
                        {   
                            rfw.servicesbutton.Dispose();
                            rfw.checkoutbutton.Dispose();
                            rfw.namel.Dispose();
                            rfw.namelab.Dispose();
                            rfw.Show();
                        }
                        else
                        {
                            rfw.canclebutton.Dispose();
                            rfw.Show();
                        }
                    }
                    else
                    {
                        current_book1.label5.Text = "Room No : " + Program.inf.room;
                        current_book1.room = ((BunifuThinButton2)sender).ButtonText;
                        current_book1.BringToFront();
                        current_book1.Visible = true;
                        current_book1.monthCalendar1.SelectionRange = hometabcal2.SelectionRange;
                    }
                }
                else
                {
                    if (isbuttonred)
                    {
                        filledroomwin rfw = new filledroomwin();
                        rfw.room = Program.inf.room;
                        if (islabelred)
                        {
                            rfw.servicesbutton.Dispose();
                            rfw.checkoutbutton.Dispose();
                            rfw.namel.Dispose();
                            rfw.namelab.Dispose();
                            rfw.Show();
                        }
                        else
                        {
                            rfw.canclebutton.Dispose();
                            rfw.Show();
                        }
                    }
                    else
                    {
                        pre_book1.label5.Text = "Room No : " + Program.inf.room;
                        pre_book1.room = ((BunifuThinButton2)sender).ButtonText;
                        pre_book1.BringToFront();
                        pre_book1.Visible = true;
                        pre_book1.monthCalendar1.SelectionRange = hometabcal1.SelectionRange;
                        pre_book1.monthCalendar2.SelectionRange = hometabcal2.SelectionRange;
                    }
                }

            }
        }

        public void refreshbutton_Click(object sender, EventArgs e)
        {
            //invisible refresh button
            refreshbutton.Visible = false;

            //date validation
            datevalidation(hometabcal1, hometabcal2);

            //convetrt and store date
            string date1 = hometabcal1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string date2 = hometabcal2.SelectionRange.Start.ToString("yyyy-MM-dd");

            //query create

            //current book
            string statement;
            //normal book
            string statement2;

            //if both dates are same
            if (hometabcal1.SelectionRange.Start == hometabcal2.SelectionRange.Start)
            {
                statement = "select room,CONVERT(varchar, coutdate, 101) as coutdate from current_book where '" + date1 + "' BETWEEN cindate and coutdate ";
                statement2 = "select room,CONVERT(varchar, coutdate, 101) as coutdate from pre_book where '" + date1 + "' BETWEEN cindate and coutdate ORDER BY cintime";
            }
            //not same date
            else
            {
                statement = "select room,CONVERT(varchar, coutdate, 101) as coutdate from current_book where (cindate BETWEEN '" + date1 + "' and '" + date2 + "' ) or (coutdate BETWEEN '" + date1 + "' and '" + date2 + "' )";
                statement2 = "select room,CONVERT(varchar, coutdate, 101) as coutdate from pre_book where (cindate BETWEEN '" + date1 + "' and '" + date2 + "' ) or (coutdate BETWEEN '" + date1 + "' and '" + date2 + "' ) ORDER BY cintime";
            }

            //array create of label and room
            Bunifu.Framework.UI.BunifuThinButton2[] roombutton = { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13, room14, room15, room16, room17, room18, room19, room20, room21, room22, room23, room24, room25 };
            Label[] roomlabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25 };
            
            //reset button and label
            resetlabbut(roombutton, roomlabel);

            //connection check
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlCommand cmd = new SqlCommand(statement, Program.con);
            SqlDataReader sdr = cmd.ExecuteReader();

            //data read current book
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = ""+sdr[1];
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
            cmd.Dispose();
            sdr.Close();

            //data read pre book
            cmd = new SqlCommand(statement2, Program.con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                roombutton[((Int32)sdr[0] - 1)].IdleLineColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].ForeColor = Color.Red;
                roomlabel[((Int32)sdr[0] - 1)].Text = ""+sdr[1];
                roomlabel[((Int32)sdr[0] - 1)].Visible = true;
            }
            cmd.Dispose();
            sdr.Close();

            //shows todays prebooks
            if (hometabcal1.SelectionRange.Start == hometabcal2.SelectionRange.Start && hometabcal1.SelectionRange.Start == hometabcal1.TodayDate && showtodayprebook.Value)
            {
                string qurey5 = "select room from pre_book where cindate = '" + date1 + "'";
                cmd = new SqlCommand(statement2, Program.con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    roombutton[((Int32)sdr[0] - 1)].IdleForecolor = Color.Red;
                }
                cmd.Dispose();
                sdr.Close();
            }

            //refreshbutton visible
            refreshbutton.Visible = true;
        }

        private void showtodayprebook_OnValueChange(object sender, EventArgs e)
        {
            //if yes then reset calander
            if (showtodayprebook.Value)
            {
                hometabcal1.SelectionRange = new SelectionRange(hometabcal1.TodayDate, hometabcal1.TodayDate);
                hometabcal2.SelectionRange = new SelectionRange(hometabcal2.TodayDate, hometabcal2.TodayDate);
            }
        }
    }
}
