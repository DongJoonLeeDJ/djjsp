using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBasic
{
    class Program
    {
        public delegate void example(); 

        static void Main(string[] args)
        {
            Thread threadA = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("A");
                }
            });
            Thread threadB = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });


            Thread threadD = new Thread(print);
            Thread threadE = new Thread
            (
                delegate() 
                { 
                    for (int i = 0; i < 1000; i++)
                        Console.Write("E"); 
                }
            );

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadE.Start();
        }

        static void print()
        {

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("D");
            }
        }
    }
}
