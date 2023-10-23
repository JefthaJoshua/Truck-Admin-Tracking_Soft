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
    public partial class Administrater : UserControl
    {
        //Declaration of variable

        TalkDB_T db = new TalkDB_T();
        public String[,] Data = new string[100, 6];
        public String[,] UsersId = new string[100, 0];
        public string LoginId;
        public Administrater()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                //Declaration of variable
               

                //assgin the value from the text edit to the variable
                LoginId = tbSearch.Text;

                // run a loop 100 times 
                for (int a = 0; a < 100; a++)
                {
                    //if the loginid is found in the array that got the values from the database
                    if (LoginId == Data[a, 0])
                    {
                        //then assign the values of that row based on the loginId to the components
                        tb_Username.Text = Data[a, 1];
                        tb_Password.Text = Data[a, 2];
                        cb_Role.Text = Data[a, 3];
                        tb_Firstname.Text = Data[a, 4];
                        tb_Lastname.Text = Data[a, 5];
                    }
                }



            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            // once you click on the button uodate then call the method
            updateUsers();
            diplaydbgrid();
        }

        public void updateUsers()
        {

            try
            {

                // create the sql statement that has will uppdate the user base on the values that have been put in different component
                using (SqlCommand command = TalkDB_T.con.CreateCommand())
                {
                    command.CommandText = "UPDATE LoginT SET Username = @Username, Password = @Password, Role = @Role, Firstname = @Firstname, Lastname = @Lastname Where LoginId = @LoginId ";

                    //command.Parameters.AddWithValue("@LoginId", Int32.Parse(cbUsersId.Text));
                    command.Parameters.AddWithValue("@Username", tb_Username.Text);
                    command.Parameters.AddWithValue("@Password", tb_Password.Text);
                    command.Parameters.AddWithValue("@Role", cb_Role.Text);
                    command.Parameters.AddWithValue("@Firstname", tb_Firstname.Text);
                    command.Parameters.AddWithValue("@Lastname", tb_Lastname.Text);
                    command.Parameters.AddWithValue("@LoginId", LoginId);
                    //open the connection with the database

                    TalkDB_T.con.Open();
                    //Execute the sql statement
                    command.ExecuteNonQuery();
                    //display message to comnfirm that the record have been update
                    MessageBox.Show("The User has been updated Successfully");
                    //close the connection with the database
                    TalkDB_T.con.Close();
                }

            }


            catch (Exception ex)
            //in case there is a issues with the values that have been into trhough the uodate statement
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void bt_Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                //open the connection with the database
                db.closeConnection();
                // call the method that hold the sql statement to add a user in the database
                SqlCommand cmd = db.AddUser();
                
                cmd.Parameters.Add("@Username", tb_Username.Text);
                cmd.Parameters.Add("@Password", tb_Password.Text);
                cmd.Parameters.Add("@Role", cb_Role.Text);
                cmd.Parameters.Add("@Firstname", tb_Firstname.Text);
                cmd.Parameters.Add("@Lastname", tb_Lastname.Text);
                
                //Execute the sql statement to add the user based on the values that have beem input 
                cmd.ExecuteNonQuery();
                //display a message to confirm that the data have been uodated 
                MessageBox.Show("Successfully added the User.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TalkDB_T.con.Close();

            // call the method to refresh the values in the datagrid from the new values that have been added
            diplaydbgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection with the database
                TalkDB_T.con.Open();
                // set up the sq; statment that to search from what is in the tbsearch text box, into the table loginT
                String searchData = "SELECT * FROM LoginT WHERE LoginId='" + tbSearch.Text + "'";
                //Execute the sql statement 
                SqlDataAdapter sSDA = new SqlDataAdapter(searchData, TalkDB_T.con);

                //create a table
                DataTable sdt = new DataTable();
                // fill the table with the values that we got to from the execution of the sql statement
                sSDA.Fill(sdt);
                //display the data from the table to the datagrid
                dGride.DataSource = sdt;
            }
            catch (Exception ex)
            {
                // display a message of the sql error in case there are some
                MessageBox.Show(ex.Message);
            }
            //close the connection with the database
            TalkDB_T.con.Close();
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //open connection with the database
                    TalkDB_T.con.Open();
                    // build the  sql statement to delete the row in of the table based of what the person have searched 
                    string Delete = String.Format("delete from LoginT Where LoginId = {0}", Convert.ToInt32(tbSearch.Text));
                 
                    SqlDataAdapter cmd = new SqlDataAdapter(Delete, TalkDB_T.con);
                    //execute the sql statement to delete 
                    cmd.SelectCommand.ExecuteNonQuery();
                    ;//Close the connection to the database
                    TalkDB_T.con.Close();


                }
                catch (Exception ex)
                {
                    // display a message in case if the were a sql error from the sql sat statement 
                    MessageBox.Show(ex.Message);
                }
                //close the connection to the database
                TalkDB_T.con.Close();

                //call the method  to refresh the dabagrid with the uodated verion of the databse
                diplaydbgrid();

            }
        }

        public void diplaydbgrid()
        {
            //open the cinnection with the database
            TalkDB_T.con.Open();
            //build the sql statement to selet everything in the table LonginT
            string getData = "SELECT * FROM LoginT";
            //Execute the sql statement 
            SqlDataAdapter cmd = new SqlDataAdapter(getData, TalkDB_T.con);
            
            //create a table
            DataTable dt = new DataTable();
            //fill the teble with the values that  have been collected from the table loginT
            cmd.Fill(dt);
        //display the values that are in the tables to the datagrind
            dGride.DataSource = dt;

            //close the connection  with the database
            TalkDB_T.con.Close();

        }

        private void Administrater_Load(object sender, EventArgs e)
        {
            // once the page, call this methods
            // call the method to collect the userId from the database an set it in the combo box
            CollectUsersId();
            //call the method to display values that are in the table to the datagrid
            diplaydbgrid();

        }

        public void CollectUsersId()
        {
            //open the connection with the Database
            TalkDB_T.con.Open();
            //build the sql statement to select everything from table loginT
            string getLoginId = "SELECT * FROM LoginT";
            //execute the sql statement 
            SqlDataAdapter cmd = new SqlDataAdapter(getLoginId, TalkDB_T.con);
            //create a table 
            DataTable dt = new DataTable();
            //fill the table with values that we got back from the execution for the sql statement
            cmd.Fill(dt);
            //close the connection with the database
            TalkDB_T.con.Close();

            int a = 0;
            //for each row store the row,store those values into this array
            foreach (DataRow row in dt.Rows)
            {

                Data[a, 0] = row["LoginId"].ToString();
                Data[a, 1] = row["Username"].ToString();
                Data[a, 2] = row["Password"].ToString();
                Data[a, 3] = row["Role"].ToString();
                Data[a, 4] = row["Firstname"].ToString();
                Data[a, 5] = row["Lastname"].ToString();
                a++;

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //initiate the  user contral administrator
            MainForm.switcher.Controls.Remove(MainForm.administrater);
            //hide the current user control 
            MainForm.switcher.Hide();
            //MainForm.switcher.Close();
            MainForm.login.Show();
        }

        private void tbFirstName_KeyPress_Text(object sender, KeyPressEventArgs e)
        {
            //allow text box firstname to enter only letters, and whitespace
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbLastName_KeyPress_Text(object sender, KeyPressEventArgs e)
        {
            // allow the text box lastname to enter only letters and whitespace
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void tbUserId_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            //allow the text box userId to only enter digit
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

            }

        }
    }
}
