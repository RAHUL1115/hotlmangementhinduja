using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class info
    {
        public string id;
        public string currentroom;
        public void refreshhome()
        {
            Program.ep.hometab1.refreshbutton_Click(null, null);
        }
    }
}
