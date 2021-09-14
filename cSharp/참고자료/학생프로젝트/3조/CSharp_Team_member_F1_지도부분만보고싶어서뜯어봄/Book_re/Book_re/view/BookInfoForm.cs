using Newtonsoft.Json.Linq;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Book_re
{
    public partial class BookInfoForm : Form
    {
        string GetTitle;
        List<NBook> books = new List<NBook>();
        public BookInfoForm(string btitle)
        {
            InitializeComponent();
            this.GetTitle = btitle;
            txt_booksearch.Text = GetTitle;
            BookSearch_Api();
        }

        private void bt_booksearch_Click(object sender, EventArgs e)
        {
            BookSearch_Api();
        }

        private void BookSearch_Api()
        {
            
            try
            {
                string results = getResults(); //요청한 결과 반환
                                               //HTML 태그 제거 및 변경
                                               //Console.WriteLine(results);
                results = results.Replace("<b>", "");
                results = results.Replace("</b>", "");
                results = results.Replace("&lt;", "<");
                results = results.Replace("&gt;", ">");
                Console.WriteLine(results);
                var parseJson = JObject.Parse(results);
                var countsOfDisplay = Convert.ToInt32(parseJson["display"]);
                var countsOfResults = Convert.ToInt32(parseJson["total"]);

                //listViewResults.Items.Clear();

                for (int i = 0; i < countsOfDisplay; i++)
                {
                    //ListViewItem item = new ListViewItem((i + 1).ToString());

                    string title = parseJson["items"][i]["title"].ToString();
                    title = title.Replace("&quot;", "\""); //HTML 태그 변경

                    string author = parseJson["items"][i]["author"].ToString();
                    author = author.Replace("&quot;", "\""); //HTML 태그 변경
                    string publisher = parseJson["items"][i]["publisher"].ToString();
                    publisher = publisher.Replace("&quot;", "\""); //HTML 태그 변경
                    string description = parseJson["items"][i]["description"].ToString();
                    description = description.Replace("&quot;", "\""); //HTML 태그 변경
                    string link = parseJson["items"][i]["link"].ToString();
                    string isbn = parseJson["items"][i]["isbn"].ToString();
                    string image = parseJson["items"][i]["image"].ToString();
                    books.Add(new NBook(title, author, publisher, description, link, isbn, image));
                    Console.WriteLine(author + " " + title + " " + publisher + " " + link);
                    pictureBox1.ImageLocation = parseJson["items"][0]["image"].ToString();
                }
                DGV_bookinfo.DataSource = null;
                DGV_bookinfo.DataSource = books;
                DGV_discription.DataSource = null;
                DGV_discription.DataSource = books;
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                Console.WriteLine(exc.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(books[0].link);
        }
        private string getResults()
        {
            string keyword = txt_booksearch.Text;//검색어
            string display = "1";

            string sort = "sim";
            /*if (radioButtonCount.Checked == true)
                sort = "count";*/
            //string d_isbn = "100";
            string query = string.Format("?query={0}&display={1}sort={2}", keyword, display, sort);
            WebRequest request = WebRequest.Create("https://openapi.naver.com/v1/search/book.json" + query); //요청 URL에 쿼리 붙여 보내기
            request.Headers.Add("X-Naver-Client-Id", "IOsfdCl7CosevlzNg8G9"); //자신의 Application ID 입력
            request.Headers.Add("X-Naver-Client-Secret", "vlS257JWD3"); //자신의 Application Secret 입력
            string requestResult = "";
            using (var response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(dataStream))
                    {
                        requestResult = reader.ReadToEnd(); //결과 읽어내기
                    }
                }
            }
            return requestResult;
        }

        private void MakeBook(XmlNode xn)
        {
            throw new NotImplementedException();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DGV_bookinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start(DGV_bookinfo.Rows[0].Cells[3].Value.ToString());
        }


    }
}
