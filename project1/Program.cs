namespace project1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///        
        private static int _loginStatus;
        public static int LoginStatus { get=>_loginStatus; set=>_loginStatus = value; }
        [STAThread]
        static void Main()
        {
            //Login login = new Login();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            if(_loginStatus == 1)
                Application.Run(new Form1());           
        }
    }
}