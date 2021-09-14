using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-24: 오버플로우
            int a1 = 2147483640;
            int b1 = 52273;
            Console.WriteLine(a1 + b1);
            Console.WriteLine();

            // 코드 2-27: uint와 ulong 자료형
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;
            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
            Console.WriteLine();

            // 코드 2-28: int 자료형의 최댓값과 최솟값
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine();

            // 코드 2-29: long 자료형의 최댓값과 최솟값
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine();

            // 코드 2-30: long 자료형을 나타내는 기호 - 소문자
            Console.WriteLine(123456 + 65432l);
            Console.WriteLine();

            // 코드 2-31: long 자료형을 나타내는 기호 – 대문자
            Console.WriteLine(123456 + 65432L);
            Console.WriteLine();

            // 코드 2-34: sizeof 연산자
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine();

            // 코드 2-35: 문자 자료형과 연산자
            char a2 = 'a';
            char b2 = 'b';

            Console.WriteLine(a2 + b2);
            Console.WriteLine(a2 - b2);
            Console.WriteLine(a2 * b2);
            Console.WriteLine(a2 / b2);
            Console.WriteLine(a2 % b2);
            Console.WriteLine();

            // 코드 2-37: sizeof 연산자와 string 자료형
            // 오류가 발생하므로 주석 처리 했습니다.
            // Console.WriteLine("string: " + sizeof(string));
        }
    }
}
