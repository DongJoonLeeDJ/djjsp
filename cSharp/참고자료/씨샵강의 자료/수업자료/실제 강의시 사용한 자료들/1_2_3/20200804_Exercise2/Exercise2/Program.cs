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

            //두 자리 숫자 입력 받아서 각 자리 숫자와 곱하여 출력하는 문제
            //배열을 이용하는 방법

            Console.WriteLine("첫 번째 숫자?");
            string sInput1 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자?");
            string sInput2 = Console.ReadLine();

            int input1 = int.Parse(sInput1);

            int input2_3 = int.Parse(sInput2[2].ToString());
            int input2_4 = int.Parse(sInput2[1] + "");
            int input2_5 = int.Parse(sInput2[0] + "");
            int input2_6 = int.Parse(sInput2);

            Console.WriteLine(input1 * input2_3);

            //ASCII 표 참고!!!
            Console.WriteLine("-_-");
            Console.WriteLine(input1 * sInput2[2]);
            Console.WriteLine(input1 * (int)sInput2[2]);
            Console.WriteLine("-_-");

            Console.WriteLine(input1 * input2_4);
            Console.WriteLine(input1 * input2_5);
            Console.WriteLine(input1 * input2_6);


            //노배열
            Console.WriteLine("No 배열 버전");


            int noArray2 = int.Parse(sInput2);
            int noArray_input2_3 = noArray2 % 10;  /* noArray2 - ((noArray2/10)*10);*/
            int noArray_input2_4 = (noArray2 / 10) % 10; /*noArray2 - ((noArray2 / 100)*100) - noArray_input2_3;*/
            //noArray_input2_4 /= 10;
            int noArray_input2_5 = noArray2 / 100;
            int noArray_input2_6 = noArray2;


            Console.WriteLine(input1 * noArray_input2_3);
            Console.WriteLine(input1 * noArray_input2_4);
            Console.WriteLine(input1 * noArray_input2_5);
            Console.WriteLine(input1 * noArray_input2_6);






        }
    }
}
