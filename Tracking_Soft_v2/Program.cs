using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Soft_v2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(MainForm.splash);
            Application.Run(new Splash_scrn());
            //Application.Run(new Add_User());
            //Application.Run(new Administrator());
        }
    }
}
