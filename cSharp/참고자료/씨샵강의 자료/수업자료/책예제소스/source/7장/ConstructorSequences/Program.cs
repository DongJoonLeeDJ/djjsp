using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSequences
{
    // 코드 7-18: 상속 때의 기본적인 생성자 호출 순서
    namespace A
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식 생성자");
            }
        }
    }

    // 코드 7-19: base 키워드를 사용한 생성자 지정
    namespace B
    {
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자"); }
        }

        class Child : Parent
        {
            public Child() : base()
            {
                Console.WriteLine("자식 생성자");
            }
        }
    }

    // 코드 7-20: base 키워드를 사용한 생성자 지정(2)
    namespace C
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }

            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 코드 7-18 호출
            A.Child childA = new A.Child();
            Console.WriteLine();

            // 코드 7-19 호출
            B.Child childB = new B.Child();
            Console.WriteLine();

            // 코드 7-20 호출
            C.Child childC = new C.Child();
            C.Child childD = new C.Child("string");

        }
    }
}
