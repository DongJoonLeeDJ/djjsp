using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOut
{
    class Program
    {
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            // 다음 위치 = 현재 위치 + 현재 속도
            rx = x + vx;
            ry = y + vy;
        }

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
        }
    }
}
