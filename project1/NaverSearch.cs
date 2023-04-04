using System;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project1
{
    internal class NaverSearch
    {
        public string naver(string cateagory, string startDate, string endDate, string gender, string age, string timeUnit,string keywordName,string productName)
        {
            Form1 form1 = new Form1();

            const string ClientId = "VtMF3sZjkx3ZpUODF_Zi"; //네이버 api 아이디
            const string ClientSECRET = "M4XgPPJUUX";       //네이버 api 비번

            //string url = "https://openapi.naver.com/v1/datalab/search";
            const string url = "https://openapi.naver.com/v1/datalab/shopping/categories";
            const string keywordUrl = "https://openapi.naver.com/v1/datalab/shopping/category/keywords";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(keywordUrl);
            request.Headers.Add("X-Naver-Client-Id", ClientId);
            request.Headers.Add("X-Naver-Client-Secret", ClientSECRET);
            request.ContentType = "application/json";
            request.Method = "POST";
           

            string body1 = $"{{\"startDate\":\"{startDate}\"," +
                           $"\"endDate\":\"{endDate}\"," +
                           $"\"timeUnit\":\"{timeUnit}\"," +
                           $"\"category\":\"{cateagory}\"," +
                           $"\"keyword\":[{{\"name\":\"{keywordName}\",\"param\":[\"{productName}\"]}}]," +
                           $"\"device\":\"pc\"," +
                           $"\"ages\":[\"{age}\"]," +
                           $"\"gender\":\"{gender}\"}}";


            string body = $"{{\"startDate\":\"{startDate}\"," +
                          $"\"endDate\":\"{endDate}\"," +
                          $"\"timeUnit\":\"{timeUnit}\"," +
                          $"\"category\":[{{{cateagory}}}]," +
                          $"\"device\":\"pc\"," +
                          $"\"ages\":[\"{age}\"]," +
                          $"\"gender\":\"{gender}\"}}";


            byte[] byteDataParams = Encoding.UTF8.GetBytes(body1);
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();

            return (text);

        }
    }
}
