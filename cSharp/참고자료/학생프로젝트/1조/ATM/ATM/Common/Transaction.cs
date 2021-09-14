using ATM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Common
{
    public class Transaction
    {
        string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
        // 계좌 잔액 확인
        public double checkBal(string acc_num, string bank)
        {
            //김준석
            //송금할때 잔액보다 적은지 확인하기 위해 사용
            double bal = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //김준석
                //계좌 번호와 은행명 으로 잔액 확인
                //이승직
                //account 데이터베이스에서 acc_num과 bank가 각각 acc_num, bank의 값 일때 balance를 출력한다.
                string sql = "SELECT balance FROM account where acc_num = '"
                    + acc_num + "' and bank = '" + bank + "';";

                //이승직
                //MySQL연결
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //김준석
                    //잔액이 소수점까지 표현되서 더블로 형변환
                    bal = Convert.ToDouble(rdr["balance"]);
                }
                rdr.Close();
            }
            //김준석
            //잔액 반환
            return bal;
        }

        //김준석
        //송금할 계좌 정보 확인
        public CheckAcc checkAcc(string acc_num, string bank)
        {
            CheckAcc ca = new CheckAcc();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                conn.Open();
                //김준석
                // 송금할때 상대방 계좌정보 확인을 위해 이름,계좌번호,은행명 조회
                // 잔액은 송금후 상대방 계좌 금액 + 위해 조회
                string sql = "SELECT name,balance,acc_num,bank  FROM account where acc_num = '"
                    + acc_num + "' and bank = '" + bank + "';";
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //김준석
                    // 계좌정보 클래스에 저장
                    ca.Acc_num = rdr["acc_num"].ToString();
                    ca.Bank = rdr["bank"].ToString();
                    ca.Name = rdr["name"].ToString();
                    ca.Balance = Convert.ToDouble(rdr["balance"].ToString());
                    ca.Acc_check = true;
                }
                rdr.Close();
            }
            //김준석
            //계좌 정보 리턴
            return ca;
        }
        //김준석
        //송금
        public void transaction(string out_acc, string out_bank, string out_name, double out_balance,
            string in_acc, string in_bank, string in_name, double in_balance, double trans_amount)
        {
            string sql = "Insert Into transaction (trans_date," +
                "out_acc,out_bank,out_name,out_balance," +
                "in_acc,in_bank,in_name,in_balance," +
                "trans_price,trans_type)" +
                                                                                           //김준석
                                                                                           //출금계좌 잔액에서 송금금액 빼서 송금했을 당시 금액 저장
                "value(now(), '" + out_acc + "', '" + out_bank + "', '" + out_name + "'," + (out_balance - trans_amount) + "," +
                                                                            //김준석
                                                                            //입금계좌 잔액에서 입금금액 더해서 입금했을 당시 금액 저장
                "'" + in_acc + "', '" + in_bank + "', '" + in_name + "'," + (in_balance + trans_amount) + "," + trans_amount + ", 'money'); ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
        //김준석
        //무통장 입금
        public void gdgdzz(string out_acc, string out_bank, string out_name,
            string in_acc, string in_bank, string in_name, double in_balance, double trans_amount)
        {
            string sql = "Insert Into transaction (trans_date," +
                "out_acc,out_bank,out_name,out_balance," +
                "in_acc,in_bank,in_name,in_balance," +
                "trans_price,trans_type)" +
                "value(now(), '" + out_acc + "', '" + out_bank + "', '" + out_name + "', 0 ," +
                "'" + in_acc + "', '" + in_bank + "', '" + in_name + "'," + (in_balance + trans_amount) + "," + trans_amount + ", 'money'); ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
        //김준석
        //거래내역 조회
        public List<TsHistory> TsHistory(string acc_num, string bank)
        {
            //김준석
            // 거래내역 받을 리스트 생성
            List<TsHistory> list = new List<TsHistory>();
            //김준석
            //거래 내역 클래스
            TsHistory th;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //김준석
                //거래 내역에서 입금,출금 내역 조회후 날짜순으로 정렬
                string sql = $"select * from ("
                               + $" SELECT trans_date as trans_date, out_name as name , trans_price as price , in_balance as balance, '입금' as type"
                               + $" FROM atm.transaction where in_acc = '{acc_num}' and in_bank = '{bank}'"
                               + $" Union"
                               + $" SELECT trans_date as trans_date, in_name as name, trans_price as price , out_balance as balance, '출금' as type"
                               + $" FROM atm.transaction where out_acc = '{acc_num}' and out_bank = '{bank}') a"
                               + $" order by trans_date desc; ";
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //김준석
                    //거래내역 클래스생성
                    th = new TsHistory();
                    th.trans_date = rdr["trans_date"].ToString();
                    th.name = rdr["name"].ToString();
                    th.balance = double.Parse(rdr["balance"].ToString());
                    th.type = rdr["type"].ToString();

                    //입금액, 출금액 앞에 +,- 표시
                    if(th.type == "입금")
                    {
                        th.amount = "+" + rdr["price"].ToString();
                    }
                    else
                    {
                        th.amount = "-" + rdr["price"].ToString();
                    }

                    //김준석
                    //거래내역 리스트에 추가
                    list.Add(th);
                }
                rdr.Close();
            }
            //김준석
            //거래내역 리스트 리턴
            return list;
        }
    }
}
