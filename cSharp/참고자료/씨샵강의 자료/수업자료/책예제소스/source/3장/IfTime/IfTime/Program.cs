using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
