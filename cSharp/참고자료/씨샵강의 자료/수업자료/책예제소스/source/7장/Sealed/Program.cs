using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    // 코드 7-31: sealed 클래스 오류
    namespace A
    {
        sealed class Parent
        {
            public void Test() { }
        }

        class Child : Parent
        {
            public void Test() { }
        }
    }

    // 코드 7-32: sealed 메서드 오류
    namespace B
    {
        class Parent
        {
            public virtual void Test() { }
        }

        class Child : Parent
        {
            sealed public override void Test() { }
        }

        class GrandChild : Child
        {
            public override void Test() { }
        }
    }

    class Program
    {   
        static void Main(string[] args)
        {
            // 코드 7-31 호출
            A.Parent parent = new A.Parent();
            A.Child child = new A.Child();
            parent.Test();
            child.Test();
        }
    }
}
