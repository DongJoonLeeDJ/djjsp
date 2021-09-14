using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-1: 복사해서 붙여넣기를 사용한 반복
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");

            // 코드 4-2: 반복문을 사용한 반복
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("출력");
            }
        }
    }
}
