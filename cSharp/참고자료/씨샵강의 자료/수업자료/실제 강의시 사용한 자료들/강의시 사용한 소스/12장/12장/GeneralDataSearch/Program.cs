using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDataSearch
{
    class Program
    {
        // 코드 12-1: 데이터를 선별하는 정형화된 코드
        static List<int> GeneralSearch()
        {
            // 입력과 출력을 나타내는 리스트를 생성합니다.
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            // 입력을 나타내는 리스트에 반복을 적용합니다.
            foreach (var item in input)
            {
                // 조건을 확인합니다.
                if (item % 2 == 0)
                {
                    // 출력을 나타내는 리스트에 요소를 추가합니다.
                    output.Add(item);
                }
            }

            // 출력을 나타내는 배열을 반환합니다.
            return output;
        }

        // 코드 12-2: Linq를 사용해 간단하게 작성
        static IEnumerable<int> GeneralSearchWithLinq()
        {
            // 입력과 출력을 나타내는 리스트를 생성합니다.
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Linq 질의를 사용해 반환합니다.
            return from item in input
                   where item % 2 == 0
                   select item;
        }

        static void Main(string[] args)
        {
            // 코드 12-3: Linq 기본 구문
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = from item in input
                         where item % 2 == 0
                         orderby item
                         select item;

            // 출력
            foreach (var item in GeneralSearch()) { Console.WriteLine(item); }
            Console.WriteLine();
            foreach (var item in GeneralSearchWithLinq()) { Console.WriteLine(item); }
            Console.WriteLine();
            foreach (var item in output) { Console.WriteLine(item); }
        }
    }
}
