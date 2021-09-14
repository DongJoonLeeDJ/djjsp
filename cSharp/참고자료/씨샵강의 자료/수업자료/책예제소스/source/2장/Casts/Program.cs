using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casts
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 2-56: 자료형 변환
            // 오류가 발생하므로 주석 처리했습니다.
            // long longNumber = 2147483647L + 2147483647L;
            // int intNumber = longNumber;
            // Console.WriteLine(intNumber);

            // 코드 2-57: 강제 자료형 변환
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            // 코드 2-59: 강제 자료형 변환의 데이터 손실은 항상 일어나는 것은 아님
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
            Console.WriteLine();

            // 코드 2-63: 문자열을 숫자로 변환
            // 오류가 발생하므로 주석 처리했습니다.
            // string numberString = "52273";
            // int intNumber = (int)numberString;
            // Console.WriteLine(intNumber);

            // 코드 2-64: 숫자로 변환할 수 없는 문자열을 변환하는 경우
            // 예외가 발생하므로 주석 처리했습니다.
            // Console.WriteLine(int.Parse("52.273"));
            // Console.WriteLine(int.Parse("abc"));

            // 코드 2-68: 간단한 문자열 변환
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);
            Console.WriteLine();
        }
    }
}
