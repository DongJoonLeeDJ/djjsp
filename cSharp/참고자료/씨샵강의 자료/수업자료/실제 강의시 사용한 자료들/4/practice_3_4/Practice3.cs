using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3_4
{
    class Practice3
    {
        public static void Answer_yearMonth_input()
        {
            Console.WriteLine("당신의 태어난 년도는?");
            int inputYear = int.Parse(Console.ReadLine());
            Console.WriteLine("당신이 태어난 월은?");
            int inputMonth = int.Parse(Console.ReadLine());

            switch (inputYear % 12)
            {
                case 0:
                    Console.WriteLine("원숭이 띠입니다."); 
                    break;
                case 1: 
                    Console.WriteLine("닭 띠입니다.");
                    break;
                case 2: 
                    Console.WriteLine("개 띠입니다.");
                    break;
                case 3: 
                    Console.WriteLine("돼지 띠입니다."); 
                    break;
                case 4: 
                    Console.WriteLine("쥐 띠입니다.");
                    break;
                case 5: 
                    Console.WriteLine("소 띠입니다."); 
                    break;
                case 6: 
                    Console.WriteLine("호랑이 띠입니다."); 
                    break;
                case 7: 
                    Console.WriteLine("토끼 띠입니다.");
                    break;
                case 8: 
                    Console.WriteLine("용 띠입니다."); 
                    break;
                case 9: 
                    Console.WriteLine("뱀 띠입니다."); 
                    break;
                case 10: 
                    Console.WriteLine("말 띠입니다."); 
                    break;
                case 11: 
                    Console.WriteLine("양 띠입니다."); 
                    break;
                //case 12는 절대 있을 수 없음!!!
            }

            if(inputMonth <= 0 || inputMonth >= 13)
            {
                Console.WriteLine("Fault Value!!!");
            }
            else
            {
                if (3 <= inputMonth && inputMonth <= 5)
                {
                    Console.WriteLine("봄입니다.");
                }
                else if (6 <= inputMonth && inputMonth <= 8)
                {
                    Console.WriteLine("여름입니다.");
                }
                else if (9 <= inputMonth && inputMonth <= 11)
                {
                    Console.WriteLine("가을입니다.");
                }
                else
                {
                    Console.WriteLine("겨울입니다.");
                }
            }
            Console.Write("올해는 ");

            switch (DateTime.Now.Year % 12)
            {
                case 0:
                    Console.Write("원숭이 띠입니다.");
                    break;
                case 1:
                    Console.Write("닭 띠입니다.");
                    break;
                case 2:
                    Console.Write("개 띠입니다.");
                    break;
                case 3:
                    Console.Write("돼지 띠입니다.");
                    break;
                case 4:
                    Console.Write("쥐 띠입니다.");
                    break;
                case 5:
                    Console.Write("소 띠입니다.");
                    break;
                case 6:
                    Console.Write("호랑이 띠입니다.");
                    break;
                case 7:
                    Console.Write("토끼 띠입니다.");
                    break;
                case 8:
                    Console.Write("용 띠입니다.");
                    break;
                case 9:
                    Console.Write("뱀 띠입니다.");
                    break;
                case 10:
                    Console.Write("말 띠입니다.");
                    break;
                case 11:
                    Console.Write("양 띠입니다.");
                    break;
                    //case 12는 절대 있을 수 없음!!!
            }

            Console.Write(" 그리고 이번 달은 ");
            switch (DateTime.Now.Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;

                default:
                    Console.WriteLine("Fault Value!");
                    break;
            }

        }
        public static void Answer_Sum_Without_Multiple(int n)
        {
            int output = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i%n != 0)
                    output += i;
            }
            Console.WriteLine("1~100까지 " + n + "의 배수를~~~");
            Console.WriteLine($"1~100까지 {n}의 배수를 제외한 합은 {output} 입니다.");
        }
        public static string Answer_Second_From_inputTime()
        {
            Console.Write("Input Total Second?");
            int time = int.Parse(Console.ReadLine());
            int minute = time / 60;
            int second = time % 60;
            string outputTime = string.Format("{0}min {1}sec", minute, second);
            return outputTime;
        }
    }
}
