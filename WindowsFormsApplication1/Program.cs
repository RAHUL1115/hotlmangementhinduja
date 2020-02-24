using System;
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
        public static string constring = "Server=sql.freeasphost.net;Database=feedback_db;uid=feedback;pwd=1234";
        public static SqlConnection con = new SqlConnection(constring);
        public static info inf = new info();
        public static Form1 li = new Form1();
        public static mainwindow ep = new mainwindow();
        public static mainmanagerwindow mmw = new mainmanagerwindow();


        [STAThread]
        public static void onclick()
        {
            mainwindow ep1 = new mainwindow();
            ep1.ShowDialog();
        }
        public static void onclick1()
        {
            mainmanagerwindow mmw1 = new mainmanagerwindow();
            mmw1.ShowDialog();
        }
        public static void switchacc()
        {
            Form1 li1 = new Form1();
            li1.ShowDialog();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            li.ShowDialog();
        }
    }
}
