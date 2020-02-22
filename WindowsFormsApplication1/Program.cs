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
        public static mainwindow ep = new mainwindow();
        public static mainmanagerwindow mmw = new mainmanagerwindow();
        //public static findwindow fw = new findwindow();


        [STAThread]
        public static void onclick()
        {
            ep.ShowDialog();
        }
        public static void onclick1()
        {
            mmw.ShowDialog();
        }
        public static void switchacc()
        {
            Form1 li = new Form1();
            li.ShowDialog();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
