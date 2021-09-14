using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultData
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-2: 정수
            Console.WriteLine(52);
            Console.WriteLine();

            // 코드 2-3: 정수 덧셈 연산자
            Console.WriteLine(52 + 273);
            Console.WriteLine();

            // 코드 2-4: 연산자 우선순위
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine();

            // 코드 2-5: 나머지 연산자
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);
            Console.WriteLine();

            // 코드 2-7: 음수와 나머지 연산자
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);
            Console.WriteLine();

            // 코드 2-8: 실수
            Console.WriteLine(52.273);
            Console.WriteLine();

            // 코드 2-9: 정수와 실수
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine();

            // 코드 2-11: 실수와 나머지 연산자
            Console.WriteLine(5.0 % 2.2);
            Console.WriteLine();

            // 코드 2-13: 문자열
            Console.WriteLine("안녕하세요");
            Console.WriteLine();

            // 코드 2-17: 예외
            // 실행이 중단되므로 주석 처리 했습니다.
            // Console.WriteLine("안녕하세요"[100]);
            // Console.WriteLine();

            // 코드 2-18: 문자 덧셈
            Console.WriteLine('가' + '힣');
            Console.WriteLine();

            // 코드 2-19: 불
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine();

        }
    }
}
