using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    class CPrice
    {
        public CPrice(string market, string korean_name, string trade_price)
        {
            this.market = market;
            this.korean_name = korean_name;
            this.trade_price = trade_price;
        }
        public string market { get; set; }
        public string korean_name { get; set; }
        public string trade_price { get; set; }
    }
}

