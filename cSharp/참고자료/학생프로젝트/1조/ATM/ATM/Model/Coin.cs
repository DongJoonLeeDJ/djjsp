using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    //박상준,20210703
    //구매한 개인의 코인 정보
    class Coin
    {

        public string coin_name { get; set; }//코인명
        public int total_amount { get; set; }//총 구매 수량
        public int AvgPrice { get; set; }//평균 구매가
        public string earning_rate { get; set; }//현재 수익률
        public double nowPrice { get; set; }//현재가
        public double revenue { get; set; }//현재 수익금
        public Coin(string coin_name, int total_amount, int AvgPrice, double nowPrice,string earning_rate, double revenue)
        {
            this.coin_name = coin_name;
            this.total_amount = total_amount;
            this.AvgPrice = AvgPrice;
            this.nowPrice = nowPrice;
            this.earning_rate = earning_rate;
            this.revenue = revenue;
        }
    }
}
