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
        public static string constring = "Server=sql.freeasphost.net;Database=feedback_db;uid=feedback;pwd=1234;MultipleActiveResultSets=True";
        public static string constring1 = "Data Source=4NONYM0U5;Initial Catalog=hotel;Integrated Security=True;MultipleActiveResultSets=True";
        public static string constring2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\4N0NYM0U5\\Documents\\GitHub\\hotlmangementhinduja\\WindowsFormsApplication1\\localdtatabase\\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        public static string constring3 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Yash\\project\\hotlmangementhinduja\\WindowsFormsApplication1\\localdatabase\\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        public static SqlConnection con = new SqlConnection(constring3);
        public static info inf = new info();
        public static loginwindow li;
        public static mainwindow ep;
        public static mainmanagerwindow mmw;


        [STAThread]

        public static void onclick()
        {
            ep = new mainwindow();
            ep.ShowDialog();
        }
        [STAThread]
        public static void onclick1()
        {
            mmw = new mainmanagerwindow();
            mmw.ShowDialog();
        }
        [STAThread]
        public static void switchacc()
        {
            li = new loginwindow();
            li.ShowDialog();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            li = new loginwindow();
            li.ShowDialog();
        }
    }
}
