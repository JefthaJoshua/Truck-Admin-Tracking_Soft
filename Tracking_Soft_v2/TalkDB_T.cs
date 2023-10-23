using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;    

namespace Tracking_Soft_v2
{
    class TalkDB_T
    {
        public static class myGlobal
        {//get the connection stiing
            public static string connectionString = getConnectionString();
        }

        public static string getConnectionString()
        {
            //set the name of the database
            string fileName = "Track_Data.mdf";
            // create a variable that will hold the path of the path of the database
            string fullPath;

            //get the path of the database
            fullPath = Path.GetFullPath(fileName);
            //return the path
            return fullPath;
        }
        //create the connection string 
        public static SqlConnection con = null;

        public TalkDB_T()
        {//get the path of of the bin folder inside the project files
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
           //remove the the portion of the path that we don't need and add the name of the database
            string newpath = path.Remove(path.Length - 9, 9) + "Track_Data.mdf";
            // rempve the front portion of the path tha we don't need 
            string fullPath = newpath.Remove(0, 6);
            //create the connection string
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fullPath + ";Integrated Security=True");
        }
        public void closeConnection()
        {//close the connection string
            con.Close();
        }
        public DataTable LoginT(String Username, String Password)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Role, LoginID from LoginT Where Username= '" + Username + "' and Password= '" + Password + "'   ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;
        }
        public SqlCommand AddUser()
        {
            String sql = "INSERT INTO LoginT (Username,Password,Role,Firstname,Lastname) VALUES (@Username, @Password, @Role, @Firstname, @Lastname)";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            return cmd;
        }
    }
}
