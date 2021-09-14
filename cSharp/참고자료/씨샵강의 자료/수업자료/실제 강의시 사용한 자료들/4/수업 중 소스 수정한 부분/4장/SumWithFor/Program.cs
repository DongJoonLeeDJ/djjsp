using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            int output = 0;
            int temp = 111;
            //< =
            // 반복을 수행합니다.
            for (int i = 0; i <= 100; i++)
            {
                output = output + i;
                // 0 = 0 + 0
                // 0 = 0+1
                // 1 = 1+2
                //output += i;
            }

            // 출력합니다.
            Console.WriteLine(output);
        }
    }
}
