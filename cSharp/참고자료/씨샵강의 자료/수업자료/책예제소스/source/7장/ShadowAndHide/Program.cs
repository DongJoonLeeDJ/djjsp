using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowAndHide
{
    class Program
    {
        // 코드 7-22: 섀도잉
        public static int number = 10;

        // 코드 7-23: 변수 하이딩
        // 코드 7-25: 메서드 하이딩
        class Parent
        {
            public int variable = 273;

            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public string variable = "shadowing";

            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            // 코드 7-22 확인
            int number = 20;
            Console.WriteLine(number);
            Console.WriteLine();

            // 코드 7-23 확인
            Child childA = new Child();
            Console.WriteLine(childA.variable);

            // 코드 7-24: 숨겨진 멤버를 찾는 방법
            Child childB = new Child();
            Console.WriteLine(((Parent)childB).variable);

            // 코드 7-25: 확인
            Child childC = new Child();
            childC.Method();
            ((Parent)childC).Method();
        }
    }
}


