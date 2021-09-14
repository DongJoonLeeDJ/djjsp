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

namespace ATM
{
    public partial class Form1 : Form
    {
        UCP_Homepanel panel;
        //박상준,20210629
        //로그인 하면 회원 정보 저장하는 변수(계좌번호, 은행, 이름, 잔액, 전화번호) 
        private string UserAccount = "";
        private string bank = "";
        private string name = "";
        private double balance = 0;
        private string phonenum = "";
        //박상준,20210627
        //주석 추가, ucpanel1을 기본 홈패널로 생각
        //기본 화면을 ucpanel1로 지정한다.(나중에 패널명 수정 필요)
        public Form1()
        {
            InitializeComponent();
            panel = new UCP_Homepanel(this);
            controllView(panel);
        }
        //박상준,20210629
        //패널전환 방식 수정
        public void controllView(UserControl uc)
        {
            mainL.Controls.Clear();
            mainL.Controls.Add(uc);
        }
        //박상준,20210627 주석 추가
        //다른 패널에서 홈 패널로 이동
        public void HomePanel()
        {
            UCP_Homepanel panel = new UCP_Homepanel(this);
            controllView(panel);
        }
        //박상준,20210629
        //게좌와 비밀번호로 로그인되면 form1에 정보 기록
        public void login(string account, string bank,string name, double balance, string phonenum)
        {
            UserAccount = account;
            this.bank = bank;
            this.name = name;
            this.balance = balance;
            this.phonenum = phonenum;
    }

        //박상준,20210627
        //사용자 계좌가 ""로 없다면 false를 반환하고 아니면 true를 반환한다.
        public Boolean chkLogin()
        {
            if(UserAccount.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //박상준,20210627
        //사용자 계좌 정보를 없애고, 패널을 홈패널로 이동한다.
        public void logout()
        {
            UserAccount = "";
            bank = "";
            name = "";
            balance = 0;
            phonenum = "";
            HomePanel();
        }

        //박상준,20210629
        //사용자 계좌번호 반환
        public string getUserAccount()
        {
            return UserAccount;
        }
        //박상준,20210629
        //사용자 은행정보 반환
        public string getBank()
        {
            return bank;
        }
        //박상준,20210629
        //사용자 이름정보 반환
        public string getName()
        {
            return name;
        }
        //박상준,20210629
        //사용자 잔액정보 반환
        public double getBalance()
        {
            return balance;
        }

        public string getPN()
        {
            return phonenum;
        }
    }
}
