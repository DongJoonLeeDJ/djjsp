using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVariableOnInheritance
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;

            public void CountParent()
            {
                Parent.counter++;
            }
        }

        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
        }

        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
