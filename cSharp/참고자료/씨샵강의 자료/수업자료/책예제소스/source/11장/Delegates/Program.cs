using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // 코드 11-6: 딜리게이트 생성 위치
    public delegate void TestDelegateA();
    class Program
    {
        // 코드 11-6: 딜리게이트 생성 위치
        public delegate void TestDelegateB();

        // 코드 11-7 딜리게이트 초기화 방법
        public delegate void TestDelegate();

        static void Main(string[] args)
        {

            TestDelegate delegateA = TestMethod;
            TestDelegate delegateB = delegate () { };
            TestDelegate delegateC = () => { };

            delegateA();
            delegateB();
            delegateC();
        }

        static void TestMethod()
        {

        }
    }
}
