using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1.FormUI;

namespace UI_UX_Dashboard_P1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string user = "test";
           // string user1 = "Admin";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new fmLogin());

           /// Application.Run(new fmMain(user,user1));
        }
    }
}
