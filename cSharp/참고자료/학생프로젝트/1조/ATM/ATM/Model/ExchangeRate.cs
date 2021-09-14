using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    //박상준,20210627 주석 추가 
    //환율
    public class ExchangeRate
    {
        public ExchangeRate()
        {
        }

        public ExchangeRate(string curr_name, string currency, string price)
        {
            this.curr_name = curr_name;
            this.currency = currency;
            this.price = price;
        }
        public string currency { get; set; }
        public string price { get; set; }
        public string curr_name { get; set; }
    }
}
