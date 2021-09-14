using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Program
    {
        // 코드 6-23: 상수 생성
        public const double PI = 3.141592;

        static void Main(string[] args)
        {
            // 코드 6-22: 상수 변경
            // 오류가 발생하므로 주석 처리
            /* Math.PI = 20;
            int r = 10;
            Console.WriteLine("원의 둘레: " + (2 * Math.PI * r));
            Console.WriteLine("원의 넓이: " + (Math.PI * r * r)); */


            // 코드 6-24: 메서드 내부에서 상수 사용
            const int value = 10;
            Console.WriteLine(value);
        }
    }

    // 코드 6-25: readonly 키워드
    class Product
    {
        private static int count;
        public readonly int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            id = count++;
            this.name = name;
            this.price = price;
        }
    }
}
