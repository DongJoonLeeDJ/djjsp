using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // int 자료형의 숫자를 생성합니다.
            int intNumber = 2147483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
