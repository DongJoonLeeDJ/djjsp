using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    class Program
    {
        // 코드 2-52: 지역 변수
        // 오류가 발생하므로 주석 처리했습니다.
        // var global = 52;

        static void Main(string[] args)
        {
            // 코드 2-50: var 키워드
            var number1 = 100;

            // 코드 2-51: var 키워드의 제약
            // 오류가 발생하므로 주석 처리했습니다.
            var number2 = 10.2;
            // number2 = "변경";

            // 코드 2-53: var 키워드의 선언과 초기화 동시 수행
            var number = 20;

            // 코드 2-54: var 키워드를 사용한 다양한 자료형 선언
            var numberA = 100L;   // long 자료형
            var numberB = 100.0;  // double 자료형
            var numberC = 100.0F; // float 자료형
        }
    }
}
