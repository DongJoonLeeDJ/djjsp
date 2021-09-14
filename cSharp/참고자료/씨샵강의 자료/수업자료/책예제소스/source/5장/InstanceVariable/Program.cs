using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariable
{
    class Program
    {
        class Product
        {
            public string name;
            public int price;
        }

        static void Main(string[] args)
        {
            Product product = new Product();
        }
    }
}
