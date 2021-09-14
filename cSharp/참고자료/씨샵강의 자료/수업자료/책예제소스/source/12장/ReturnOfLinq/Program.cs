using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOfLinq
{
    class Program
    {
        // 코드 12-8: ToArray() 메서드
        public static int[] SelectEven(int[] input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToArray<int>();
        }

        // 코드 12-9: ToList() 메서드
        public static List<int> SelectEven(List<int> input)
        {
            return (from item in input
                    where item % 2 == 0
                    select item).ToList<int>();
        }

        static void Main(string[] args)
        {
            // 코드 12-7: Linq 결과의 자료형
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> output = from item in input
                                      where item % 2 == 0
                                      select item;

            // 코드 출력
            foreach (var item in output) { Console.WriteLine(item); }
            foreach (var item in SelectEven(input.ToArray())) { Console.WriteLine(item); }
            foreach (var item in SelectEven(input)) { Console.WriteLine(item); }
        }
    }
}
