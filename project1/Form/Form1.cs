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
            ProductDataViewLoad();
            DataTable categoryTable = manager.GetCategoryComboBox();
            // 콤보박스에 카테고리를 추가함
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //기본으로 선택되어 있는 값
            comboBoxCategory.SelectedIndex = 0;
            timeUnit = "month";
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
        }

        //---------------------------------------------------------------------------------
        //판매 트렌드 탭
        private void btnSearch_Click(object sender, EventArgs e) //조회 버튼 
        {
            bool isAnyChecked = false; // 체크박스가 한 개 이상 체크되었는지 확인하는 변수
            CheckBox[] checkBoxes = { check10, check20, check30, check40, check50, check60 };
            age = "";
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked) //체크된 값들을 문자열로 만들기 
                {
                    age += $"{checkBox.Text.Replace("대", "")}\",\"";
                    isAnyChecked = true;
                }
            }
            if (age.EndsWith("\",\"")) //마지막에는 \",\"를 지워줘야 한다.
            {
                age = age.Remove(age.Length - 3);
            }
            if (!isAnyChecked) // 체크박스가 한 개 이상 체크되지 않았을 경우
            {
                MessageBox.Show("연령대를 선택해주세요.");
                return; // 메소드 실행 중지
            }

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}성\n {age}대\n, 검색 비율", result);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) //시작일
        {
            startDate = "";  //시작일을 초기화해줌
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e) //종료일
        {
            endDate = "";  //종료일을 초기화해줌
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e) //성별 콤보박스
        {
            gender = ""; //성별 고르기
            switch (comboBoxSex.Text)
            {
                case "남": gender = "m"; break;
                case "여": gender = "f"; break;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) //카테고리 콤보박스
        {
            manager.CategoryListUp(comboBoxCategory.Text);
            keywordName = productManagerModel.KeywordName;
            category = productManagerModel.Category;
        }


        private void btnMonth_Click(object sender, EventArgs e) //월간 버튼
        {
            timeUnit = "month"; //월별로 설정

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}성\n {age}대\n, 검색 비율", result);

        }

        private void btnWeek_Click(object sender, EventArgs e) //주간 버튼
        {
            timeUnit = "week"; //주별로 설정

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, searchProductName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}성\n {age}대\n, 검색 비율", result);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchProductName = txtSearch.Text;
        }

        //---------------------------------------------------------------------------------
        //카테고리 관리 탭
        private void btnAddCategory_Click(object sender, EventArgs e) //카테고리 추가
        {
            manager.InsertCategory(txtCategory.Text, txtKeywordName.Text);
            manager.CategoryListUp(txtKeywordName.Text);
            comboBoxCategory.Items.Add(txtKeywordName.Text);
            txtCategory.Text = "";
            txtKeywordName.Text = "";
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e) //카테고리 삭제
        {
            manager.DeleteCategory(txtDeleteKeyName.Text);
            manager.CategoryListUp(txtDeleteKeyName.Text);
            comboBoxCategory.Items.Remove(txtDeleteKeyName.Text);
            txtDeleteKeyName.Text = "";
        }


        //---------------------------------------------------------------------------------
        //상품 관리 탭
        private void btnAddProduct_Click(object sender, EventArgs e) //상품 추가
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) //상품 삭제
        {
            DeleteProduct deleteProduct = new DeleteProduct(this);
            deleteProduct.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e) //상품정보 수정
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
        public void ProductDataViewLoad() //상품 리스트보이기
        {
            const string sql = "SELECT name [상품명] , price [가격] , stock [재고] ,image [사진경로] , category [카테고리] FROM Product";

            using SqlCommand cmd = new(sql, Program.Conn);
            using SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return;

            // DataGridView 에 데이터 연결!!
            ProductGridView.DataSource = ds.Tables[0];
            ProductGridView.Columns[0].Width = 90;
            ProductGridView.Columns[3].Width = 200;

            ProductGridView.RowTemplate.Height = 100;

            ProductGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // 나머지 여백을 다 카바할만큼 폭 차지 
            ProductGridView.AllowUserToDeleteRows = false;   // 직접 행 삭제는 차단.

            //사진을 표시할 행 추가
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.HeaderText = "사진";
            imageCol.Name = "imageCol";
            ProductGridView.Columns.Add(imageCol);
            imageCol.Image = new Bitmap(1, 1); // 빈 비트맵 생성
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // 이미지 레이아웃 설정
            ProductGridView.Columns[5].ReadOnly = true; // 사진은 읽기전용
            ProductGridView.Columns[5].Width = 100;
            
        }
      

        private void ProductGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ProductGridView.Columns[e.ColumnIndex].Name == "imageCol" )
            {
                if (ProductGridView.Rows[e.RowIndex].Cells[3].Value == null) return;
                string imagePath = ProductGridView.Rows[e.RowIndex].Cells[3].Value.ToString(); // 이미지 경로가 있는 열의 인덱스는 3입니다.
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        Image image = Image.FromFile(imagePath);
                        e.Value = image;
                        e.FormattingApplied = true;
                    }
                    catch (Exception ex)
                    {
                        // 이미지 로드에 실패한 경우, 적절한 처리를 수행합니다.
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        
    }//end class
}