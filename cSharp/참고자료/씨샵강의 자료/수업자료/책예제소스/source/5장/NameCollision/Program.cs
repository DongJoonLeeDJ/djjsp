using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCollision
{
    class Program
    {
        // 코드 5-10: 클래스 이름 충돌
        class Math { }

        static void Main(string[] args)
        {
            // 오류를 확인해보세요!
            Console.WriteLine(Math.Abs(-10));
        }
    }
}
