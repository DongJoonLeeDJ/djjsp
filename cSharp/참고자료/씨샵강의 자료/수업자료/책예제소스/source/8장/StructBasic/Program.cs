using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBasic
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;

            Point pointer = new Point();

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
