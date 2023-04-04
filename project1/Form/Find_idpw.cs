using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    
    public partial class Find_idpw : Form
    {
        
        public Find_idpw()
        {
            InitializeComponent();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int status = 0;
            string id = "";
            foreach (var item in Program.List())
            {
                if (txt_pnid.Text == item.PhoneNum)
                {
                    id = item.Name;
                    status= 1;
                }
            }
            if(status == 1)
            { 
                MessageBox.Show($"ID : {id}");               
            }
            else
                MessageBox.Show("등록되지 않은 정보입니다.");
        }

        private void Find_idpw_Load(object sender, EventArgs e)
        {
            
            ActiveControl = txt_pnid;           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            int idstatus = 0;
            int pnstatus = 0;
            string pw = "";
            foreach (var item in Program.List())
            {
                if (txt_id.Text == item.Name && txt_pnpw.Text == item.PhoneNum)
                {
                    pw = item.PassWord;
                    idstatus = 1;
                    pnstatus = 1;
                }
                else if(txt_id.Text == item.Name)
                    idstatus= 1;
            }
            if (idstatus == 1 && pnstatus == 1)
            {
                MessageBox.Show($"PassWord : {pw}");
            }
            else if (pnstatus == 0 && idstatus == 1)
                MessageBox.Show("잘못된 전화번호입니다..");
            else
                MessageBox.Show("등록되지 않은 ID입니다.");

        }
    }
}
