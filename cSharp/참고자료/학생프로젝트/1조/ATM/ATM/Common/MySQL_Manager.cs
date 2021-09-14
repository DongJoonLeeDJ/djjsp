using ATM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Common
{
    //이승직
    class MySQL_Manager
    {
        //Account 클래스를 리스트 accounts로 새로운 객체 생성
        public static List<Account> accounts = new List<Account>();

        public static void Load()
        {
            MySQL_Helper.Query_Select();
            accounts.Clear();
            string bank = "";
            string acc_num = "";
            string name = "";
            int balance = 0;

            foreach (DataRow item in MySQL_Helper.ds.Tables[0].Rows)
            {
                Account temp = new Account(bank,acc_num,name,balance);
                bank = item["bank"].ToString();
                acc_num = item["acc_num"].ToString();
                name = item["name"].ToString();
                balance = int.Parse(item["balance"].ToString());
                accounts.Add(temp);
            }
        }
    }
}
