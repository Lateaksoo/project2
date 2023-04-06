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
            if (txtProductName.Text == "") MessageBox.Show("상품명을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxCategory.Text == "") MessageBox.Show("카테고리를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                manager.DeleteProduct(txtProductName.Text, comboBoxCategory.Text);
                this.Close();
                form1.ProductDataViewLoad();
            }
        }
        public string GetImageByProductName(string name)
        {
            string imagePath = "";

            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return imagePath;
        }

   

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Bitmap.FromFile($@"{GetImageByProductName(txtProductName.Text)}");
            }
            catch (Exception ex)
            {
                txtProductName.Text = "";
                return;
            }
          
        }
    }
}
