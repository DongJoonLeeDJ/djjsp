using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where (item > 5) && (item % 2 == 0)
                         select item;

            foreach (var item in output)
            {
                Console.WriteLine(item);

            }
        }
    }
}
