using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementOperatorPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // 전위
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            // 후위
            // int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
        }
    }
}
