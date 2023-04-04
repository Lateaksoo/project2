using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Manager
    {
        const string InsertSql = "INSERT INTO products (category, keyword_name) VALUES (@category, @keywordName)";
        const string checkSql = "SELECT COUNT(*) FROM products WHERE category = @category AND keyword_name = @keywordName";
        public void InsertCategory(string category,string keywordName)
        {
            // 중복 값을 체크
            using SqlCommand checkDuplicateCmd = new(checkSql, Login.conn);
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
                using SqlCommand cmd = new(InsertSql, Login.conn);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@keywordName", keywordName);
                cmd.ExecuteNonQuery();
            }
        }
    
    
    }
}
