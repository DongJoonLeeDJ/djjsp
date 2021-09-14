using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_instance_example
{
    class Program
    {
        class lotto
        {
            public static int totalCountLotto = 0;
            public static int DangChumBunHo = 88;
            public lotto()
            {
                totalCountLotto++;
            }
            private int number = 0;
            public void setNum(int n)
            {
                if(n<0)
                {
                    Console.WriteLine("음수는 안 됩니다. 일단은 0으로 돌립니다.");
                    number = 0;
                }
                else
                {

                    number = n;
                }
            }
            public int getNum()
            {
                return number;
            }
            public int getPlus100()
            {
                return number + 100;
            }

        }

        static void Main(string[] args)
        {
        }
    }
}
