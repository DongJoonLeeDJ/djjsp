using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = File.ReadAllText("Students.json");
            JObject jsonObjectStudent = JObject.Parse(source);

            dataGridView1.Columns.Add("name", "이름");
            dataGridView1.Columns.Add("age", "나이");
            dataGridView1.Columns.Add("hakbeon", "학번");

            dataGridView1.DataSource = null;

            foreach (var item in jsonObjectStudent["students"]["student"])
            {
                dataGridView1.Rows.Add(
                    item["name"].ToString(), 
                    item["age"].ToString(), 
                    item["hakbeon"].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=980

            //960회차부터 현재까지 불러와보겠습니다.

            int count = 960;
            List<Lotto> lottos = new List<Lotto>();
            while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    var json= wc.DownloadString
                        ("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count);
                    count++;
                    var jArray = JObject.Parse(json);

                    if(jArray["returnValue"].ToString() == "fail")
                    {
                        break;
                    }
                    lottos.Add(new Lotto(jArray["drwtNo1"].ToString(), jArray["drwtNo2"].ToString(), jArray["drwtNo3"].ToString(), jArray["drwtNo4"].ToString(), jArray["drwtNo5"].ToString(), jArray["drwtNo6"].ToString(), jArray["bnusNo"].ToString(), jArray["drwNo"].ToString(), jArray["drwNoDate"].ToString()));
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
