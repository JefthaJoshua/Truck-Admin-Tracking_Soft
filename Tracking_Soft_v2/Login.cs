using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;
using System.IO;


namespace Tracking_Soft_v2
{

    public partial class Login : Form
    {

        TalkDB_T db = new TalkDB_T();


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            // call the method to validate the username and password that have been input by the user according to the one that is in the database
            System.Data.DataTable dt = db.LoginT(tbUsername.Text, tbPassword.Text);
            //Main_Switch tm = new Main_Switch();
            //tm.Visible = false;
            MainForm.switcher.Visible = false;
            MainForm.officeForm.Visible = false;



            if (dt.Rows.Count == 1)
            {
              
                switch (dt.Rows[0]["Role"] as string)
                {
                    //if the username, password, are in the database is found, them check if the role if it's administrator
                    case "Administrator":
                        {
                      //hide th e current page
                            this.Hide();
                            // collect the id
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //makw the form switcher visible
                            MainForm.switcher.Visible = true;
                            //initiate the form admin
                            Administrater admin = new Administrater();
                            // add the user control into the form switcher
                            MainForm.switcher.Controls.Add(admin);
                            //show the form swithcer
                            MainForm.switcher.Show();
                            break;
                        }

                    case "Trip Manager":
                        {
                            //if the username, password, are in the database is found, them check if the role if it's Trip Manager

                            // hide the current form
                            this.Hide();

                            // get the id of the row that have th data typed
                            String ID = dt.Rows[0]["LoginID"].ToString();

                            //Administrator tm = new Administrator();

                            //make the form tge switcher visible
                            MainForm.switcher.Visible = true;

                            //initiate the form trip mamangeer
                            TripManager admin = new TripManager();

                            // assign the user control trip mamanger into the main swicher
                            MainForm.switcher.Controls.Add(admin);

                            //show the swithcer
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Timesheet Manager":
                        {
                            //if the username, password, are in the database is found, them check if the role if it's timesheet manager

                            //hide the current form
                            this.Hide();

                            //get the id of the row where it find the information that have been typed in
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();

                            //make the main switcher visible
                            MainForm.switcher.Visible = true;

                            //initite the the user control main swithcer
                            TimesheetManager admin = new TimesheetManager();

                            //assign the user control intp the main switcher 
                            MainForm.switcher.Controls.Add(admin);

                            //make the main switcher visible
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Service Manager":
                        {
                            //if the username, password, are in the database is found, them check if the role if it's service manager
                            //hide the current form
                            this.Hide();

                            //get the id of the row where it find the information that have been typed in
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();

                            //make the main switcher visible
                            MainForm.switcher.Visible = true;

                            //initiate user control service manager 
                            ServiceManager admin = new ServiceManager();
                            //assign the user control service mamager to the main switcher
                            MainForm.switcher.Controls.Add(admin);
                            //show main switcher
                            MainForm.switcher.Show();
                            break;
                        }
                    case "Vehicle Info Manager":

                        {
                            //if the username, password, are in the database is found, them check if the role if it's Vehicle info manager
                            //hide the current form
                            this.Hide();
                            //get the id of the row where it find the information that have been typed in
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            //make the main switcher form visible
                            MainForm.switcher.Visible = true;

                            //initiate the  user control vehicle info manager
                            VehicleInfoManager admin = new VehicleInfoManager();
                            //assign the user control into the form main switcher
                            MainForm.switcher.Controls.Add(admin);

                            //show the main switcher
                            MainForm.switcher.Show();
                            break;

                        }
                    case "Office Manager":

                        {
                            //if the username, password, are in the database is found, them check if the role if it's Vehicle info manager
                            //hide the current form

                            this.Hide();
                            //get the id of the row where it find the information that have been typed in
                            String ID = dt.Rows[0]["LoginID"].ToString();
                            //Administrator tm = new Administrator();
                            // make the main switcher form visible
                            MainForm.officeForm.Visible = true;
                            //Administrater admin = new Administrater();
                            
                            MainForm.administrater.Location = new Point(186, 0);

                            // assign the form administrator to the user control
                            MainForm.officeForm.Controls.Add(MainForm.administrater);
                            //show the office form
                            MainForm.officeForm.Show();
                            break;

                        }
                }
            }

            //clear the the text in tbUsernname
            tbUsername.Clear();
            //clear the tect in tbPassword
            tbPassword.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

    

