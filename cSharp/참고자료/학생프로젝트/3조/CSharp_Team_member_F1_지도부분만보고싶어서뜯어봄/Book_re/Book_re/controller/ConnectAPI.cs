//using System;
//using System.Net;
//using System.Text;
//using System.IO;

//namespace Book_re
//{
//    public class APIExamSearchBook
//    {
//        static void Main(string[] args)
//        {
//            string query = txt_booksearch.Text; // 검색할 문자열
//            string url = "	https://openapi.naver.com/v1/search/book_adv.xml?query=" + query; 
//            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//            request.Headers.Add("X-Naver-Client-Id", "l87hDaOsW43gnG4tEuHr"); // 클라이언트 아이디
//            request.Headers.Add("X-Naver-Client-Secret", "hbrV0_tmzo");       // 클라이언트 시크릿
//            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//            string status = response.StatusCode.ToString();
//            if (status == "OK")
//            {
//                Stream stream = response.GetResponseStream();
//                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
//                string text = reader.ReadToEnd();
//                Console.WriteLine(text);
//            }
//            else
//            {
//                Console.WriteLine("Error 발생=" + status);
//            }
//        }
//    }
//}