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
        
        public int loginstatus; 
        

        public Login()
        {
            
            InitializeComponent();
           
            Program.List();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {           
            string id = "", pw = "";
            id = txt_id.Text;
            pw = txt_pw.Text;
            int ide = 0;
            int pwe = 0;
            foreach (var item in Program.List())
            {
                if (id == item.Name && pw == item.PassWord)
                {
                    var form = Application.OpenForms["Form1"];
                    ide = 1;
                    pwe = 1;
                    if (form == null)
                    {
                        form = new Form1();
                    }
                    //form.Show();
                    Program.LoginStatus = 1;
                    Program.Uid= item.Uid;
                    //Program.Conn.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["Find_idpw"];

            if (form == null)
            {
                form = new Find_idpw();
            }
            form.Show();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["AddManager"];

            if (form == null)
            {
                form = new AddManager();
            }
            form.Show();
        }

        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }
    }
}
