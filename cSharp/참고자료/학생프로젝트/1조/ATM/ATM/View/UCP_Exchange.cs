using ATM.Model;
using ATM.Panel;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    //박상준,박소윤, 20210703
    //외화거래에 대한 패널입니다.
    public partial class UCP_Exchange : UserControl
    {
        //(타입) AP01 : 환율, AP02 : 대출금리, AP03 : 국제금리
        //(요청예시) https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey=AUTHKEY1234567890&searchdate=20180102&data=AP01
        //주소+인증키+날짜+타입
        //(반환값 확인용 사이트)https://www.koreaexim.go.kr/site/program/openapi/openApiView?menuid=001003002002001&apino=2&viewtype=C
        //string url = "https://www.koreaexim.go.kr/site/program/financial/exchangeJSON";
        //받아오는 api 반환값 예시
        /*"result":1,
        "cur_unit":"AED",
        "ttb":"288.78",
        "tts":"294.61",
        "deal_bas_r":"291.7",
        "bkpr":"291",
        "yy_efee_r":"0",
        "ten_dd_efee_r":"0",
        "kftc_bkpr":"291",
        "kftc_deal_bas_r":"291.7",
        "cur_nm":"아랍에미리트 디르함"*/
        
        //api에 사용하는 인증키
        string mykey = "hKSdbCbx9x9G7ynyLP8yxL7z0t9Gwl2c";

        List<ExchangeRate> exchanges = new List<ExchangeRate>();
        Form1 parentForm;
        public UCP_Exchange(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }
        //박상준,20210624
        //당일 환율 api정보를 가져와서 데이터 그리드뷰에 출력(버튼)
        //박상준,20210627
        //환율api 정보를 당일 날짜를 기준으로 불러오는것으로 만들었으나, 주말에는 값을 null로 가져오는것을 확인
        public void CurrentExchangeRate()
        {

            using (WebClient wc = new WebClient())
            {
                //박상준,20210624
                //가끔 api로 json읽어올때 한글 깨지는 경우가 있어서 Encoding 문제 발생->해결
                wc.Encoding = System.Text.Encoding.UTF8; 
                var json = wc.DownloadString("https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey=" + mykey + "&searchdate=" + DateTime.Now.ToString("yyyyMMdd") + "&data=AP01");
                var objs = JArray.Parse(json).ToObject<List<JObject>>();
                string price = "";
                string name = "";
                string country = "";
                dataGridView1.DataSource = null;
                exchanges.Clear();
                for (int i = 0; i < objs.Count; i++)
                {
                    country = objs[i]["cur_nm"].ToString().Trim().Replace(",", "");
                    name = objs[i]["cur_unit"].ToString().Trim().Replace(",", "");
                    price = objs[i]["kftc_deal_bas_r"].ToString().Trim().Replace(",", "");
                    ExchangeRate temp = new ExchangeRate(country, name, price);
                    exchanges.Add(temp);
                }
                dataGridView1.DataSource = exchanges;
            }
        }

        //박상준,20210629
        //UCP_Homepanel로 이동
        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }
        //박상준,20210627
        //api로 환율 정보 읽어오는 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            CurrentExchangeRate();
        }

        private void button_mycurrency_Click(object sender, EventArgs e)
        {
            UCP_Mycurrency ucpanel_mycurrency = new UCP_Mycurrency(parentForm);
            parentForm.controllView(ucpanel_mycurrency);
        }
        //박상준,20210629
        //숫자와 백스페이스만 입력받는 기능
        private void textBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }

            if (textBox_amount.TextLength == 0 && e.KeyChar == Convert.ToChar(Keys.D0))
            {
                e.Handled = true;
            }
        }
        //박상준.20210629
        //텍스트 박스에 수량 입력시 환전할 금액 변경
        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            if (textBox_amount.Text == "")
            {
                label_totalPrice.Text = "0";
            }
            else
            {
                label_totalPrice.Text = (Convert.ToDouble(textBox_amount.Text) * Convert.ToDouble(label_price.Text)).ToString("#,#");
                //label_totalPrice.Text += " 원";
                label5_won.Text = "원";
            }
        }

        //박상준,20210628
        //환전 기능, 계좌 잔액을 가져와 환전 가능한지를 파악하고 가능하면 exchange()로 넘어감
        private void button3_Click(object sender, EventArgs e)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            double result = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //
                string sql = "SELECT balance FROM account where acc_num = '" + parentForm.getUserAccount() + "';";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = Convert.ToDouble(rdr["balance"].ToString()) - Convert.ToDouble(label_totalPrice.Text); //총 금액(=trans_price)
                    if (result < 0)
                    {
                        MessageBox.Show("잔액이 부족합니다");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("거래가 완료되었습니다.");
                        exchange(result);
                        parentForm.HomePanel();
                    }
                }
                rdr.Close();
            }
        }
        //박상준,20210629
        //계좌 잔액을 업데이트 하고, 이미 구매한 화폐가 있다면 update로 수량을, 없다면 insert로 exchange테이블에 추가한다.
        //박소윤,20210629
        //거래가 진행되면 DB 내 transaction 테이블에 거래내역 기록 & coin 테이블에 보유 외화 저장 => 트리거로 DB 3개 연동.
        public void exchange(double result)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql2 = "insert transaction(trans_date, in_acc, in_bank, in_name, out_acc, out_bank, out_name, out_balance, trans_price, trans_type) " +
                    "values (now(), '00000', '외환거래소', '외환거래소', '" + parentForm.getUserAccount() + "','" + parentForm.getBank() + "','" + parentForm.getName() + "'," + result +"," + Convert.ToDouble(label_totalPrice.Text) + ",'exchange')";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql2, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                string sql = "SELECT count(*) as cnt FROM exchange where acc_num = '" + parentForm.getUserAccount() + "' and country = '" + label_country.Text + "'; ";
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                int count = Convert.ToInt32(rdr["cnt"]);
                if (count == 0)
                {
                    sql = "INSERT INTO exchange(acc_num,country,currency,amount) VALUES( '" + parentForm.getUserAccount() + "','" + label_country.Text + "','" + label_currency.Text + "'," + textBox_amount.Text + "); ";
                }
                else
                {
                    sql = "update exchange set amount = amount+" + textBox_amount.Text + " where acc_num = '" + parentForm.getUserAccount() + "' and currency = '" + label_currency.Text + "';";
                }
                rdr.Close();
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
        }

        //박상준,20210629
        //데이터 그리드뷰 클릭하면 정보 출력
        //안재혁,20210701
        //데이터그리드뷰 header 클릭시 rowindex범위를 벗어나는 오류 수정
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label_totalPrice.Text = "";
                textBox_amount.Text = "";
                label_country.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_currency.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                label_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }


}