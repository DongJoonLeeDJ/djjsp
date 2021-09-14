using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovingAt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다.
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
