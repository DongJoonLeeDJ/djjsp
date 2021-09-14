using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicModifiers
{
    // 코드 6-15: public 접근 제한자를 붙인 Main() 메서드
    class Test
    {
        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
