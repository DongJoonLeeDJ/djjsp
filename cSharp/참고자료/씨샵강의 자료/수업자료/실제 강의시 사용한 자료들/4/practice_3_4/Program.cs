using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practice_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice3.Answer_yearMonth_input();
            Practice3.Answer_Sum_Without_Multiple(3);
            Console.WriteLine(Practice3.Answer_Second_From_inputTime());
            Practice4_alphabet();
            pyramid();
            maxMin();
            Console.WriteLine("읽고 말하기 수열(개미수열)의 몇 번째 값을 원하십니까?");
            int nth = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nth}번째 패턴은 {antPattern(nth)}입니다.");


            Console.WriteLine("안녕하세요. 반갑습니다.");
            Console.WriteLine("당신의 이름은 무엇입니까? 알려주세요.");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName}님 반갑습니다.");

            Console.WriteLine("저는 초기버전 인공지능이다보니 부족한 부분이 많습니다.");
            Console.WriteLine("풀고 싶은 문제를 말씀하여 주시면 제가 풀어드리겠습니다. " +
                " 지금 지원되는 기능은 구구단, 현재 시간 알려드리기, 읽고 말하기 수열 구하기입니다.");
            Console.WriteLine("입력 방식은 숫자 혹은 문제 이름의 핵심 키워드를 말해주세요.");
            Console.WriteLine("예시) 구구단하기 = 구구단, 현재시간 구하기 = 시간,  읽고 말하기 = 개미수열, 읽고말하기수열");


            while (true)
            {
                Console.WriteLine("무엇을 해보시겠습니까?");
                string input = Console.ReadLine();
                if (input.Contains("구구단"))
                {
                    Console.WriteLine("구구단을 시작하겠습니다.");
                    gugudan();
                    Console.WriteLine("구구단을 완성하였습니다.");

                }
                else if (input.Contains("시간"))
                {
                    Console.WriteLine("현재는 " + DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초") + " 입니다.");

                }
                else if (input.Contains("읽고") || input.Contains("말하기") || input.Contains("개미"))
                {
                    Console.WriteLine("읽고 말하기 수열(개미수열)의 몇 번째 값을 원하십니까?");
                    nth = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{nth}번째 패턴은 {antPattern(nth)}입니다.");
                }
                else if (input.Contains("종료"))
                {
                    Console.WriteLine("감사합니다. 또 이용해주세요^^");
                    break;
                }
                else
                {
                    Console.WriteLine("현재는 지원되지 않는 기능이오니 양해부탁드립니다.");
                    continue;
                }
            }


        }

        static void Practice4_alphabet()
        {
            Console.WriteLine("알파벳을 입력하세요.");
            string outputAlphabet = Console.ReadLine().ToLower();
            int[] alphabetPositionCheck = new int[26];

            for (int i = 0; i < outputAlphabet.Length; i++)
            {
                int idx = outputAlphabet[i] - 'a';
                alphabetPositionCheck[idx]++;
                if (alphabetPositionCheck[idx] == 1)
                {
                    Console.WriteLine($"{outputAlphabet[i]}는 {i + 1}번째에서 처음 등장합니다.");
                }
            }

            for (int i = 0; i < alphabetPositionCheck.Length; i++)
            {
                //! =
                if (alphabetPositionCheck[i] != 0)
                {
                    Console.WriteLine($"'{(char)('a' + i)}'는 {alphabetPositionCheck[i]}글자입니다.");
                }
            }

        }

        static void pyramid()
        {
            Console.WriteLine("몇 층 피라미드를 쌓겠느냐?");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++)
            {
                for (int j = floor-1; j >= i; j--)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void maxMin()
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                int input = int.Parse(Console.ReadLine());
                if (input < min) { min = input; }
                if (input > max) { max = input; }
            }

            Console.WriteLine($"max : {max}, min : {min}");
        }

        static string antPattern(int nth)
        {
            string start = "1"; //start : 내가 파악해야 하는 수열
            // 계산 시작
            for (int i = 1; i < nth; i++)
            {
                // 출력
                Console.WriteLine(i + "번째: " + start);

                // 읽고 말하기 수열 계산
                string end = ""; //누적값
                char number = start[0]; //내가 가리키는 number
                int count = 0; //그 number의 개수
                for (int j = 0; j < start.Length; j++)
                {
                    if (number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count; //start에 대하여 말하는 수열

                // 다음 단계 준비
                start = end;
            }
            return start;
        }

        static void gugudan()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }
            }
        }

    }
}
