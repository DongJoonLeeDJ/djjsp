using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    // 코드 6-11: 오버로딩 불가
    // 오류가 발생합니다. 오류를 확인해보세요!
    class TestWorld
    {
        public int Test(int input) { }
        public double Test(int input) { }
        public double Test(int input) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
