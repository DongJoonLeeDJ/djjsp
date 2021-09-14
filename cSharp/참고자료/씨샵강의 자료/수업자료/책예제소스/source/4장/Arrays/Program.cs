using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 코드 4-3: 기본적인 배열 생성 방법
            int[] intArray = { 52, 273, 32, 65, 103 };
            long[] longArray = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라' };
            string[] stringArray = { "윤인성", "연하진", "윤아린" };

            // 코드 4-5: 배열의 Length 속성
            int[] intArrayA = { 52, 273, 32, 65, 103 };
            Console.WriteLine(intArray.Length);

            // 코드 4-6: 배열의 범위를 벗어나는 인덱스에 접근
            // 예외가 발생하므로 주석 처리했습니다.
            // int[] intArrayB = { 52, 273, 32, 65, 103 };
            // Console.WriteLine(intArray[5]);

            // 코드 4-7: 원하는 크기의 배열 생성 방법
            int[] arrayA = new int[100];
        }
    }
}
