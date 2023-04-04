using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace project1
{
    internal class Manager
    {
        private readonly ProductManagerModel _productManagerModel;
        public Manager(ProductManagerModel productManagerModel)
        {
            _productManagerModel = productManagerModel;
        }

        //카테고리 추가 sql
        const string InsertSql = "INSERT INTO products (category, keyword_name) VALUES (@category, @keywordName)";
        //카테고리 삭제 sql
        const string DeleteSql = "DELETE FROM products WHERE keyword_name = @keywordName";
        //카테고리 검사 sql
        const string checkSql = "SELECT COUNT(*) FROM products WHERE category = @category AND keyword_name = @keywordName";
        //카테고리 가져오기 sql
        const string selectSql = "SELECT category, keyword_name FROM products WHERE keyword_name = @keywordName";
        //콤보박스에 카테고리 넣기 sql
        const string comboBoxSql = "SELECT DISTINCT keyword_name FROM products";
        public void InsertCategory(string category, string keywordName) //카테고리 추가
        {
            // 중복 값을 체크
            using SqlCommand checkDuplicateCmd = new(checkSql, Program.Conn);
            checkDuplicateCmd.Parameters.AddWithValue("@category", category);
            checkDuplicateCmd.Parameters.AddWithValue("@keywordName", keywordName);
            int count = (int)checkDuplicateCmd.ExecuteScalar();

            if (count > 0)
            {
                // 중복 값이 존재하는 경우
                MessageBox.Show("이미 존재하는 값입니다. 다시 입력해주세요.");
            }
            else
            {
                // 중복 값이 존재하지 않는 경우, 데이터베이스에 새로운 값을 추가
                using SqlCommand cmd = new(InsertSql, Program.Conn);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@keywordName", keywordName);
                cmd.ExecuteNonQuery();
            }
        }

        public void CategoryListUp(string keywordName) //카테고리 가져오기
        {
            using SqlCommand cmd = new SqlCommand(selectSql, Program.Conn);
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

        public void DeleteCategory(string keywordName)
        {
            if (string.IsNullOrWhiteSpace(keywordName))
            {
                MessageBox.Show("키워드 이름을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlCommand cmd = new SqlCommand(DeleteSql, Program.Conn))
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
                }
            }
        }
        public DataTable GetCategoryComboBox() //카테고리 콤보박스에 넣기
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


    }//end class
}
