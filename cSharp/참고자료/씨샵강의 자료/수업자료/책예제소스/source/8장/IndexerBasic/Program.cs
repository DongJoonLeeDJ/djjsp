using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerBasic
{
    class SquareCalculator
    {
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerlist = new List<int>();
            integerlist.Add(0);
            integerlist.Add(1);

            integerlist[0] = 100;

            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[100]);
        }
    }
}
