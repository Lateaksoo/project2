using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using Newtonsoft.Json;

namespace project1
{
    internal class Manager
    {
        private readonly ProductManagerModel _productManagerModel;
        public Manager(ProductManagerModel productManagerModel)
        {
            _productManagerModel = productManagerModel;
        }

        // 현재 실행 파일이 있는 디렉토리 경로
        public string baseDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        #region SQL queries
        //카테고리 관련
        //---------------------------------------------------------------------------------------
        //카테고리 추가 sql
        const string CategoryInsertSql = "INSERT INTO category (category, keyword_name) VALUES (@category, @keywordName)";
        //카테고리 삭제 sql
        const string CategoryDeleteSql = "DELETE FROM category WHERE keyword_name = @keywordName";
        //카테고리 검사 sql
        const string CategoryCheckSql = "SELECT COUNT(*) FROM category WHERE category = @category AND keyword_name = @keywordName";
        //카테고리 가져오기 sql
        const string CategorySelectSql = "SELECT category, keyword_name FROM category WHERE keyword_name = @keywordName";
        //콤보박스에 카테고리 넣기 sql
        const string comboBoxSql = "SELECT DISTINCT keyword_name , category FROM category";

        //상품 관련
        //---------------------------------------------------------------------------------------
        //상품 추가 sql
        const string ProductInsertSql = "INSERT INTO Product (name, price, stock, image, category ,detail) VALUES (@name, @price, @stock, @image, @category , @detail)";
        //상품 중복 검사 sql
        const string ProductCheckSql = "SELECT COUNT(*) FROM Product WHERE name = @name";
        //상품 삭제 sql
        const string ProductDeleteSql = "DELETE FROM Product WHERE name = @name and category = @category";
        #endregion

        //카테고리 관련
        //---------------------------------------------------------------------------------------
        public void InsertCategory(string category, string keywordName) //카테고리 추가
        {
            // 중복 값을 체크
            using SqlCommand checkCmd = new(CategoryCheckSql, Program.Conn);
            checkCmd.Parameters.AddWithValue("@category", category);
            checkCmd.Parameters.AddWithValue("@keywordName", keywordName);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                // 중복 값이 존재하는 경우
                MessageBox.Show("이미 존재하는 카테고리 입니다.");
            }
            else
            {
                // 중복 값이 존재하지 않는 경우, 데이터베이스에 새로운 값을 추가
                using SqlCommand cmd = new(CategoryInsertSql, Program.Conn);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@keywordName", keywordName);
                cmd.ExecuteNonQuery();
                MessageBox.Show("추가 완료");
                CategoryListUp(keywordName);
            }
        }

        public void CategoryListUp(string keywordName) //카테고리 가져오기
        {
            using SqlCommand cmd = new SqlCommand(CategorySelectSql, Program.Conn);
            cmd.Parameters.AddWithValue("@keywordName", keywordName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string resultcategory = reader.GetString(0);
                    string resultkeywordName = reader.GetString(1);
                    _productManagerModel.Category = resultcategory;
                    _productManagerModel.KeywordName = resultkeywordName;

                }
            }
            reader.Close();
        }

        public void DeleteCategory(string keywordName) //카테고리 삭제하기
        {
            if (string.IsNullOrWhiteSpace(keywordName))
            {
                MessageBox.Show("키워드 이름을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlCommand cmd = new SqlCommand(CategoryDeleteSql, Program.Conn))
            {
                cmd.Parameters.AddWithValue("@keywordName", keywordName);

                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("삭제할 데이터가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("데이터가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CategoryListUp(keywordName);
                }
            }
        }
        public DataTable GetCategoryComboBox() //카테고리 데이터를 데이터테이블로 반환하기
        {
            // 테이블에서 카테고리를 가져와서 DataTable로 반환함
            using (SqlCommand cmd = new SqlCommand(comboBoxSql, Program.Conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        //---------------------------------------------------------------------------------------

        public void CreateChart(Chart chart, string chartTitle, dynamic result) //차트 만들기
        {
            List<double> ratios = new List<double>();
            foreach (var data in result.results[0].data)
            {
                ratios.Add((double)data.ratio);
            }

            Series series = chart.Series.Add(chartTitle);
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ratios.Count; i++)
            {
                series.Points.AddXY(i + 1, ratios[i]);
            }
        }



        //상품 관련
        //---------------------------------------------------------------------------------------
        public void AddProduct(string name, string price, string stock, string image, string category, string detail)
        {
            using SqlCommand checkCmd = new SqlCommand(ProductCheckSql, Program.Conn);
            checkCmd.Parameters.AddWithValue("@name", name);
            int count = (int)checkCmd.ExecuteScalar();


            if (count > 0)
            {
                // 중복 값이 존재하는 경우
                string ProductUpdateSql = "UPDATE product SET stock = stock + @stock WHERE name = @name";
                using SqlCommand commandUpdate = new SqlCommand(ProductUpdateSql, Program.Conn);
                commandUpdate.Parameters.AddWithValue("@name", name);
                commandUpdate.Parameters.AddWithValue("@stock", int.Parse(stock));
                commandUpdate.ExecuteNonQuery();
                MessageBox.Show("재고 추가 완료.");
            }
            else
            {
                using SqlCommand commandInsert = new SqlCommand(ProductInsertSql, Program.Conn);
                commandInsert.Parameters.AddWithValue("@name", name);
                commandInsert.Parameters.AddWithValue("@price", int.Parse(price));
                commandInsert.Parameters.AddWithValue("@stock", int.Parse(stock));
                commandInsert.Parameters.AddWithValue("@image", image);
                commandInsert.Parameters.AddWithValue("@category", category);
                commandInsert.Parameters.AddWithValue("@detail", detail);
                commandInsert.ExecuteNonQuery();
                MessageBox.Show("추가 완료.");
            }

        } //상품 추가
        public bool DeleteProduct(string name, string category) //상품 삭제 성공 여부 반환
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("상품을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            using (SqlCommand cmd = new SqlCommand(ProductDeleteSql, Program.Conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("삭제할 데이터가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("데이터가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
        }

        public void UpdateProduct(string originName, string name, string price, string stock, string image, string category, string detail) //디테일에서 상품정보 수정하기
        {
            string sql = $"UPDATE Product SET name = @Name, price = @Price, stock = @stock, image = @Image, category = @category, detail = @detail WHERE name = @OriginName";
            SqlCommand cmdUpdate = new SqlCommand(sql, Program.Conn);
            cmdUpdate.Parameters.AddWithValue("@OriginName", originName);
            cmdUpdate.Parameters.AddWithValue("@name", name);
            cmdUpdate.Parameters.AddWithValue("@price", price);
            cmdUpdate.Parameters.AddWithValue("@stock", stock);
            cmdUpdate.Parameters.AddWithValue("@image", image);
            cmdUpdate.Parameters.AddWithValue("@category", category);
            cmdUpdate.Parameters.AddWithValue("@detail", detail);
            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("수정 완료");
        }

        public string FindInamge() //사진 찾기
        {
            //파일 선택창에서 사진 선택
            OpenFileDialog openFileDialog1;
            openFileDialog1 = new OpenFileDialog();
            string filepath = "";

            // 이미지 파일 필터 설정
            openFileDialog1.Filter = "이미지 파일(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //사진 경로 가져오기 --> 경로 반환
                filepath = openFileDialog1.FileName;   // 선택한 파일의 전체경로
            }
            // 취소누르면 선택안되게 함
            return filepath;
        }

        //------------------------------------------json-----------------------------------------

        //------------------------------------------저장하기-------------------------------
        private DataTable GetCategoryTable()//카테고리 정보 데이터테이블로 가져오기
        {
            string query = "SELECT * FROM category";
            using SqlCommand cmd = new(query, Program.Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new();   // DataTable 객체 생성
            adapter.Fill(table);  // SqlDataAdapter를 사용하여 DataTable 객체 채우기
            return table;
        }

        private DataTable GetManagerTable() //메니저 정보 데이터테이블로 가져오기
        {
            string query = "SELECT * FROM Manager";
            using SqlCommand cmd = new(query, Program.Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new();   // DataTable 객체 생성
            adapter.Fill(table);  // SqlDataAdapter를 사용하여 DataTable 객체 채우기
            return table;
        }

        private DataTable GetProductTable() //상품정보 데이터테이블로 가져오기
        {
            string query = "SELECT * FROM Product";
            using SqlCommand cmd = new(query, Program.Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new();   // DataTable 객체 생성
            adapter.Fill(table);  // SqlDataAdapter를 사용하여 DataTable 객체 채우기
            return table;
        }


        public void SaveTableToJson() //json 으로 저장하기 
        {
            //테이블 정보 가져오기
            DataTable productTable = GetProductTable();   //상품테이블
            DataTable managerTable = GetManagerTable();   //메니저테이블
            DataTable categoryTable = GetCategoryTable(); //카테고리 테이블 

            //DataTable 객체를 JSON 문자열로 변환
            string productJson = JsonConvert.SerializeObject(productTable, Formatting.Indented);
            string managerJson = JsonConvert.SerializeObject(managerTable, Formatting.Indented);
            string categoryJson = JsonConvert.SerializeObject(categoryTable, Formatting.Indented);

            // 경로에서 상위 디렉토리를 추출할 횟수
            int count = 3;

            // 경로에서 필요한 부분만 추출
            for (int i = 0; i < count; i++)
            {
                baseDirectory = Path.GetDirectoryName(baseDirectory);
            }
            string JsonFilePath = Path.Combine(baseDirectory, "TableJson"); //TableJson 폴더로 경로 지정

            if (File.Exists(JsonFilePath)) //만약 폴더에 기존 파일이 있다면 삭제하고
            {
                File.Delete(JsonFilePath);
            }

            //파일 저장하기
            File.WriteAllText(Path.Combine(JsonFilePath, "product.json"), productJson);
            File.WriteAllText(Path.Combine(JsonFilePath, "manager.json"), managerJson);
            File.WriteAllText(Path.Combine(JsonFilePath, "category.json"), categoryJson);

        }


        //-----------------------------------읽어오기-------------------------------------------

        private void ReadProductJson()
        {
            int count = 3;
            for (int i = 0; i < count; i++)
            {
                baseDirectory = Path.GetDirectoryName(baseDirectory);
            }
            //파일 경로 설정
            string productJsonPath = Path.Combine(baseDirectory, "TableJson", "product.json");
            string managerJsonPath = Path.Combine(baseDirectory, "TableJson", "manager.json");
            string categoryJsonPath = Path.Combine(baseDirectory, "TableJson", "category.json");

            //파일 문자열로 읽어오기
            string productJson = File.ReadAllText(productJsonPath);
            string managerJson = File.ReadAllText(managerJsonPath);
            string categoryJson = File.ReadAllText(categoryJsonPath);

            //읽어온걸 테이블로 변환하기
            DataTable productTable = JsonConvert.DeserializeObject<DataTable>(productJson);
            DataTable managerTable = JsonConvert.DeserializeObject<DataTable>(managerJson);
            DataTable categoryTable = JsonConvert.DeserializeObject<DataTable>(categoryJson);

            //기존 테이블 정보 삭제하기
            using SqlCommand cmd = new("TRUNCATE TABLE product; TRUNCATE TABLE Manager; TRUNCATE TABLE category;", Program.Conn);
            cmd.ExecuteNonQuery();

            //테이블에 불러온 정보 저장하기
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Program.Conn))
            {
                bulkCopy.DestinationTableName = "product";
                bulkCopy.WriteToServer(productTable);
                bulkCopy.DestinationTableName = "Manager";
                bulkCopy.WriteToServer(managerTable);
                bulkCopy.DestinationTableName = "category";
                bulkCopy.WriteToServer(categoryTable);

            }

        }



    }//end class
}
