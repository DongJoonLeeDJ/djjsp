using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOfStruct
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            Point point = new Point(5, 10);

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
