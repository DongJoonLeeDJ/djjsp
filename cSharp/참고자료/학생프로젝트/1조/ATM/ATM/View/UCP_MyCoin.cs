using ATM.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{   
    public partial class UCP_MyCoin : UserControl
    {
        //박상준,20210629
        //내가 가진 코인에 대한 정보 확인
        Form1 parentForm;
        private List<Coin> coins = new List<Coin>();

        //수익률 계산에 사용
        UCP_CList ucp_clist;
        DataGridView data;
        double ClientInvest = 0;
        double ClientRevenue = 0;
        List<CPrice> cp = new List<CPrice>();

        public UCP_MyCoin(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            MyCoin();
            ucp_clist = new UCP_CList(form);
            dataGridView1.DoubleBuffered(true);
            label_clock.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            label_name.Text = parentForm.getName();
        }

        //박상준,20210703
        //처음 패널로 이동시 DB에 있는 사용자 코인정보를 읽어와 coins리스트에 추가
        private void MyCoin()
        {
            coins.Clear();
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            dataGridView1.DataSource = null;
            int count = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "select count(*) as cnt ,coin_name, sum(amount) as total_amount,sum(amount * price) / sum(amount) as AvgPrice from coin where acc_num = '" + parentForm.getUserAccount() + "' group by coin_name" + ";";
                string coin_name;
                int total_amount;
                int AvgPrice;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["cnt"]);
                    if (count != 0)
                    {
                        coin_name = rdr["coin_name"].ToString();
                        total_amount = Convert.ToInt32(rdr["total_amount"]);
                        AvgPrice = Convert.ToInt32(rdr["AvgPrice"]);
                        Coin temp = new Coin(coin_name, total_amount, AvgPrice, AvgPrice, "" + 0 + "%",0);
                        coins.Add(temp);
                    }
                }
                rdr.Close();
            }
            if (count != 0)
            {
                timer1.Enabled = true;
                dataGridView1.DataSource = coins;
            }
            else
                timer1.Enabled = false;
        }


        //박상준,20210701
        //Dispose() 추가
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parentForm.HomePanel();
        }

        //박상준,20210701
        //UCP_CList에서 datagridview를 가져와 값을 활용
        private void countEarningRate()
        {
            data = ucp_clist.getCprice();
            if (data != null && data.DataSource != null)
            {
                cp = data.DataSource as List<CPrice>;
                ClientInvest = 0;
                ClientRevenue = 0;
                for (int i = 0; i < coins.Count; i++)
                {
                    CPrice mycoin = cp.Find(x => x.korean_name == coins[i].coin_name);
                    if (mycoin != null)
                    {
                        coins[i].nowPrice = Convert.ToDouble(mycoin.trade_price);
                        coins[i].revenue = coins[i].total_amount * (coins[i].nowPrice-coins[i].AvgPrice);
                        coins[i].earning_rate =(-1* (Math.Truncate((((coins[i].AvgPrice / Convert.ToDouble(mycoin.trade_price)) * 100) - 100) * 1000) / 1000)) + "%";
                    }
                    ClientInvest += (coins[i].AvgPrice * coins[i].total_amount);
                    ClientRevenue += (coins[i].revenue);
                }
                label_invest.Text = "" + ClientInvest.ToString("#,#");
                label_revenue.Text = "" + ClientRevenue.ToString("#,#");
                double revenue = Convert.ToDouble(label_revenue.Text);
                if (revenue > 0)
                {
                    label_revenue.ForeColor = Color.Red;
                }
                else
                {
                    label_revenue.ForeColor = Color.Blue;
                }
            }
        }

        public static DataTable GetDataGridViewAsDataTable(DataGridView _DataGridView)
        {
            try
            {
                if (_DataGridView.ColumnCount == 0)
                    return null;
                DataTable dtSource = new DataTable();
                //////create columns
                foreach (DataGridViewColumn col in _DataGridView.Columns)
                {
                    if (col.ValueType == null)
                        dtSource.Columns.Add(col.Name, typeof(string));
                    else
                        dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                ///////insert row data
                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }
        //박상준,20210701
        //수익률 계산
        private void timer1_Tick(object sender, EventArgs e)
        {
            countEarningRate();
            //박상준,20210639
            //데이터 그리드뷰 새로고침
            dataGridView1.Refresh();
        }
        //박상준,20210701
        //시계 기능(1초 단위)
        private void timer2_Tick(object sender, EventArgs e)
        {
            label_clock.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCP_MyCoin_Load(object sender, EventArgs e)
        {

        }
    }

    //박상준,20210701
    //데이터 그리드뷰 수정시 화면 깜박임 제거(구글링)
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty);
            pi.SetValue(dgv, setting, null);
        }
    }
}
