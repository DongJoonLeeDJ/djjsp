using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    //박상준,20210703
    //로그인 패널로 미리 이동할 패널정보를 받음
    public partial class UCP_Login : UserControl
    {
        #region 패널 상수 정의

        private const int EXCHANGE = 0;
        private const int TRANSACTION = 1;
        private const int CLIST = 2;
        private const int MYCOIN = 3;
        private const int TRANSACTION_HISTORY = 4;
        private const int HOMEPANEL = 5;
        private const int MYACCOUNT = 6;

        #endregion

        Form1 parentForm;
        int panelNum;
        string bank;
        string name;
        double balance;
        string phonenum;
        public UCP_Login(Form1 form, int panelNum)
        {
            InitializeComponent();
            parentForm = form;
            this.panelNum = panelNum;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }
        //박상준,20210703
        //DB에서 사용자 정보가 있는지 확인
        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
                int result = 0;

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT count(*) as cnt, bank, name, balance, phone FROM account where acc_num = '" + textBox_account.Text + "' and pwd = '" + textBox_pwd.Text + "';";
                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        result = Convert.ToInt32(rdr["cnt"]);
                        bank = rdr["bank"].ToString();
                        name = rdr["name"].ToString();
                        balance = Convert.ToDouble(rdr["balance"]);
                        phonenum = rdr["phone"].ToString();
                    }
                    rdr.Close();
                }
                //박상준,20210629
                //일지하는 정보(result)가 있으면 원하는 패널로 이동
                if (result == 0)
                {
                    textBox_account = null;
                    textBox_pwd = null;
                    MessageBox.Show("일치하는 정보가 없습니다");
                }
                else if (result == 1)
                {
                    //form에 로그인한 정보 저장
                    parentForm.login(textBox_account.Text, bank, name, balance, phonenum);

                    switch (panelNum)
                    {
                        case EXCHANGE://환전
                            UCP_Exchange exchange = new UCP_Exchange(parentForm);
                            parentForm.controllView(exchange);
                            break;
                        case TRANSACTION: //송금
                            UCP_Transaction trans = new UCP_Transaction(parentForm);
                            parentForm.controllView(trans);
                            break;
                        case CLIST: //업비트 (코인 거래 화면으로)
                            UCP_CList clist = new UCP_CList(parentForm);
                            parentForm.controllView(clist);
                            break;
                        case MYCOIN: // 코인 보유 현황 조회
                            UCP_MyCoin mycoin = new UCP_MyCoin(parentForm);
                            parentForm.controllView(mycoin);
                            break;
                        case TRANSACTION_HISTORY: // 거래내역 조회
                            Panel.UCP_Transaction_history panel10 = new Panel.UCP_Transaction_history(parentForm);
                            parentForm.controllView(panel10);
                            break;
                        case HOMEPANEL: // 홈화면으로
                            parentForm.HomePanel();
                            break;
                        case MYACCOUNT: // 내 계좌조회 화면으로
                            UCP_Account_check myaccount = new UCP_Account_check(parentForm, parentForm.getName(), parentForm.getPN());
                            parentForm.controllView(myaccount);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("계좌번호와 비밀번호를 입력하세요.");
            }            
        }
    }
}
