using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연습문제 4-4: 아래의 다른 예제와 변수가 겹치지 않게 i가 아니라 r을 사용했습니다.
            int r = 0;
            while (r < 10)
            {
                Console.Write("출력");
                r++;
            }

            // 연습문제 4-5
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // 연습문제 4-6
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                int input = int.Parse(Console.ReadLine());
                if (input < min) { min = input; }
                if (input > max) { max = input; }
            }

            // 연습문제 4-7
            // 첫 번째 수열 입력
            string start = "1";

            // 계산 시작
            for (int i = 0; i < 20; i++)
            {
                // 출력
                Console.WriteLine((i + 1) + "번째: " + start);

                // 읽고 말하기 수열 계산
                string end = "";
                char number = start[0];
                int count = 0;
                for (int j = 0; j < start.Length; j++)
                {
                    if (number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;

                // 다음 단계 준비
                start = end;
            }
        }
    }
}
