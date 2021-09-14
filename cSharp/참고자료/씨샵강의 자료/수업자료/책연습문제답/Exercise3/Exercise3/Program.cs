using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            // 연습문제 3-3
            if (x > 10 && x < 20)
            {
                Console.WriteLine("조건에 맞습니다.");
            }

            // 연습문제 3-4
            Console.Write("태어난 년도: ");
            int birth = int.Parse(Console.ReadLine());
            switch (birth % 12)
            {
                case 0: Console.WriteLine("원숭이 띠입니다."); break;
                case 1: Console.WriteLine("닭 띠입니다."); break;
                case 2: Console.WriteLine("개 띠입니다."); break;
                case 3: Console.WriteLine("돼지 띠입니다."); break;
                case 4: Console.WriteLine("쥐 띠입니다."); break;
                case 5: Console.WriteLine("소 띠입니다."); break;
                case 6: Console.WriteLine("호랑이 띠입니다."); break;
                case 7: Console.WriteLine("토끼 띠입니다."); break;
                case 8: Console.WriteLine("용 띠입니다."); break;
                case 9: Console.WriteLine("뱀 띠입니다."); break;
                case 10: Console.WriteLine("말 띠입니다."); break;
                case 11: Console.WriteLine("양 띠입니다."); break;
            }

            // 연습문제 3-5
            Console.Write("현재가 몇 월인지 입력해주세요: ");
            int year = int.Parse(Console.ReadLine());
            if (3 <= year && year <= 5)
            {
                Console.WriteLine("봄입니다.");
            }
            else if (6 <= year && year <= 8)
            {
                Console.WriteLine("여름입니다.");
            }
            else if (9 <= year && year <= 11)
            {
                Console.WriteLine("가을입니다.");
            }
            else
            {
                Console.WriteLine("겨울입니다.");
            }

            // 연습문제 3-6
            Console.Write("학년을 입력하세요");
            int level = int.Parse(Console.ReadLine());
            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
            }
        }
    }
}
