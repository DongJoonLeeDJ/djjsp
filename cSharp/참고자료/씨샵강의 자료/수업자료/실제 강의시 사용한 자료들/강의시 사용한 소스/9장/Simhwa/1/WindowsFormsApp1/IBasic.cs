using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IBasic
    {
        void TestInstanceMethod(); //각 클래스 별로 반드시 구현해야 하는 메서드
        int TestProperty { get; set; } //각 클래스 별로 반드시 있어야 하는 속성
    }
}
