using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());
        }
    }
}
