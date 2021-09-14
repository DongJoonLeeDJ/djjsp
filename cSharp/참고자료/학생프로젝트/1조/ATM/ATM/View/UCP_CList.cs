using ATM.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_CList : UserControl
    {
        List<CPrice> cprice = new List<CPrice>();
        Form1 parentForm;
        public UCP_CList(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            dataGridView1.DataSource = null;
            dataGridView1.DoubleBuffered(true);
        }
        void coins()
        {

            using (WebClient wc = new WebClient())
            {

                wc.Encoding = System.Text.Encoding.UTF8;

                var json1 = wc.DownloadString("https://api.upbit.com/v1/market/all");
                var objs1 = JArray.Parse(json1).ToObject<List<JObject>>();

                /* var coin = objs["market"];*/
                string market = "";
                string korean_name = "";
                string trade_price = "";
        
                cprice.Clear();

                /*korean_name = objs1[0]["korean_name"].ToString().Trim().Replace(",", "");
                market = objs1[0]["market"].ToString().Trim().Replace(",", "");*/
                for (int i = 0; i < objs1.Count; i++)
                {
                    if (objs1[i]["market"].ToString().Substring(0, 3) == "KRW")

                    //if (objs1[i]["market"].ToString().Contains("KRW"))
                    {
                        korean_name += objs1[i]["korean_name"].ToString().Trim().Replace(",", "") + ",";
                        market += objs1[i]["market"].ToString().Trim().Replace(",", "") + ",";
                    }
                 }
                korean_name = korean_name.Substring(0, korean_name.Length - 1);
                market = market.Substring(0, market.Length - 1);
                var json2 = wc.DownloadString("https://api.upbit.com/v1/ticker?markets=" + market);
                var objs2 = JArray.Parse(json2).ToObject<List<JObject>>();
                trade_price = objs2[0]["trade_price"].ToString().Trim().Replace(",", "");

                for (int i = 1; i < objs2.Count; i++)
                {
                    trade_price += "," + objs2[i]["trade_price"].ToString().Trim().Replace(",", "");
                }
                string[] temp1 = korean_name.Split(',');
                string[] temp2 = market.Split(',');
                string[] temp3 = trade_price.Split(',');
                /*   double changeRate = Math.Round(objs1[int.Parse("signed_change_rate")].Value<double>() * 100, 2);
                   string changeRateText = $"{changeRate}%";
                   Console.WriteLine(changeRate);*/

                for (int i = 0; i < temp1.Length; i++)
                {
                    cprice.Add(new CPrice(temp2[i], temp1[i], temp3[i]));
                }
            }
            dataGridView1.DataSource = cprice;
            dataGridView1.Refresh();
        }
        public void Clable(double result)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql2 = "insert transaction(trans_date, in_acc, in_bank, in_name, out_acc, out_bank, out_name, out_balance, trans_price, trans_type) " +
                    "values (now(), '00001', 'UPBIT','" + label_name.Text+"','" + parentForm.getUserAccount() + "','" + parentForm.getBank() + "','" + parentForm.getName() + "'," + result + "," + Convert.ToDouble(label_totalPrice.Text) + ",'coin')";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql2, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                string sql = "SELECT count(*) as cnt FROM coin where acc_num = '" + parentForm.getUserAccount() + "' and coin_name = '" + label_name.Text + "'; ";
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                sql = "INSERT INTO coin(acc_num,coin_name,amount,price,date) VALUES( '" + parentForm.getUserAccount() + "','" + label_name.Text + "','" + textBox1.Text + "'," + label_price.Text + ",now()); ";
                rdr.Close();
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                rdr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_upbit_Click(object sender, EventArgs e)
        {
            UCP_Upbit ub = new UCP_Upbit(parentForm);
            parentForm.controllView(ub);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coins();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            label_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = "";
                //label_totalPrice.Text = "";
            }
        }
            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }

            if (textBox1.TextLength == 0 && e.KeyChar == Convert.ToChar(Keys.D0))
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label_totalPrice.Text = "0";
            }
            else
            {
                label_totalPrice.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(label_price.Text)).ToString();
            }
        }

        private void 거래_Click(object sender, EventArgs e)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            double result = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT balance FROM account where acc_num = '" + parentForm.getUserAccount() + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = Convert.ToDouble(rdr["balance"]) - Convert.ToDouble(label_totalPrice.Text); //총 금액(=trans_price)
                    if (result < 0)
                    {
                        MessageBox.Show("잔액이 부족합니다");
                        break;
                    }
                    else
                    {
                        Clable(result);
                        MessageBox.Show("거래가 완료되었습니다.");
                        UCP_MyCoin mycoin = new UCP_MyCoin(parentForm);
                        parentForm.controllView(mycoin);                        
                    }
                }
                rdr.Close();
            }
        }

        //박상준,20210701
        //수익률 계산에 사용
        public DataGridView getCprice()
        {
            return dataGridView1;
        }
    }
}
