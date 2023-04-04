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
    public partial class AddProduct : Form
    {
        private ProductManagerModel productManagerModel;
        private Manager manager;

        private string productName;          
        private int productPrice;         
        private int productStock;         
        private string productImage;
        private string category;

        public AddProduct()
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            productName = productManagerModel.ProductName;
            productPrice = productManagerModel.ProductPrice;
            productStock = productManagerModel.ProductStock;
            productImage = productManagerModel.ProductImage;
            category = productManagerModel.Category;

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
