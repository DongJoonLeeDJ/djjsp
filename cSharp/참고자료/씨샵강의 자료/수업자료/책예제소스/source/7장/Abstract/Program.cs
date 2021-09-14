using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // 코드 7-33: abstract 클래스 오류
    namespace A
    {
        abstract class Parent
        {
            public void Test() { }
        }

        class Child : Parent
        {
            public void Test() { }
        }
    }

    // 코드 7-34: abstract 메서드
    namespace B
    {
        abstract class Parent
        {
            public abstract void Test();
        }

        class Child : Parent
        {
            // 코드 7-35: abstract 메서드와 관련된 오류 해결
            // public override void Test() { }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 코드 7-33 호출(여기에서 오류가 발생합니다)
            A.Parent parent = new A.Parent();
            A.Child child = new A.Child();

            parent.Test();
            child.Test();
        }
    }
}
