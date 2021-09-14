using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    // 코드 6-16: 기본적인 생성자의 모습
    class Product
    {
        public string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }

    // 코드 6-18: private 생성자
    class Hidden
    {
        private Hidden() { }
    }

    // 코드 6-19: 정적 생성자
    class Sample
    {
        public static int value;

        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 코드 6-18 호출
            // 오류가 발생하므로 추석 처리
            // Hidden hidden = new Hidden();

            // 코드 6-20: 정적 생성자의 호출 시점
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

            /* // 위의 것과 둘 중에 하나만 실행해서 정적 생성자 호출을 확인해보세요!
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
            */
        }
    }
}
