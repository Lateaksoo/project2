using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Text;
using System.Drawing.Imaging;

namespace project1
{
    public partial class Form1 : Form
    {
        NaverSearch naverSearch = new NaverSearch();

        private ProductManagerModel productManagerModel;
        private Manager manager;
        private string category;
        private string startDate;
        private string endDate;
        private string age;
        private string gender;
        private string timeUnit;
        private string keywordName;
        private string searchProductName;

        public Form1()
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            category = productManagerModel.Category;
            startDate = productManagerModel.StartDate;
            endDate = productManagerModel.EndDate;
            age = productManagerModel.Age;
            gender = productManagerModel.Gender;
            timeUnit = productManagerModel.TimeUnit;
            keywordName = productManagerModel.KeywordName;
            searchProductName = productManagerModel.SearchProductName;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataViewLoad();//���� �ҷ�����
            ProductDataViewLoad(); //��ǰ ���� �ҷ�����
            DataTable categoryTable = manager.GetCategoryComboBox();
            // �޺��ڽ��� ī�װ��� �߰���
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //�⺻���� ���õǾ� �ִ� ��
            comboBoxCategory.SelectedIndex = 0;
            timeUnit = "month";
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
        }

        //---------------------------------------------------------------------------------
        //�Ǹ� Ʈ���� ��
        private void btnSearch_Click(object sender, EventArgs e) //��ȸ ��ư 
        {
            bool isAnyChecked = false; // üũ�ڽ��� �� �� �̻� üũ�Ǿ����� Ȯ���ϴ� ����
            CheckBox[] checkBoxes = { check10, check20, check30, check40, check50, check60 };
            age = "";
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked) //üũ�� ������ ���ڿ��� ����� 
                {
                    age += $"{checkBox.Text.Replace("��", "")}\",\"";
                    isAnyChecked = true;
                }
            }
            if (age.EndsWith("\",\"")) //���������� \",\"�� ������� �Ѵ�.
            {
                age = age.Remove(age.Length - 3);
            }
            if (!isAnyChecked) // üũ�ڽ��� �� �� �̻� üũ���� �ʾ��� ���
            {
                MessageBox.Show("���ɴ븦 �������ּ���.");
                return; // �޼ҵ� ���� ����
            }

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) //������
        {
            startDate = "";  //�������� �ʱ�ȭ����
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e) //������
        {
            endDate = "";  //�������� �ʱ�ȭ����
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e) //���� �޺��ڽ�
        {
            gender = ""; //���� ����
            switch (comboBoxSex.Text)
            {
                case "��": gender = "m"; break;
                case "��": gender = "f"; break;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) //ī�װ� �޺��ڽ�
        {
            manager.CategoryListUp(comboBoxCategory.Text);
            keywordName = productManagerModel.KeywordName;
            category = productManagerModel.Category;
        }


        private void btnMonth_Click(object sender, EventArgs e) //���� ��ư
        {
            timeUnit = "month"; //������ ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void btnWeek_Click(object sender, EventArgs e) //�ְ� ��ư
        {
            timeUnit = "week"; //�ֺ��� ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchProductName = txtSearch.Text;
        }

        //---------------------------------------------------------------------------------
        //ī�װ� ���� ��
        private void btnAddCategory_Click(object sender, EventArgs e) //ī�װ� �߰�
        {
            manager.InsertCategory(txtCategory.Text, txtKeywordName.Text);
            manager.CategoryListUp(txtKeywordName.Text);
            comboBoxCategory.Items.Add(txtKeywordName.Text);
            txtCategory.Text = "";
            txtKeywordName.Text = "";
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e) //ī�װ� ����
        {
            manager.DeleteCategory(txtDeleteKeyName.Text);
            manager.CategoryListUp(txtDeleteKeyName.Text);
            comboBoxCategory.Items.Remove(txtDeleteKeyName.Text);
            txtDeleteKeyName.Text = "";
        }


        //---------------------------------------------------------------------------------
        //��ǰ ���� ��
        private void btnAddProduct_Click(object sender, EventArgs e) //��ǰ �߰�
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) //��ǰ ����
        {
            DeleteProduct deleteProduct = new DeleteProduct(this);
            deleteProduct.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e) //��ǰ���� ����
        {
            int rowIndex = ProductGridView.CurrentCell.RowIndex;
            int columnIndex = ProductGridView.CurrentCell.ColumnIndex;
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                string name = ProductGridView.Rows[ProductGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                int order = ProductGridView.CurrentCell.ColumnIndex;
                DataGridViewCell cell = ProductGridView.Rows[rowIndex].Cells[columnIndex];
                manager.UpdateProduct(name, cell.Value, order);
                ProductDataViewLoad();
            }
        }
        public void ProductDataViewLoad() //��ǰ ����Ʈ���̱�
        {
            const string sql = "SELECT name [��ǰ��] , price [����] , stock [���] ,image [�������] , category [ī�װ�] FROM Product";

            using SqlCommand cmd = new(sql, Program.Conn);
            using SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return;

            // ProductGridView �� ������ ����!!

            ProductGridView.DataSource = ds.Tables[0];
            ProductGridView.Columns[0].Width = 90;
            ProductGridView.Columns[3].Width = 200;

            ProductGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductGridView.AllowUserToDeleteRows = false;   // ���� �� ������ ����.

        }

        private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //���� Ŭ���ϸ� �󼼺���
        {
            // ���õ� ���� ���Ե� ���� �̸��� �����ɴϴ�.
            int rowIndex = e.RowIndex;
            if (rowIndex == -1) return;
            string selectedName = ProductGridView.Rows[rowIndex].Cells["��ǰ��"].Value.ToString();

            // ��ǰ ������ �������� SQL ������ �ۼ��մϴ�.
            string selectQuery = $"SELECT * FROM Product WHERE name = '{selectedName}'";

            // �����ͺ��̽����� ��ǰ ������ �����ɴϴ�.
            using SqlCommand cmd = new(selectQuery, Program.Conn);
            using SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds, "Product");

            // ������ ��ǰ ������ DetailProduct ���� �����մϴ�.
            if (ds.Tables["Product"].Rows.Count > 0)
            {
                DataRow row = ds.Tables["Product"].Rows[0];
                string name = row["name"].ToString();
                int price = Convert.ToInt32(row["price"]);
                int stock = Convert.ToInt32(row["stock"]);
                string image = row["image"].ToString();
                string category = row["category"].ToString();
                string detail = row["detail"].ToString();

                DetailProduct detailProduct = new DetailProduct(name, price, stock, image, category, detail);
                detailProduct.ShowDialog();
            }
        }

        //ȸ������
        //-----------------------------------------------------------------------------------------------
        private void DataViewLoad()
        {
            string sql = "SELECT uid [Uid], name [���̵�], phonenum [��ȭ��ȣ], email [���ڿ���] FROM Manager";

            using SqlCommand cmd = new(sql, Program.Conn);
            using SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return;

            // DataGridView �� ������ ����!!
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].ReadOnly = true;  // ù��° �÷��� PK �ϱ�. �����Ұ� �� ����
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // ������ ������ �� ī���Ҹ�ŭ �� ���� 
            dataGridView1.AllowUserToDeleteRows = false;   // ���� �� ������ ����.            
        }
        //----------------------���ΰ�ħ----------------------------------------------//
        private void btn_load_Click(object sender, EventArgs e)
        {
            DataViewLoad();
        }
        private int _uid;

        private void btn_update_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.CurrentCell.RowIndex;
            int uid = int.Parse(dataGridView1.Rows[num].Cells[0].Value.ToString());
            string id = dataGridView1.Rows[num].Cells[1].Value.ToString();
            bool status = false;
            _uid = uid;
            var form = Application.OpenForms["Certification"];

            if (form == null)
            {
                form = new Certification(_uid, id, status);
            }
            form.Show();
        }
       

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.CurrentCell.RowIndex;
            int uid = int.Parse(dataGridView1.Rows[num].Cells[0].Value.ToString());
            string id = dataGridView1.Rows[num].Cells[1].Value.ToString();
            bool status = true;

            _uid = uid;
            var form = Application.OpenForms["Certification"];

            if (form == null)
            {
                form = new Certification(_uid, id,status);
            }
            form.Show();
        }
    }
}