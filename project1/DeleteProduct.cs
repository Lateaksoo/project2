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

        private string productName;
        private string category;
        public DeleteProduct()
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            productName = productManagerModel.ProductName;
            category = productManagerModel.Category;

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
            manager.DeleteProduct(txtProductName.Text,comboBoxCategory.Text);
            this.Close();
        }
    }
}
