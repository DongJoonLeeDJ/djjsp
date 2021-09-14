using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classVsString
{
    class Baby
    {
        public string name;
        private string lolId;
        public int age;
        public int kg;
        private string gender;

        public string GetGender()
        {
            return gender;
        }
        
        public void SetGender(string g)
        {
            if (g == "남자" || g == "여자")
                gender = g;
            else
                Console.WriteLine("성별을 잘못입력하셨습니다!!!!!!!");
            //this.gender = gender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sjh = 12;
            string sjh_name = "서주형";
            //sjh_name = 12;

            Baby csjh = new Baby();
            csjh.age = 12;
            csjh.kg = 15;
            csjh.name = "서주형";
            csjh.SetGender("냠자");
            Console.WriteLine(csjh.GetGender());
            //csjh.
            


            //csjh.lolId = "killFaker";

            Baby sjy = new Baby();
            sjy.age = 10000;
            sjy.kg = 55;
            sjy.name = "송진영";
            //sjy.lolId = "-";

            Baby[] babies = new Baby[100];

            babies[0].age = 0;
            babies[0].kg = 3;
            babies[0].name = "김민영";
            //babies[0].lolId = "-";

            babies[1] = new Baby { age = 1, kg = 2, name = "김민하"/*, lolId = "-" */};
        }
    }
}
