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
    public partial class TripManager : UserControl
    {
        public TripManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // if the add button is pressed and on of the field is empty, then
            if ((tripDate.Value.Date == null) || (tbCustomerId.Text == "") || (cbVehicle.Text == "") || (cbDriver.Text == "") || (tbDestinationCity.Text == "") || (tbDepartureCity.Text == "") || (tbTripFuel.Text == "") || (cbCargo.Text == ""))
            {
                //display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method to add a trip
                insertTrip();
                //display the new data into the datagrid
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
        }

        private void insertTrip()
        {
            // declaration of variable
            string orderNum = "";
            int tripId = 0;
            try
            {

                orderNum = generateOrder();
                //open the connection with the database
                TalkDB_T.con.Open();
                //build the sql statement to add a new trip

                String sqlInsert = "insert into Trip(tripDate, orderNum, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType) " +
                    "Values" +
                    "(@tripDate, @orderNum, @vehicle, @driver, @departureCity, @destinationCity, @tripFuel, @customerId, @cargoType)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);
                //get all the values from the fields
                commad.Parameters.AddWithValue("@tripDate", tripDate.Value.Date);
                commad.Parameters.AddWithValue("@orderNum", orderNum);
                commad.Parameters.AddWithValue("@vehicle", cbVehicle.Text);
                commad.Parameters.AddWithValue("@driver", cbDriver.Text);
                commad.Parameters.AddWithValue("@departureCity", tbDepartureCity.Text);
                commad.Parameters.AddWithValue("@destinationCity", tbDestinationCity.Text);
                commad.Parameters.AddWithValue("@tripFuel", tbTripFuel.Text);
                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@cargoType", cbCargo.Text);
                //execute the sql statement
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();

                MessageBox.Show("The trip have been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            //INSERT INTO Customer_Order ==================================================================
            try
            {
                
                tripId = getTripId();
                //open connection with the database 
                TalkDB_T.con.Open();
                // build the sql statement to insert a new customer
                String sqlInsert = "insert into Customer_Order(customerId, orderNum, tripId) " +
                    "Values" +
                    "(@customerId, @orderNum, @tripId)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);
                //collect all the values from the data
                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@orderNum", orderNum);
                commad.Parameters.AddWithValue("@tripId", tripId);
                //execute the sql statement
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();

                MessageBox.Show("The Customer has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string generateOrder()
        {
            string orderNum = "";

            //count number of record
            string command = "SELECT COUNT(tripId) FROM Trip";
            SqlCommand cmd = new SqlCommand(command, TalkDB_T.con);
            //open connection with the database
            TalkDB_T.con.Open();
            //execute the sql statement
            string count = cmd.ExecuteScalar().ToString();
            //close the connection with the database
            TalkDB_T.con.Close();
            //convert the count into a int
            int numOfRecord = Convert.ToInt32(count);
            numOfRecord += 1;

            //OrderNUm Dynamicly generated
            if (numOfRecord < 10)
            {
                orderNum = "CM000" + numOfRecord;
            }
            else
            {
                if (numOfRecord >= 10)
                {
                    orderNum = "CM00" + numOfRecord;
                }
                else
                {
                    if (numOfRecord >= 100)
                    {
                        orderNum = "CM0" + numOfRecord;
                    }
                    else
                    {
                        if (numOfRecord >= 1000)
                        {
                            orderNum = "CM" + numOfRecord;
                        }
                    }
                }
            }
            return orderNum;
        }

        private int getTripId()
        {
            int tripId = 0;
            int numOfRecord = 0;

            //count number of record and Get the last row
            string command = "SELECT COUNT(tripId) FROM Trip";
            SqlCommand cmd = new SqlCommand(command, TalkDB_T.con);
            //open the connection with the database
            TalkDB_T.con.Open();
            //execute the sql statement
            string count = cmd.ExecuteScalar().ToString();
            //close the connection with the database
            TalkDB_T.con.Close();

            //Last row of the Table
            numOfRecord = Convert.ToInt32(count);
            //numOfRecord += 1;



            #region DeadCode
            //WITH TABLE1 AS
            //(
            //SELECT LECT_NAME, LECT_ID, ROW_NUMBER() OVER(ORDER BY LECT_ID) AS ROWNUM
            //FROM LECTURERS
            //)
            //SELECT* FROM TABLE1 WHERE ROWNUM = 2;



            //string cmm = string.Format("WITH TABLE1 AS " +
            //                           "(" +
            //                           "SELECT TripId, ROW_NUMBER() OVER(ORDER BY TripId) AS ROWNUM " +
            //                           "FROM TRIP" +
            //                           ")" +
            //                           "SELECT* FROM TABLE1 WHERE ROWNUM = {0}",
            //                           numOfRecord);
            #endregion



            //-->>  get ID at a specific row
            //command = string.Format("SELECT tripId FROM Trip WHERE tripId = {0}", numOfRecord);
            command = string.Format("WITH TABLE1 AS " +
                                       "(" +
                                       "SELECT TripId, ROW_NUMBER() OVER(ORDER BY TripId) AS ROWNUM " +
                                       "FROM TRIP" +
                                       ")" +
                                       "SELECT* FROM TABLE1 WHERE ROWNUM = {0}",
                                       numOfRecord);
            cmd = new SqlCommand(command, TalkDB_T.con);
            //open the connection with the database 
            TalkDB_T.con.Open();
            //execute the sql statement
            string myId = cmd.ExecuteScalar().ToString();
            //close the connection with the database
            TalkDB_T.con.Close();

            tripId = Convert.ToInt32(myId);

            return tripId;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            //if when the user press the add customer and any fields  empty then 
            if ((tbCustName.Text == "") || (tbEmail.Text == "") || (tbPhoneNum.Text == ""))
            {
                //display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method to insert a customer
                insertCustomer();

                //call the method to refresh the data in the datagrid
                showCustomerGrid();
            }
            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
        }

        private void insertCustomer()
        {
            try
            {
                //open the connection with the database
                TalkDB_T.con.Open();
                //build a sql statement to insert a customer
                String sqlInsert = "insert into Customer(customerFullName, customerPhoneNum, customerEmail) " +
                    "Values" +
                    "(@customerFullName, @customerPhoneNum, @customerEmail)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);
                //collect the all the values
                commad.Parameters.AddWithValue("@customerFullName", tbCustName.Text);
                commad.Parameters.AddWithValue("@customerPhoneNum", tbPhoneNum.Text);
                commad.Parameters.AddWithValue("@customerEmail", tbEmail.Text);
                //execute the sql statment
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();
                //display a confirmation message
                MessageBox.Show("The Customer has been saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCustomerGrid()
        {
            //open the connection with the database
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";
            //cmd.CommandText = "select customerFullName, customerPhoneNum, customerEmail from Customer";
            //build the sql statement to select all the customer
            cmd.CommandText = "select * from Customer";
            //execute the sql statement
            cmd.ExecuteNonQuery();
            //create a table
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //fill the table with the data that have been collected
            da.Fill(dt);
            //display the data into the datagrid
            dataGridTrip.DataSource = dt;
            //close the connection with the database
            TalkDB_T.con.Close();
        }

        private void showTripGrid()
        {
            //open the connection with the database
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";

            //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
            //                    "ORDER BY tripDate DESC";
            //build the sql statment 
            cmd.CommandText = "select * from Trip ORDER BY tripDate DESC";
            //execute the sql statement
            cmd.ExecuteNonQuery();
            //create a table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //fill the table with the data that have been collected
            da.Fill(dt);
            //display the data from a datagrid
            dataGridTrip.DataSource = dt;
            //close the connection with the database
            TalkDB_T.con.Close();
        }

        private void TripManager_Load(object sender, EventArgs e)
        {
            //once the page load, display the data into the datagrid
            showTripGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //when the button update is clicked and any field is empty, then
            if ((tripDate.Value.Date == null) || (tbCustomerId.Text == "") || (cbVehicle.Text == "") || (cbDriver.Text == "") || (tbDestinationCity.Text == "") || (tbDepartureCity.Text == "") || (tbTripFuel.Text == "") || (cbCargo.Text == "") || (tbSearchTrip.Text == ""))
            {
                //display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method that uodate the trip
                updateTrip();

                //refresh the data in the datagrid with the new data
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
            tbSearchTrip.Text = null;
        }

        private void updateTrip()
        {
            try
            {
                //open connection with the database
                TalkDB_T.con.Open();
                //build sql statement to update teh trip
                String sqlUpdate = "UPDATE Trip " +
                                   "SET tripDate = @tripDate, vehicle = @vehicle, driver = @driver, departureCity = @departureCity, destinationCity = @destinationCity, tripFuel = @tripFuel, customerId = @customerId, cargoType = @cargoType " +
                                   "WHERE orderNum = @orderNum";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);

                commad.Parameters.AddWithValue("@orderNum", tbSearchTrip.Text);
                commad.Parameters.AddWithValue("@tripDate", tripDate.Value.Date);
                commad.Parameters.AddWithValue("@vehicle", cbVehicle.Text);
                commad.Parameters.AddWithValue("@driver", cbDriver.Text);
                commad.Parameters.AddWithValue("@departureCity", tbDepartureCity.Text);
                commad.Parameters.AddWithValue("@destinationCity", tbDestinationCity.Text);
                commad.Parameters.AddWithValue("@tripFuel", tbTripFuel.Text);
                commad.Parameters.AddWithValue("@customerId", tbCustomerId.Text);
                commad.Parameters.AddWithValue("@cargoType", cbCargo.Text);
                //execute the sql statement
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();
                //display the message to confir that the trio have been uodated
                MessageBox.Show("The Trip has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            // whent the button update customer is press, and any of the fields is empty then
            if ((tbCustName.Text == "") || (tbEmail.Text == "") || (tbPhoneNum.Text == "") || (tbSearchCustomer.Text == ""))
            {
                //display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method to update customer
                updateCustomer();

                //refresh the data in the datagrid
                showCustomerGrid();
            }
            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
            tbSearchCustomer.Text = null;
        }

        public void updateCustomer()
        {
            try
            {
                //open connection with the database 
                TalkDB_T.con.Open();
                //build the sql statement to update customer
                String sqlUpdate = "UPDATE Customer " +
                                   "SET customerFullName = @customerFullName, customerPhoneNum = @customerPhoneNum, customerEmail = @customerEmail " +
                                   "WHERE customerId = @customerId";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);
                //collect all the data
                commad.Parameters.AddWithValue("@customerId", Convert.ToInt32(tbSearchCustomer.Text));
                commad.Parameters.AddWithValue("@customerFullName", tbCustName.Text);
                commad.Parameters.AddWithValue("@customerPhoneNum", tbPhoneNum.Text);
                commad.Parameters.AddWithValue("@customerEmail", tbEmail.Text);
                //execute the sql
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();
                //display the confirmation message
                MessageBox.Show("The Customer has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelCust_Click(object sender, EventArgs e)
        {
            //if the search fields is null
            if (tbSearchCustomer.Text == "")
            {//display the message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method to delete the customer
                delCustomer();
                //refresh the data in the datagrid
                showCustomerGrid();
            }

            tbCustName.Text = null;
            tbEmail.Text = null;
            tbPhoneNum.Text = null;
            tbSearchCustomer.Text = null;
        }

        public void delCustomer()
        {
            try
            {
                //open the connection with the database
                TalkDB_T.con.Open();
                //build a sql statement to delete the selected values
                string Delete = string.Format("delete from Customer where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql
                cmd.SelectCommand.ExecuteNonQuery();

                //close the connection  with the database
                TalkDB_T.con.Close();



                //open the connection with the database
                TalkDB_T.con.Open();
                //build sql statement to delete the selected customer
                Delete = string.Format("delete from Customer_Order where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql statement
                cmd.SelectCommand.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();




                //open the connection with the database
                TalkDB_T.con.Open();
                //build sql statement to delete the selected trip
                Delete = string.Format("delete from Trip where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql statement
                cmd.SelectCommand.ExecuteNonQuery();
                //close connectiion with the database
                TalkDB_T.con.Close();
                //display confirmation message
                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delTrip()
        {
            try
            {
               //open the connection with the database
                TalkDB_T.con.Open();
                //build sql statement to delete the selected  customer order
                string Delete = string.Format("delete from Customer_Order where orderNum = '{0}'", tbSearchTrip.Text);

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql statement
                cmd.SelectCommand.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();



                //open the connection with the database
                TalkDB_T.con.Open();
                //build a sql statement to delete the selected trip
                Delete = string.Format("delete from trip where orderNum = '{0}'", tbSearchTrip.Text);

                cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql statement
                cmd.SelectCommand.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();
                //display the confirmation message
                MessageBox.Show("The Trip has been Deleted Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check if the search trip is null
            if (tbSearchTrip.Text == "")
            {
                //then displayy this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call method to delete trip
                delTrip();
                //refresh the datarind with the new data
                showTripGrid();
            }
            cbCargo.Text = null;
            tbTripFuel.Text = null;
            tbDepartureCity.Text = null;
            tbDestinationCity.Text = null;
            cbDriver.Text = null;
            cbVehicle.Text = null;
            tbCustomerId.Text = null;
            tripDate.Value = DateTime.Today;
            tbSearchTrip.Text = null;
        }

        private void btnSearchTrip_Click(object sender, EventArgs e)
        {
            if (tbSearchTrip.Text == "")
            {//display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //open connection with the database
                TalkDB_T.con.Open();

                SqlCommand cmd = TalkDB_T.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * country from Testing";

                //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
                //                    "ORDER BY tripDate DESC";

                //cmd.CommandText = string.Format("select * from Trip Where TripId = {0}", Convert.ToInt32(tbSearchTrip.Text)); 
               //build a sql statement to delete the wanted trip
                cmd.CommandText = string.Format("select * from Trip Where orderNum = '{0}'", tbSearchTrip.Text);
              //execute the sql statement
                cmd.ExecuteNonQuery();
                //create the table
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //fill the tale with the values that you have collected
                da.Fill(dt);
                //display the data to the datagrid
                dataGridTrip.DataSource = dt;
                //close the connection with the database
                TalkDB_T.con.Close();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (tbSearchCustomer.Text == "")
            {
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                TalkDB_T.con.Open();

                SqlCommand cmd = TalkDB_T.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = string.Format("select * from Customer Where customerId = {0}", Convert.ToInt32(tbSearchCustomer.Text));
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridTrip.DataSource = dt;

                TalkDB_T.con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm.switcher.Controls.Remove(MainForm.tripManager);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void cbVehicle_DropDown(object sender, EventArgs e)
        {
            try
            {
                //  --->>>  Getting all records on the comboBox
                string command = "SELECT * FROM VehicleInfo";
                SqlDataAdapter da = new SqlDataAdapter(command, TalkDB_T.con);//    --->>>  DataAdapter connect & fills the DataSet with the Db
                DataSet ds = new DataSet();
                da.Fill(ds, "dsVehicle");

                cbVehicle.DataSource = ds.Tables["dsVehicle"].DefaultView;
                cbVehicle.DisplayMember = ds.Tables["dsVehicle"].Columns["Manufacturer"].ToString();
                cbVehicle.ValueMember = ds.Tables["dsVehicle"].Columns["VehicleID"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDriver_DropDown(object sender, EventArgs e)
        {
            try
            {
                //  --->>>  Getting all records on the comboBox
                string command = "SELECT * FROM LoginT Where role = 'Driver'";
                SqlDataAdapter da = new SqlDataAdapter(command, TalkDB_T.con);//    --->>>  DataAdapter connect & fills the DataSet with the Db
                DataSet ds = new DataSet();
                da.Fill(ds, "dsDriver");

                cbDriver.DataSource = ds.Tables["dsDriver"].DefaultView;
                cbDriver.DisplayMember = ds.Tables["dsDriver"].Columns["Firstname"].ToString();
                cbDriver.ValueMember = ds.Tables["dsDriver"].Columns["LoginId"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbShowTrip_Click(object sender, EventArgs e)
        {
            showTripGrid();
        }

        private void btShowCustomer_Click(object sender, EventArgs e)
        {
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * country from Testing";

            //cmd.CommandText = "select orderNum, tripDate, vehicle, driver, departureCity, destinationCity, tripFuel, customerId, cargoType from Trip " +
            //                    "ORDER BY tripDate DESC";

            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridTrip.DataSource = dt;

            TalkDB_T.con.Close();
        }

        private void tbFrom_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {

            //only allow letter and whitespace
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbTo_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            //only allow letter and white space
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbFuel_KeyPress_Number_Commas(object sender, KeyPressEventArgs e)
        {
            // only allow digit and comma and full stop
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void tbName_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {
            //only allow letter, and white space
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbEmail_KeyPress_Text_Number_At_Comma(object sender, KeyPressEventArgs e)
        {
            //only allow digit, letter
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != '@') && (e.KeyChar != ','))
            {
                e.Handled = true;

            }



        }

        private void tbCustomerId_KeyPress_Number(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }

        }

        private void tbPhoneNum_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbOrderNum_KeyPress_Number(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void tbCusstumerIdSearch_KeyPress_Number(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
