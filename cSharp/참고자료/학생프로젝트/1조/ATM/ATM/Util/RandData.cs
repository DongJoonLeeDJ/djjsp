using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Util
{
    class RandData
    {
        static string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
        static int[] age = { 30, 40, 50, 60, 100 };
        static string[] tel = { "010-1111-1111", "010-1111-1112", "010-1111-1113", "010-1111-1114", "010-1111-1115" };
        static string[] addr = { "서울 동구 신천2동", "대구 동구 신천2동", "부산 동구 신천2동", "대전 동구 신천2동", "인천 동구 신천2동" };
        static char[] gender = { '남', '여' };

        static string[] jikwi = { "주임", "대리", "과장", "차장", "부장" };
        static string[] office = { "동대구영업소", "서대구영업소", "북대구영업소", "남대구영업소", "효목동영업소" };
        static string[] model = { "K7", "K8", "그랜저", "제네시스", "SM6" };
        static string[] color = { "검정", "흰색", "은섹", "파랑", "진주색" };
        string[] price = { "3천만원", "4천만원", "5천만원", "6천만원", "7천만원" };
        static string[] company = { "현대", "KIA", "삼성르노", "쌍용", "GM" };


        Random r = new Random();
        //name[r.Next(5)], age[r.Next(5)], tel[r.Next(5)], addr[r.Next(5)], gender[r.Next(2)])
        public string getName()
        {
            return name[r.Next(5)];
        }

        public int getAge()
        {
            return age[r.Next(5)];
        }
        public string getTel()
        {
            return tel[r.Next(5)];
        }
        public string getAddr()
        {
            return addr[r.Next(5)];
        }
        public char getGender()
        {
            return gender[r.Next(2)];
        }

        public string getJikwi()
        {
            return jikwi[r.Next(5)];
        }
        public string getOffice()
        {
            return office[r.Next(5)];
        }
        public string getModel()
        {
            return model[r.Next(5)];
        }
        public string getColor()
        {
            return color[r.Next(5)];
        }
        public string getCompany()
        {
            return company[r.Next(5)];
        }
        public string getPrice()
        {
            return price[r.Next(5)];
        }
    }
}
