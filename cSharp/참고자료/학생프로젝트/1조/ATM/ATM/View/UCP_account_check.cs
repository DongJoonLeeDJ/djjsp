using ATM.Common;
using ATM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    //이승직
    public partial class UCP_Account_check : UserControl
    {
        Form1 parentForm;
        public UCP_Account_check(Form1 form, string name, string phone)
        {
            InitializeComponent();
            parentForm = form;
            textBox_name.Text = name;
            textBox_num.Text = phone;
        }

        //button_back을 클릭했을 때
        private void button_back_Click(object sender, EventArgs e)
        {
            //HomePanel로 이동
            parentForm.HomePanel();
        }

        //button_check를 클릭했을 때
        private void button_check_Click(object sender, EventArgs e)
        {
            //MySQL 서버 192.168.0.104, 데이터베이스이름 atm, id root, pw 1234로 접속
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //MySQL select Query문
                //account에서 이름이 textBox_name에 입력된 값이고, 번호가 textBox_num에 입력된 acc_num, bank, name, balance를 출력
                string sql = "SELECT acc_num, bank, name, balance FROM account WHERE name= '" + textBox_name.Text + "' and phone= '" + textBox_num.Text + "';";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                //데이터 그리드뷰에 들어갈 리스트 비워주기 -> 그래야 이전 기록 지워짐.
                MySQL_Manager.accounts.Clear();

                while (rdr.Read())
                {
                    //bank
                    string bank = rdr["bank"].ToString();
                    //acc_num
                    string acc_num = rdr["acc_num"].ToString();
                    //name
                    string name = rdr["name"].ToString();
                    //balance
                    double balance = double.Parse(rdr["balance"].ToString());
                    //Account를 temp라는 새로운 객체로 만듬, bank, acc_num, name, balance
                    Account temp = new Account(bank, acc_num, name, balance);
                    MySQL_Manager.accounts.Add(temp);
                }
                rdr.Close();

                //dataGridView1에 DataSource는 null
                dataGridView1.DataSource = null;
                //dataGridView1에 DataSource는 MySQL_Manager 클래스의 accounts 리스트
                dataGridView1.DataSource = MySQL_Manager.accounts;
            }
        }
    }
}
