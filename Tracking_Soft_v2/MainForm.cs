using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Soft_v2
{
    static class MainForm
    {
        //--> Main Window
        static public Main_Switch switcher = new Main_Switch();
        static public OfficeManForm officeForm = new OfficeManForm();

        //--> Splash_scrn
        static public Splash_scrn splash = new Splash_scrn();

        //--> Login
        static public Login login = new Login();

        //--> UserControls (Managers Screens)
        static public TripManager tripManager = new TripManager();
        static public TimesheetManager timeMan = new TimesheetManager();
        static public VehicleInfoManager VehicleInfoManager = new VehicleInfoManager();

        static public ServiceManager ServiceManager = new ServiceManager();
        static public Administrater administrater = new Administrater();



    }
}
