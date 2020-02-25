﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static string constring = "Server=sql.freeasphost.net;Database=feedback_db;uid=feedback;pwd=1234;MultipleActiveResultSets=True";
        public static SqlConnection con = new SqlConnection(constring);
        public static info inf = new info();
        public static Form1 li;
        public static mainwindow ep;
        public static mainmanagerwindow mmw;


        [STAThread]
        public static void onclick()
        {
            ep = new mainwindow();
            ep.ShowDialog();
        }
        public static void onclick1()
        {
            mmw = new mainmanagerwindow();
            mmw.ShowDialog();
        }
        public static void switchacc()
        {
            li = new Form1();
            li.ShowDialog();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            li = new Form1();
            li.ShowDialog();
        }
    }
}
