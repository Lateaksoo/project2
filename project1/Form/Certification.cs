using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Certification : Form
    {
        ManagerModel model = new();

        private int _uid = 0;
        private string _id = "";
        private bool _status;
        public Certification(int uid, string id, bool status)
        {
            InitializeComponent();
            _uid = uid;
            _id = id;
            _status = status;

            Find();
        }

        public void Find()
        {
            using SqlCommand cmd = new("SELECT * FROM dbo.Manager WHERE uid = @uid", Program.Conn);
            cmd.Parameters.AddWithValue("@uid", _uid);

            using SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                model.Uid = reader.GetInt32("uid");
                model.Name = reader.GetString("name");
                model.PassWord = reader.GetString("pw");
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.Name == txt_id.Text && model.PassWord == txt_pw.Text)
            {
                if (_status == false)
                {

                    var form = Application.OpenForms["UpDate"];

                    if (form == null)
                    {
                        form = new UpDate(_uid, _id);
                    }
                    form.Show();
                    Close();

                }
                else
                {
                    DialogResult result = MessageBox.Show($"데이터를 삭제하시겠습니까?", "Delete",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result != DialogResult.OK) return;
                    using (SqlCommand cmd = new("DELETE Manager WHERE uid = @uid", Program.Conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", _uid);
                        int cnt = cmd.ExecuteNonQuery();

                    }
                    Close();
                }
            }
            else
                MessageBox.Show("인증 실패");
        }

        private void Certification_Load(object sender, EventArgs e)
        {
            txt_id.Text = _id;
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
