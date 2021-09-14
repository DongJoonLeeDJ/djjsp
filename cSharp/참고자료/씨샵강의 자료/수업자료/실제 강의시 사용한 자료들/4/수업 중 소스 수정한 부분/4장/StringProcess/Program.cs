using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            // 대문자화와 소문자화
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            // 문자열 자르기
            // string input = "감자 고구마 토마토";
            input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }

            // 문자열 양 옆의 공백 제거
            // string input = " test        \n";
            input = " test        \n";
            Console.WriteLine("::" + input.Trim() + "::");
            //Console.Read();

            // 배열을 문자열로
            string[] array = { "감자", "고구마", "토마토", "가지" };
            string vegi = string.Join("♡", array);
            Console.WriteLine(vegi);
        }
    }
}
