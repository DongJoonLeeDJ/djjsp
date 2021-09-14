using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        // 코드 6-2: 두 개의 매개변수를 갖는 메서드
        class TestA
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }

        // 코드6-3: 아무 것도 리턴하지 않는 메서드
        class TestB
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }

        // 코드 6-6: Main() 메서드는 클래스 메서드
        static void Main(string[] args)
        {
            // 코드 6-2 호출
            TestA testA = new TestA();
            Console.WriteLine(testA.Multi(52, 273));
            Console.WriteLine(testA.Multi(103, 32));
            Console.WriteLine();

            // 코드 6-3 호출
            TestB testB = new TestB();
            testB.Print();
            testB.Print();
            testB.Print();
        }

    }
}
