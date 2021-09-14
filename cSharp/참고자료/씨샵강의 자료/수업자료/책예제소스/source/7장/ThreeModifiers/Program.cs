using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeModifiers
{
    // 코드 7-7: 세 가지 접근 제한자
    class Program
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                Private();
                Protected();
                Public();
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                Protected();
                Public();
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Public();
        }
    }
}
