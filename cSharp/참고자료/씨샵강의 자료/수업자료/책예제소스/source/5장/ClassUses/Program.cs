using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUses
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 5-3: 원하는 범위의 실수 난수 생성
            Random random = new Random();
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);

            // 코드 5-4: 배열 생성
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            // 코드 5-5: List 클래스의 인스턴스 생성
            List<int> listA = new List<int>();

            // 코드 5-7: List 인스턴스 생성과 동시에 요소 추가
            List<int> listB = new List<int>() { 52, 273, 32, 64 };
            foreach (var item in listB)
            {
                Console.WriteLine("Count: " + listB.Count + "\titem: " + item);
            }
        }
    }
}
