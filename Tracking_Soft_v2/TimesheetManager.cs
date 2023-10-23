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
using System.Globalization;

namespace Tracking_Soft_v2
{
    public partial class TimesheetManager : UserControl
    {
        public TimesheetManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // if you press the add button and one of those component is still empty then
            if ((tbLoginId.Text == "") || (tbName.Text == "") || (tbSurname.Text == "") || (cbRole.Text == "") || (sheetDate.Value.Date == null) || (tbWorkHour.Text == ""))
            {
                //display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {

                //call the method that insert a new timesheet in the database
                insertTimeSheet();
                //update the datagrid with the data from the database
                showSheetGrid();
            }
            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        private void insertTimeSheet()
        {
            try
            {
                //open the connection with the database
                TalkDB_T.con.Open();
                //buold the sql statement to insert a new timesheet 
                String sqlInsert = "insert into TimeSheet(LoginId, Firstname, LastName, Role, date, work_Hours) " +
                    "Values" +
                    "(@LoginId, @Firstname, @Lastname, @Role, @date, @work_Hours)";


                SqlCommand commad = new SqlCommand(sqlInsert, TalkDB_T.con);
                //get the values that are being inserted in the timesneet
                commad.Parameters.AddWithValue("@LoginId", Convert.ToInt32(tbLoginId.Text));
                commad.Parameters.AddWithValue("@Firstname", tbName.Text);
                commad.Parameters.AddWithValue("@Lastname", tbSurname.Text);
                commad.Parameters.AddWithValue("@Role", cbRole.Text);
                commad.Parameters.AddWithValue("@date", sheetDate.Value.Date);
                commad.Parameters.AddWithValue("@work_Hours", Convert.ToInt32(tbWorkHour.Text));
                //execute the sql statement
                commad.ExecuteNonQuery();
                //close the connection to database
                TalkDB_T.con.Close();
                //display a confirmation message 
                MessageBox.Show("The Record has been added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSheetGrid()
        {
            //open the connection with the database
            TalkDB_T.con.Open();

            SqlCommand cmd = TalkDB_T.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
        //build a sql statement to get all the data from the table timesheet 
            cmd.CommandText = "select * from TimeSheet";
            //execute the sql statement
            cmd.ExecuteNonQuery();
            //create a table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //fill the table with the collected data from the sql statement
            da.Fill(dt);
            //display the data to the datgrid
            dataGridSheet.DataSource = dt;
            //close the connection with the database
            TalkDB_T.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // if you press the update button and one of those component is still empty then
            if ((tbLoginId.Text == "") || (tbName.Text == "") || (tbSurname.Text == "") || (cbRole.Text == "") || (sheetDate.Value.Date == null) || (tbWorkHour.Text == ""))
            {
                // display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //call the method to update the timesheet with the current values
                updateTimeSheet();
                //refresh the datagrid with the new values in the database
                showSheetGrid();
            }
            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        public void updateTimeSheet()
        {
            try
            {
                //open connection with the database
                TalkDB_T.con.Open();

                //build the sql statement to uodate the selected timesheet with thw new values
                String sqlUpdate = "UPDATE TimeSheet " +
                                   "SET Firstname = @Firstname, Lastname = @Lastname, Role = @Role, date = @date, work_Hours = @work_Hours " +
                                   "WHERE LoginId = @LoginId";


                SqlCommand commad = new SqlCommand(sqlUpdate, TalkDB_T.con);
                //get the all the new values
                commad.Parameters.AddWithValue("@LoginId", Convert.ToInt32(tbLoginId.Text));
                commad.Parameters.AddWithValue("@Firstname", tbName.Text);
                commad.Parameters.AddWithValue("@Lastname", tbSurname.Text);
                commad.Parameters.AddWithValue("@Role", cbRole.Text);
                commad.Parameters.AddWithValue("@date", sheetDate.Value.Date);
                commad.Parameters.AddWithValue("@work_Hours", Convert.ToInt32(tbWorkHour.Text));
                //execute the sql statement 
                commad.ExecuteNonQuery();
                //close the connection with the database
                TalkDB_T.con.Close();
                //display a confirmation messages 
                MessageBox.Show("The Record has been updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if the search date values is null
            if (searchDate.Value.Date == null)
            {
                //then display this message
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {

                // display a message of confirmation in order to confirms he is going to delete the selected timesheet
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Timesheet ?", "Delete Timesheet", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    //call the method to delete the timssheet
                    deleteSheet();
                    //update the datagrid with the new values of the table
                    showSheetGrid();
                }
            }

            tbLoginId.Text = null;
            tbName.Text = null;
            tbSurname.Text = null;
            cbRole.Text = null;
            sheetDate.Value = DateTime.Today;
            tbWorkHour.Text = null;
        }

        private void deleteSheet()
        {
            try
            {
                //
                string DateString = String.Format("{0:yyyy/M/d}", searchDate.Value.Date);
                //open the connection with the database
                TalkDB_T.con.Open();
                //build the sql statement to delete the selected timesheet
                string Delete = string.Format("delete from TimeSheet where date = '{0}' And LoginId = {1}", DateString, Convert.ToInt32(tbSearchSheetLoginId.Text));

                SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                //execute the sql statement
                cmd.SelectCommand.ExecuteNonQuery();
                //close the connecion with the database
                TalkDB_T.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimesheetManager_Load(object sender, EventArgs e)
        {
            //once the page load , the call the method that display the values on the datagrid
            showSheetGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //if the search values is null then
            if (searchDate.Value.Date == null)
            {
                //display the message 
                MessageBox.Show("Please make sure that you do not have empty fields");
            }
            else
            {
                //Convert Date to yy/mm/dd
                string DateString = String.Format("{0:yyyy/M/d}", searchDate.Value.Date);
                try
                {
                    //open the connection with the database
                    TalkDB_T.con.Open();

                    SqlCommand cmd = TalkDB_T.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    // build a sql statement to display teh search values
                    cmd.CommandText = string.Format("select * from TimeSheet Where date = '{0}' And LoginId = {1}", DateString, Convert.ToInt32(tbSearchSheetLoginId.Text));
                    //execute the sql statement
                    cmd.ExecuteNonQuery();
                    //create a table
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //fill the collected data to the table
                    da.Fill(dt);
                    //display the table and his data in the datagrid
                    dataGridSheet.DataSource = dt;
                    //close the connecion with the database
                    TalkDB_T.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit the page
            MainForm.switcher.Controls.Remove(MainForm.timeMan);
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void tbLogunId_keyPress_Number(object sender, KeyPressEventArgs e)
        {
            //only allow digit to press
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }
        }

        private void tbName_keyPress_Text_White(object sender, KeyPressEventArgs e)
        {
            //only allow letter and white space
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbSurname_KeyPress_Text_WhiteSpace(object sender, KeyPressEventArgs e)
        {

            //only allow letters, and white space
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbWorkHours_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            //only allow digit
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;

            }
        }

        private void tbSearchLoginId_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            //only allow digit to be press
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}
