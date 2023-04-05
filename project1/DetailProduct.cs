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
        private string _name;
        private int _price;
        private int _stock;
        private string _image;
        private string _category;
        private string _detail;
        public DetailProduct(string name, int price, int stock, string image, string category, string detail)
        {
            InitializeComponent();
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
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
