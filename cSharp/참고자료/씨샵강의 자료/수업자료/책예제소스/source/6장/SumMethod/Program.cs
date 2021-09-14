using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMethod
{
    class Program
    {
        class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));
        }
    }
}
