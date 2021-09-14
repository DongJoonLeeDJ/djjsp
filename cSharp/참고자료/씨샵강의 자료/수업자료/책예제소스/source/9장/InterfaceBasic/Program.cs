using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }

    class Program
    {
        class TestClass : IBasic
        {
            public int TestProperty
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
