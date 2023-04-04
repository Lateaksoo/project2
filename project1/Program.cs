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

        //-------------------Connecttion 积己----------------------------//
        static string strConn = "Server=127.0.0.1; Database=Kims_Familly; uid=my_user; pwd=1234; Encrypt=false";
        private static SqlConnection conn;
        public static SqlConnection Conn { get=>conn; set=>conn = value; }
        //-----------------Manager Table阑 历厘且 List积己----------------------------//
        static List<ManagerModel> list = new();

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
            

            Application.Run(new Login());
            if (_loginStatus == 1)
                Application.Run(new Form1());

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