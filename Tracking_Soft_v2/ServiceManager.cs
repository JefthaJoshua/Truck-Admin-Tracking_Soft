using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tracking_Soft_v2
{
    public partial class ServiceManager : UserControl
    {
        TalkDB_T db = new TalkDB_T();
        public String ServiceId = "";
        public ServiceManager()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           // if you press the add button and one of those component is still empty then
            if ((cbServiceType.Text == "") || (dtDate.Text == "") || (cbVehicleId.Text == "") || (cbMechanicId.Text == "") || (rtDescription.Text == ""))
            {

                // display his message
                MessageBox.Show("Please make sure that all the fields are not empty");
            }
            else
            {
                //call the method to insert new data in the database
                insertService();
                //update the data in the datagrid
                CollectData();

            }

        }

        public void insertService()
        {

            try
            {
                //popn the connection to the database
                TalkDB_T.con.Open();

               // build the sql statement to insert new values in the database
                String sqlInsert = "insert into Service (VehicleId,Date,MechanicId,serviceType, ServiceDescription) " +
                    "Values" +
                    "(@vehicleId,@Date,@MechanicId,@serviceType,@ServiceDescription)";

                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);
                //collect all the values from the text boxs
                commad.Parameters.AddWithValue("@vehicleId", cbVehicleId.Text);

                commad.Parameters.AddWithValue("@Date", dtDate.Text);
                commad.Parameters.AddWithValue("@MechanicId", cbMechanicId.Text);

                commad.Parameters.AddWithValue("@serviceType", cbServiceType.Text);
                commad.Parameters.AddWithValue("@serviceDescription", rtDescription.Text);

                //execute the sql statement 
                commad.ExecuteNonQuery();

                //display the message to confirm that the data has been inseert into the database
                MessageBox.Show("Service have been added successfully");


            }

            catch (Exception ex)
            {

                // display message in case the is an problem that the database is facing regarding insertion of data
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (TalkDB_T.con != null)
                {

                    //close the connection with the database
                    TalkDB_T.con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // if you press the update button and one of those component is still empty then
            if ((cbVehicleId.Text == "") || (cbServiceType.Text == "") || (cbMechanicId.Text == "") || (rtDescription.Text == ""))
            {
                //display this message
                MessageBox.Show("Make sure that correct information where in put");
            }
            else
            {
                // call the method to update the service
                updateService();

                //update the data from the database to the datagrid
                CollectData();
            }

        }
        public void updateService()
        {

            try
            {

                using (SqlCommand command = TalkDB_T.con.CreateCommand())
                {
                    // build the sql statement  to update data
                    string sqlUpdate = "UPDATE Service SET VehicleId=@VehicleId,Date=@Date,MechanicId=@MechanicId, Where serviceId =" + ServiceId + "";

                    SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                    //getting all the new values from the text box 
                    commad.Parameters.AddWithValue("@VehicleId", cbVehicleId.Text);

                    commad.Parameters.AddWithValue("@Date", dtDate.Text);
                    commad.Parameters.AddWithValue("@MechanicId", cbMechanicId.Text);

                    commad.Parameters.AddWithValue("@serviceType", cbServiceType.Text);
                    commad.Parameters.AddWithValue("@serviceDescription", rtDescription.Text);

                    // execute the sql statement to update
                    commad.ExecuteNonQuery();


                    //open the connection with the database
                    TalkDB_T.con.Open();

                    command.ExecuteNonQuery();
                    //close close the connection with the database 
                    TalkDB_T.con.Close();


                }

            }


            catch (Exception ex)
            {
                // display message in case the is an problem that the database is facing regarding insertion of data
                MessageBox.Show(ex.Message);
            }

        }

        public void displayMechanicId()
        {
            // open connecion with the database
            TalkDB_T.con.Open();
            // build the sql statement to get all loginid in the table LoginT where the role is Mechanic
            string getMechanicId = "SELECT LoginId FROM LoginT WHERE Role = 'Mechanic'";

            SqlCommand cmd = new SqlCommand(getMechanicId, TalkDB_T.con);
            SqlDataReader myReader;
            //execute the sql statement
            myReader = cmd.ExecuteReader();

            try
            {
             
                while (myReader.Read())
                {
                    //get vales from the data reader
                    int MechanicId = myReader.GetInt32(0); // index number
                    //assign it to the items of the combo box 
                    cbMechanicId.Items.Add(MechanicId.ToString());
                }
            }
            catch (Exception ex)
            {
                // display message in case the is an problem that the database 
                MessageBox.Show(ex.Message);
            }
            //close the connection with the database
            TalkDB_T.con.Close();
        }

        public void displayVehicleId()
        {
            // open the connection with the database
            TalkDB_T.con.Open();
            //build the sql statement to select all the vehicleId form the table vehicle
            string getMechanicId = "SELECT VehicleID FROM VehicleInfo";

            SqlCommand cmd = new SqlCommand(getMechanicId, TalkDB_T.con);
            // create a data reader
            SqlDataReader myReader;
            //execute  the sql statement 
            myReader = cmd.ExecuteReader();

            try
            {
               
                while (myReader.Read())
                {
                    // collect all that that into the variable
                    int VehicleId = myReader.GetInt32(0); // index number
                    // assigm all the values from the values
                    cbVehicleId.Items.Add(VehicleId.ToString());
                }
            }
            catch (Exception ex)
            {
                // display message in case the is an problem to the database
                MessageBox.Show(ex.Message);
            }
            //close the connection with the databaseS
            TalkDB_T.con.Close();
        }

        public void CollectData()
        {
            //open the connection with the database 
            TalkDB_T.con.Open();

            // build the sql statement  to get everything from the tabkle service
            string getData = "SELECT * FROM Service";
            //execute the table
            SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
            //create a table 
            DataTable dt = new DataTable();
            //fill the table the data that you have collect for the statement
            cmd.Fill(dt);


            //display that data to the datagrid 

            dbgridDisplay.DataSource = dt;
            //close the connectio with the database
            TalkDB_T.con.Close();

        }


        public void search(string Search)
        {
            try
            {
                //open the connection with the database
                TalkDB_T.con.Open();
                //build the sql statement where it will search  in the table service any values that you have insert in the tbsearch text box
                string getData = "SELECT * FROM Service WHERE ServiceId== " + Search + "" +
                    "VehicleId== " + Search + "Date== " + Search + "MechanicId== " + Search + "" +
                    "ServiceType== " + Search + "ServiceDescription== " + Search + "";
                //execute the sql statement
                SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
                //create a table
                DataTable dt = new DataTable();
                //fill the table with the data that you have collect from the search 
                cmd.Fill(dt);

                //TalkDB_T.con.Close();

                //display the data in the datagrind
                dbgridDisplay.DataSource = dt;
        
            }
            catch (Exception ex)
            {

                // display message in case the is an problem that the database is facing regarding insertion of data
                MessageBox.Show(ex.Message);
            }
            //close the connection with the database
            TalkDB_T.con.Close();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //display a message of confirmation if the user is sure he want to delete the selected data
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the service for VehicleId: " + cbVehicleId.Text + "", "Delete Service", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //if yes then call the method to delete the select data from the database
                deleteService(ServiceId);

                //refresh the datagrind with the new values of the database
                CollectData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        public void deleteService(string search)
        {
            try
            {
               //open the connectinw with the database
                TalkDB_T.con.Open();
                //build the sql statement to delete the data based on the serviceId
                string deleteService = "delete from Service where ServiceId = '" + Int32.Parse(ServiceId) + "'";

                SqlDataAdapter cmd = new SqlDataAdapter(deleteService, TalkDB_T.con);
                //execute the data 
                cmd.SelectCommand.ExecuteNonQuery();
                
                // display the message to confirm that the data have been deleted
                MessageBox.Show("Service have been deleted successfully");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            //close the connection with the database

            TalkDB_T.con.Close();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit this form
            MainForm.switcher.Controls.Remove(MainForm.ServiceManager);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
       
            //get the values that is going to be search
            string Search = tbSearch.Text;

            //if the user have not insert any values in the search tect box then
            if (tbSearch.Text == "")
            {
                //display this message
                MessageBox.Show("Please insert searchable value");
            }
            else
            {
                //call the method that search the wanted values into the table and take the tyoed valuees as a paramether 
                search(Search);
                
                CollectData();

            }



        }

        private void ServiceManager_Load(object sender, EventArgs e)
        {
            //when the page loads

            cbMechanicId.Items.Clear();
            cbVehicleId.Items.Clear();
            //display the values from the database to the datagrid
            CollectData();
            //display the mechanicId in the combox box
            displayMechanicId();

            //display the vehcileId in the combox box
            displayVehicleId();
        }

        private void rtDescription_KeyPress_Text_Number(object sender, KeyPressEventArgs e)
        {
            //all only letter,digit, and white space in the rtDescription
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void dbgridDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbgridDisplay_DoubleClick(object sender, EventArgs e)
        {
            // once you double click into a row in the datagrid all the values that are inside that row will appear into this component
            ServiceId = dbgridDisplay.CurrentRow.Cells[0].Value.ToString();

            cbVehicleId.Text= dbgridDisplay.CurrentRow.Cells[1].Value.ToString();

            dtDate.Text= dbgridDisplay.CurrentRow.Cells[2].Value.ToString();

          cbMechanicId.Text=  dbgridDisplay.CurrentRow.Cells[3].Value.ToString();

            cbServiceType.Text= dbgridDisplay.CurrentRow.Cells[4].Value.ToString();

            rtDescription.Text= dbgridDisplay.CurrentRow.Cells[5].Value.ToString();





        }
    }
}
