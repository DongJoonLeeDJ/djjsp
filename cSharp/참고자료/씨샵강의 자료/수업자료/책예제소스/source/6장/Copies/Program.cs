using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copies
{
    class Program
    {
        // 코드 6-30: 값 복사 예
        static void Change(int input)
        {
            input = 20;
        }

        // 코드 6-32: 참조 복사 예
        class Test
        {
            public int value = 10;
        }
        static void Change(Test input)
        {
            input.value = 20;
        }
        
        static void Main(string[] args)
        {
            // 코드 6-30 활용
            int a = 10;
            Change(a);
            Console.WriteLine(a);
            Console.WriteLine();

            // 코드 6-31: 간단한 값 복사 예
            int b = 10;
            int input = b;
            input = 20;
            Console.WriteLine(b);
            Console.WriteLine();

            // 코드 6-32 활용
            Test test = new Test();
            test.value = 10;
            Change(test);
            Console.WriteLine(test.value);
            Console.WriteLine();

            // 코드 6-33: 간단한 참조 복사 예
            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
        }
    }
}
