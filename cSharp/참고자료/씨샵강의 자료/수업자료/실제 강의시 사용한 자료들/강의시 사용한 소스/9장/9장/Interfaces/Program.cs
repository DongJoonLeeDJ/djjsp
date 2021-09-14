using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 9-5: 인터페이스 인스턴스화(오류 발생)
            // 오류가 발생하므로 주석 처리했습니다.
            // IComparable comparable = new IComparable();

            // 코드 9-13: 인터페이스 다형성
            IBasic basic = new TestClass();


            // 코드 9-15: 다중 상속과 다형성
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();
        }
    }

    // 코드 9-14: 다중 상속
    class Parent { }
    class Child : Parent, IDisposable, IComparable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
