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

        private string _name;
        private int _price;
        private int _stock;
        private string _image;
        private string _category;
        private string _detail;
        private string origin_name;
        public DetailProduct(string name, int price, int stock, string image, string category, string detail)
        {
            InitializeComponent();
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
            txtName.Text = _name;
            txtPrice.Text = _price.ToString();
            txtStock.Text = _stock.ToString();
            txtimageRoot.Text = _image.ToString();
            pbDetailImage.Image = Image.FromFile(_image);
            txtCategory.Text = _category;
            txtDetail.Text = _detail;

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtStock.Enabled = false;
            txtimageRoot.Enabled = false;
            txtCategory.Enabled = false;
            txtDetail.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e) //편집 누르면 텍스트 활성화 
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtStock.Enabled = true;
            txtimageRoot.Enabled = true;
            txtCategory.Enabled = true;
            txtDetail.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) //저장 버튼을 누르면 데이터베이스에 저장
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtStock.Enabled = false;
            txtimageRoot.Enabled = false;
            txtCategory.Enabled = false;
            txtDetail.Enabled = false;

            manager.UpdateProduct2(_name,txtName.Text,txtPrice.Text,txtStock.Text,txtimageRoot.Text,txtCategory.Text,txtDetail.Text);
        }
    }
}
