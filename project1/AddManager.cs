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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project1
{
    public partial class AddManager : Form
    {
        private int _idstatus = 0;
        
        public AddManager()
        {
            InitializeComponent();
        }
        private void AddManager_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idstatus = 1;
            foreach (var item in Program.List())
            {
                if (txt_id.Text.Trim() == item.Name)
                    idstatus= 0;
            }
            if (txt_id.Text.Length == 0)
                MessageBox.Show("ID를 입력하세요");
            else if (idstatus == 1)
            {
                MessageBox.Show("사용가능한ID 입니다.");
                _idstatus = 1;
            }
            else
                MessageBox.Show("중복된 ID입니다.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
                MessageBox.Show("ID를 입력하세요");
            else if (_idstatus == 0)
                MessageBox.Show("ID중복확인.");
            else if (txt_pw.Text.Length < 4)
                MessageBox.Show("최소 4글자이상의 비밀번호를 입력하세요.");
            else if (txt_pw.Text != txt_pwcheck.Text)
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            else if (!txt_phonenum.MaskCompleted)
                MessageBox.Show("전화번호를 입력하세요.");
            else
            {
                //insert INTO Manager(name, pw, phonenum, email)
                using SqlCommand cmd = new("INSERT INTO Manager(name, pw, phonenum, email) VALUES (@name, @pw, @phonenum, @email)", Program.Conn);
                cmd.Parameters.AddWithValue("@name", txt_id.Text.Trim());
                cmd.Parameters.AddWithValue("@pw", txt_pw.Text.Trim());
                cmd.Parameters.AddWithValue("@phonenum", txt_phonenum.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.ExecuteNonQuery();                
                MessageBox.Show("계정추가완료.");
                Close();
            }            
        }
    }
}
