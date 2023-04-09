using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class UpDate : Form
    {
        ManagerModel model = new ManagerModel();
        private int _uid = 0;
        private string _id = "";
        public UpDate(int uid, string id)
        {
            InitializeComponent();
            _uid = uid;
            _id = id;
            Find();
            lbl_uname.Text = _id;
            txt_email.Text = model.Email;
            txt_phonenum.Text = model.PhoneNum;
            txt_pw.Text = model.PassWord;
            txt_pwcheck.Text = model.PassWord;
        }
        public void Find()
        {
            using SqlCommand cmd = new("SELECT * FROM Manager WHERE uid = @uid", Program.Conn);
            cmd.Parameters.AddWithValue("@uid", _uid);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                model.Uid = reader.GetInt32("uid");
                model.Name = reader.GetString("name");
                model.Email = reader.GetString("email");
                model.PassWord = reader.GetString("pw");
                model.PhoneNum = reader.GetString("phonenum");
            }

            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_pw.Text.Length < 4)
                MessageBox.Show("최소 4글자이상의 비밀번호를 입력하세요.");
            else if (txt_pw.Text != txt_pwcheck.Text)
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            else
            {               
                using (SqlCommand cmd = new("UPDATE Manager set " +
                                            "name = @name, phonenum = @phonenum, " +
                                            "pw = @pw, email = @email " +
                                            "WHERE uid = @uid", Program.Conn))
                {
                    cmd.Parameters.AddWithValue("@name", model.Name);
                    cmd.Parameters.AddWithValue("@pw", txt_pwcheck.Text);
                    cmd.Parameters.AddWithValue("@phonenum",txt_phonenum.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@uid", _uid);
                    cmd.ExecuteNonQuery();
                    Close();             
                }
               
            }

        }
    }
}
