using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연습문제 2-6
            Console.Write("inch 단위 입력: ");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다.");

            // 연습문제 2-7
            Console.Write("kg 단위 입력: ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(kg + "kg은 " + (kg * 2.20462262) + "pound입니다.");

            // 연습문제 2-8
            Console.Write("원의 반지름 입력: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레: " + (2 * 3.14 * radius));
            Console.WriteLine("원의 넓이: " + (3.14 * radius * radius));
        }
    }
}
