using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace project1
{
    public partial class AddProduct : Form
    {
        private ProductManagerModel productManagerModel;
        private Manager manager;

        private string productName;
        private int productPrice;
        private int productStock;
        private string productImage;
        private string category;
        private Form1 form1;

        public AddProduct(Form1 form1)
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            productName = productManagerModel.ProductName;
            productPrice = productManagerModel.ProductPrice;
            productStock = productManagerModel.ProductStock;
            productImage = productManagerModel.ProductImage;
            category = productManagerModel.Category;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.form1 = form1;
        }
        private void AddProduct_Load(object sender, EventArgs e)
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "") MessageBox.Show("상품명을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtProductStock.Text == "") MessageBox.Show("재고량을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtProductPrice.Text == "") MessageBox.Show("가격을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxCategory.Text == "") MessageBox.Show("카테고리를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                manager.AddProduct(txtProductName.Text,
                            txtProductPrice.Text,
                            txtProductStock.Text,
                            txtProductImage.Text, comboBoxCategory.Text);
                
                this.Close();
                //form1.ProductDataViewLoad();
            }
        }

        private void txtProductImage_Leave(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile($@"{txtProductImage.Text}");
        }
    }
}
