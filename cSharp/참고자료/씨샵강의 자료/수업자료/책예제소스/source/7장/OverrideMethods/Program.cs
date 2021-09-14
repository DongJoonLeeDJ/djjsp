using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    // 코드 7-27: virtual 메서드와 override 메서드를 사용한 오버라이딩
    class Program
    {
        class Parent
        {
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
    }
}
