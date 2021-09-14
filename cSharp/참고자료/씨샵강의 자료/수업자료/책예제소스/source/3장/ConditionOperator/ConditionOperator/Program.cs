using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            string input = Console.ReadLine();
            int number = int.Parse(input);

            // 조건을 구분합니다
            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");
        }
    }
}
