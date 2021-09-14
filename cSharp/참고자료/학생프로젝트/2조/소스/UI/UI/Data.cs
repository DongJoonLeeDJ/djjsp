using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Data
    {
        public Data(string sido, string rentSecdNm, string houseName, string rceptBgnde, string rceptEndde, string przwnerPresnatnDe)
        {
            this.sido = sido;
            this.rentSecdNm = rentSecdNm;
            this.houseName = houseName;
            this.rceptBgnde = rceptBgnde;
            this.rceptEndde = rceptEndde;
            this.przwnerPresnatnDe = przwnerPresnatnDe;
        }

        public string sido { get; set; }                 //시도
        public string rentSecdNm { get; set; }             //구분
        public string houseName { get; set; }            //주택이름
        public string rceptBgnde { get; set; }           //접수 시작일
        public string rceptEndde { get; set; }           //접수 종료일
        public string przwnerPresnatnDe { get; set; }    //당첨자 발표일
    }
}
