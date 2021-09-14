using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperator
{
    class Program
    {
        public delegate void SendString(string message);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;

            sayHello = Hello;
            sayGoodbye = GoodBye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("이동준");

            Console.WriteLine();

            multiDelegate -= sayGoodbye;
            multiDelegate("이동준");
        }

        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요. " + message + "쌤...!");
        }

        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히가세요. " + message + "쌤....");
        }
    }
}
