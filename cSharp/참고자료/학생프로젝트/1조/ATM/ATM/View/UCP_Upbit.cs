using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_Upbit : UserControl
    {
        Form1 parentForm;
        public UCP_Upbit(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            DropDownInit();
        }
        //박상준,20210703
        //this.dispose추가(timer때문)
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parentForm.HomePanel();
        }

        async void DropDownInit()
        {
            /*  HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            };
            using (var client = new HttpClient(handler))
            {
                var response = await client.GetAsync("https://api.upbit.com/v1/market/all");
                var responseString = await response.Content.ReadAsStringAsync();
                var json = JArray.Parse(responseString);
                Dictionary<string, string> coins = new Dictionary<string, string>();
                foreach (var coin in json)
                {
                    if (coin["market"].ToString().Contains("KRW")
                        //&& coin["marketState"].ToString() == "ACTIVE")
                        coins.Add(coin["market"].ToString(), coin["korean_name"].ToString());
                }

                comboBox1.DataSource = new BindingSource(coins, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }  */
          
           Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("BTC", "비트코인");
              items.Add("XEM", "NEM");
              items.Add("ETH", "이더리움");
              items.Add("ETC", "이더리움 클래식");
              items.Add("QTUM", "퀀텀");
              items.Add("XRP", "리플");
              items.Add("EMC2", "아인스타이늄");
              items.Add("BCC", "비트코인캐시");
              items.Add("BTG", "비트코인골드");
              items.Add("XMR", "모네로");
              items.Add("LTC", "라이트코인");
              items.Add("DASH", "대시");
              items.Add("OMG", "오미세고");
              items.Add("VTC", "버트코인");
              items.Add("STORJ", "스토리지");
              items.Add("ARK", "아크");
              items.Add("LSK", "리스크");
              items.Add("ADA", "에이다");
              items.Add("SNT", "스테이터스네트워크토큰");
              items.Add("REP", "어거");
              items.Add("XLM", "스텔라루멘");
              items.Add("SBD", "스팀달러");
              items.Add("NEO", "네오");

              comboBox1.DataSource = new BindingSource(items, null);
              comboBox1.DisplayMember = "Value";
              comboBox1.ValueMember = "Key";

            items = new Dictionary<string, string>();
            items.Add("1", "1분");
            items.Add("3", "3분");
            items.Add("5", "5분");
            items.Add("10", "10분");
            items.Add("15", "15분");
            items.Add("30", "30분");
            items.Add("60", "1시간");
            items.Add("240", "4시간");
            items.Add("days", "1일");
            items.Add("weeks", "1주");
            items.Add("months", "1달");

            comboBox2.DataSource = new BindingSource(items, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
            comboBox2.SelectedValue = "days";
        }
        //박상준,20210703
        //버튼 클릭시 타이머 실행
        private void button1_Click(object sender, EventArgs e)
        {
            string time = comboBox2.SelectedValue.ToString();
            int intCheck;
            if (int.TryParse(time, out intCheck))
            {
                if (!timer1.Enabled)
                {
                    timer1.Enabled = true;
                }

                timer1.Interval = 60*1000 * (Convert.ToInt32(time));
                CurrentCoin();
            }
            else
            {
                CurrentCoin();
            }
        }
        //박상준,20210703
        //기존에 완성된 코인 정보를 1초단위 읽어오도로 timer로 옮김
        private async void CurrentCoin()
        {
            string requestUrl;
            int intCheck;
            string coin = comboBox1.SelectedValue.ToString();
            string time = comboBox2.SelectedValue.ToString();

            if (int.TryParse(time, out intCheck))
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/minutes/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            else
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(requestUrl);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var json = JArray.Parse(responseString);

                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(json.ToString());

                    chart1.Series["DateTime"].XValueMember = "candleDateTimeKst";
                    chart1.Series["DateTime"].YValueMembers = "highPrice,lowPrice,openingPrice,tradePrice";
                    chart1.Series["DateTime"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                    chart1.Series["DateTime"].CustomProperties = "PriceDownColor=Blue, PriceUpColor=Red";
                    chart1.Series["DateTime"]["OpenCloseStyle"] = "Triangle";
                    chart1.Series["DateTime"]["ShowOpenClose"] = "Both";
                    chart1.DataManipulator.IsStartFromFirst = true;
                    chart1.DataSource = dt;
                    chart1.DataBind();
                }
                catch
                {
                    MessageBox.Show("다른 코인 선택");
                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentCoin();
        }

        private void UCP_Upbit_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }
    }
}