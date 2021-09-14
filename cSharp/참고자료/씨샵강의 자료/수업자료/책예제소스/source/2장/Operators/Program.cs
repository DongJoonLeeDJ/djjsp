using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-45: 후위 증감 연산자
            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(number1); number1 += 1;
            Console.WriteLine(number1); number1 -= 1;
            Console.WriteLine(number1);
            Console.WriteLine();

            // 코드 2-46: 증감 연산자 이해도 확인
            int number2 = 10;
            Console.WriteLine(number2++);
            Console.WriteLine(++number2);
            Console.WriteLine(number2--);
            Console.WriteLine(--number2);
            Console.WriteLine();

            // 코드 2-47: 여러 줄로 나누어 적은 증감 연산자
            int number3 = 10;
            Console.WriteLine(number3);
            number3++;
            number3++;
            Console.WriteLine(number3);
            Console.WriteLine(number3);
            number3--;
            number3--;
            Console.WriteLine(number3);
        }
    }
}
