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
    public partial class DeleteProduct : Form
    {
        private ProductManagerModel productManagerModel;
        private Manager manager;


        private Form1 form1;
        public DeleteProduct(Form1 form1)
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.form1 = form1;
        }
        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            DataTable categoryTable = manager.GetCategoryComboBox();

            // 콤보박스에 카테고리를 추가함
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //기본으로 선택되어 있는 값
            comboBoxCategory.SelectedIndex = 0;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (manager.DeleteProduct(txtProductName.Text, comboBoxCategory.Text) == true) //상품 삭제 성공하면 
            {
                this.Close();
                form1.ProductDataViewLoad(); //폼 닫고 그리드뷰 새로고침
            }
        }
        public string GetImageByProductName(string name) // 입력한 이름이 데이터베이스에 있는지 확인하고 제품 이미지 경로 가져오기
        {
            string imagePath = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Program.Conn;
                    cmd.CommandText = "SELECT image FROM Product WHERE name = @name";
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imagePath = reader.GetString(0);
                        }
                    }
                }
            return imagePath;
        }



        private void txtProductName_Leave(object sender, EventArgs e) //텍스트 입력하면 사진을 띄우고 사진이 없는 상품이면 안띄움
        {
            try
            {
                pictureBox1.Image = Bitmap.FromFile($@"{GetImageByProductName(txtProductName.Text)}");
            }
            catch (Exception ex)
            {
                return;
            }

        }
    }
}
