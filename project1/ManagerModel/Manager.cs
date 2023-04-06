﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        const string comboBoxSql = "SELECT DISTINCT keyword_name FROM category";

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

        public void UpdateProduct(string name, object value, int order) //상품 수정
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.Conn;
            order = order + 2; //uid가 첫번째에 있어서 2를 더함
            // 선택된 셀의 열 이름 구하기
            cmd.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Product' AND ORDINAL_POSITION = @order";
            cmd.Parameters.AddWithValue("@order", order);

            string columnName = cmd.ExecuteScalar().ToString();

            //셀 업데이트 하기
            cmd.CommandText = $"UPDATE Product SET [{columnName}] = @value WHERE name = @name";
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            MessageBox.Show("수정완료.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateProduct2(string originName ,string name, string price, string stock, string image, string category, string detail)
        {
            string selectsql = "SELECT * FROM Product WHERE name = @name";

            using SqlCommand cmd = new SqlCommand(selectsql, Program.Conn);
            cmd.Parameters.AddWithValue("@name", originName);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
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
            }
        }

    }//end class
}