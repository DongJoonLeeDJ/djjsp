using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToBool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));
        }
    }
}
