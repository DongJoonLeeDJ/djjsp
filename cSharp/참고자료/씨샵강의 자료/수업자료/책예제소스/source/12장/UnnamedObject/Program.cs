using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where item % 2 == 0
                         select new
                         {
                             A = item * 2,
                             B = item * item,
                             C = 100,
                             D = 900,
                             xenoint = item * item * item

                         };

            foreach (var item in output)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine(item.xenoint);
                Console.WriteLine();
            }
        }
    }
}
