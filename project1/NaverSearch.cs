using System;
using System.IO;
using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project1
{
    internal class NaverSearch
    {
        public string naver(string search, string startDate, string endDate, string gender, string age)
        {
            Form1 form1 = new Form1();

            const string ClientId = "VtMF3sZjkx3ZpUODF_Zi"; //네이버 api 아이디
            const string ClientSECRET = "M4XgPPJUUX";       //네이버 api 비번

            //string url = "https://openapi.naver.com/v1/datalab/search";
            string url = "https://openapi.naver.com/v1/datalab/shopping/categories";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", ClientId);
            request.Headers.Add("X-Naver-Client-Secret", ClientSECRET);
            request.ContentType = "application/json";
            request.Method = "POST";


            string body = $"{{\"startDate\":\"{startDate}\"," +
                          $"\"endDate\":\"{endDate}\"," +
                          $"\"timeUnit\":\"month\"," +
                          $"\"category\":[{{{search}}}]," +
                          $"\"device\":\"pc\"," +
                          $"\"ages\":[\"{age}\"]," +
                          $"\"gender\":\"{gender}\"}}";


            byte[] byteDataParams = Encoding.UTF8.GetBytes(body);
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
