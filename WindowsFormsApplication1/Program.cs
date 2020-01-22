using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Yash\\project\\hotlmangementhinduja\\WindowsFormsApplication1\\Database1.mdf;Integrated Security=True";
        public static string constring1 = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(constring);


        [STAThread]
        public static void onclick()
        {
            mainwindow ep = new mainwindow();
            ep.ShowDialog();
        }
        public static void switchacc()
        {
            Form1 li = new Form1();
            li.ShowDialog();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
