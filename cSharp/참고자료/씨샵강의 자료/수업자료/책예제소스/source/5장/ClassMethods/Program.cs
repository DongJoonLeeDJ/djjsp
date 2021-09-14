using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        public int instanceVariableA = 10;
        public static int instanceVariableB = 10;

        static void Main(string[] args)
        {
            // 코드 6-8: 클래스 메서드에서 인스턴스 변수 사용은 오류가 발생
            // 오류가 발생하므로 주석 처리
            // Console.WriteLine(instanceVariableA);

            // 코드 6-9: 클래스 메서드에서는 클래스 변수 사용으로 변경
            Console.WriteLine(instanceVariableB);
        }
    }
}
