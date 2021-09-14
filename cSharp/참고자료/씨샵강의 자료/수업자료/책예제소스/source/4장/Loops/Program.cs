using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-9: 무한 반복
            // 무한 반복 되어 뒤의 예제를 확인할 수 없으므로 주석 처리 했습니다.
            /* while (true)
            {
                Console.WriteLine("무한 반복");
            } */

            // 코드 4-10: 시간을 사용한 반복문 이탈
            long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            
            Console.WriteLine(count + "만큼 반복했습니다.");
            Console.WriteLine();

            // 코드 4-23: goto 키워드
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }

        doNotUse:
            Console.WriteLine("goto 키워드");
            Console.WriteLine();

            // 코드 4-25: 기본 예제를 간단하게 변경
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
