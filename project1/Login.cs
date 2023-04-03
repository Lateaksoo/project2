using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace project1
{
    public partial class Login : Form
    {
        /*private string _uid;  
        private string _name;   
        private string _phoneNum;  
        private string _password;     
        private string _email;
        private string _regDate;*/
        //----------------------------------------------------------------------------------------------//
        
        List<ManagerModel> list = new();
        string strConn = "Server=127.0.0.1; Database=Kims_Familly; uid=my_user; pwd=1234; Encrypt=false";
        SqlConnection conn;
        SqlDataReader reader;
        public int loginstatus; 
        

        public Login()
        {
            
            InitializeComponent();
            conn = new(strConn);
            conn.Open();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        public object List()
        {
            using SqlCommand cmd = new($"select * from Manager", conn);
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
                    Email= (string)row["email"],
                    RegDate = (DateTime)row["regdate"],
                });
            }

            return list;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            List();

            string id = "", pw = "";
            id = txt_id.Text;
            pw = txt_pw.Text;
            int ide = 0;
            int pwe = 0;
            foreach (var item in list)
            {
                if (id == item.Name && pw == item.PassWord)
                {
                    
                    var form = Application.OpenForms["Form1"];

                    if (form == null)
                    {
                        form = new Form1();
                    }
                    //form.Show();
                    Program.LoginStatus = 1;
                    Close();
                }
                else if (id == item.Name)
                {
                    ide = 1;                 
                }
                else if (pw == item.PassWord)
                {
                   pwe= 1;
                }
            }
            if (ide == 0)
            {
                MessageBox.Show("잘못된 ID 입니다.");
                return;
            }
            if (pwe == 0)
            {
                MessageBox.Show("잘못된 비밀번호 입니다.");
                return;
            }
        }
    }
}
