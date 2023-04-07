using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace project1
{
    public partial class DetailProduct : Form
    {
        private ProductManagerModel productManagerModel;
        private Manager manager;
        private Form1 form1;

        private string _name;
        private int _price;
        private int _stock;
        private string _image;
        private string _category;
        private string _detail;

        public DetailProduct(Form1 form1, string name, int price, int stock, string image, string category, string detail)
        {
            InitializeComponent();
            this.form1 = form1;
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);

            _name = name;
            _price = price;
            _stock = stock;
            _image = image;
            _category = category;
            _detail = detail;
            pbDetailImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            DataTable categoryTable = manager.GetCategoryComboBox();
            // 콤보박스에 카테고리를 추가함
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //기본으로 선택되어 있는 값
            comboBoxCategory.SelectedIndex = 0;

            txtName.Text = _name;
            txtPrice.Text = _price.ToString();
            txtStock.Text = _stock.ToString();
            txtProductImage.Text = _image.ToString();
            pbDetailImage.Image = Image.FromFile(_image);
            comboBoxCategory.Text = _category;
            txtDetail.Text = _detail;

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtStock.Enabled = false;
            txtProductImage.Enabled = false;
            comboBoxCategory.Enabled = false;
            txtDetail.Enabled = false;
            btnFindIamge.Enabled = false; // 버튼 비활성화

        }

        private void btnEdit_Click(object sender, EventArgs e) //편집 누르면 텍스트 활성화 
        {
            btnFindIamge.Enabled = true; // 버튼 활성화
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtStock.Enabled = true;
            txtProductImage.Enabled = true;
            comboBoxCategory.Enabled = true;
            txtDetail.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) //저장 버튼을 누르면 데이터베이스에 저장
        {
            manager.UpdateProduct(_name, txtName.Text, txtPrice.Text, txtStock.Text, txtProductImage.Text, comboBoxCategory.Text, txtDetail.Text);
            form1.ProductDataViewLoad();
            this.Close();
        }

        private void btnFindIamge_Click(object sender, EventArgs e)
        {
            txtProductImage.Text = manager.FindInamge();
        }
    }
}
