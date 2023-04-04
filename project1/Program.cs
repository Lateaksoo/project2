using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace project1
{
     
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///        
        private static int _loginStatus;
        private static int _uid;
        public static int LoginStatus { get=>_loginStatus; set=>_loginStatus = value; }
        public static int Uid { get=>_uid; set=>_uid = value; }


        static string strConn = "Server=127.0.0.1; Database=Kims_Familly; uid=myuser; pwd=1234; Encrypt=false";
        private static SqlConnection conn;



        public static SqlConnection Conn { get=>conn; set=>conn = value; }
        static List<ManagerModel> list = new();

        static string strConn_test = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TeamProject\Project_ver1.0\project1\Database1.mdf;Integrated Security=True";
        private static SqlConnection testConn;


        [STAThread]
        static void Main()
         {
            //Login login = new Login();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            conn = new(strConn);
            conn.Open();

            List();
            //TestDatabase();

            Application.Run(new Login());
            if (_loginStatus == 1)
                Application.Run(new Form1());

        }
        public static void TestDatabase()
        { 
            testConn= new SqlConnection(strConn_test);
            testConn.Open();

            using SqlCommand cmd = new("INSERT INTO Manager(name, pw, phonenum, email) VALUES (@name, @pw, @phonenum, @email)", testConn);
            foreach (var item in list)
            { 
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@pw", item.PassWord);
                cmd.Parameters.AddWithValue("@phonenum", item.PhoneNum);
                cmd.Parameters.AddWithValue("@email", item.Email);
                cmd.ExecuteNonQuery();
            }
        }
        public static IEnumerable<ManagerModel> List()
        {
            using SqlCommand cmd = new($"select * from Manager", Program.Conn);
            SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds);

            DataTable table = ds.Tables[0];


            foreach (DataRow row in table.Rows)
            {
                list.Add(new()
                {
                    Uid = (int)row["uid"],
                    Name = (string)row["name"],
                    PhoneNum = (string)row["phonenum"],
                    PassWord = (string)row["pw"],
                    Email = (string)row["email"],
                    RegDate = (DateTime)row["regdate"],
                });
            }

            return list;
        }

    }
}