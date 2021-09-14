using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // 코드 8-2: 두 개 이상의 제네릭을 사용하는 클래스
    class TestA<T, U>
    {

    }

    // 코드 8-3: where 키워드
    class TestB<T, U>
        where T : class
        where U : struct
    {

    }

    class TestC<T, U>
        where T : IComparable
        where U : IComparable, IDisposable
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
