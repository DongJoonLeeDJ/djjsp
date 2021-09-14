using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVariable
{
    class Program
    {
        class MyMath
        {
            public static double PI = 3.141592;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.PI);
        }
    }
}
