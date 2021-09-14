using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 3-2: 중괄호 사용 방식
            // if(true)
            // {
            // }
            // if(true) {
            // }

            // 코드 3-9: 논리 연산자와 조건문
            double scoreA = 3.6;
            if (scoreA == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= scoreA && scoreA < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= scoreA && scoreA < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= scoreA && scoreA < 3.5)
                Console.WriteLine("일반인");
            else if (2.3 <= scoreA && scoreA < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= scoreA && scoreA < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= scoreA && scoreA < 1.74)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= scoreA && scoreA < 1.0)
                Console.WriteLine("자벌레");
            else if (0 < scoreA && scoreA < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");

            // 코드 3-10: 조건문 간단 사용
            double scoreB = 3.6;
            if (scoreB == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= scoreB)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= scoreB)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= scoreB)
                Console.WriteLine("일반인");
            else if (2.3 <= scoreB)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= scoreB)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= scoreB)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= scoreB)
                Console.WriteLine("자벌레");
            else if (0 < scoreB)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");

            // 코드 3-13: 삼항 연산자
            int number = 52273;
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
