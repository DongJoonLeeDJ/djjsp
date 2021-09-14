using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    //이승직 20210628
    //계좌 조회용
    class Account
    {
        public Account(string bank, string acc_num, string name, double balance)
        {
            this.bank = bank;
            this.acc_num = acc_num;
            this.name = name;
            this.balance = balance;
        }

        public string bank { get; set; }

        public string acc_num { get; set; }

        public string name { get; set; }

        public double balance { get; set; }
    }
}
