using System;

namespace Secretary {

    enum Gender {
        Male,
        Female
    }

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("안녕하세요. 반갑습니다.");
            Console.WriteLine ("당신의 이름은 무엇입니까? 알려주세요.");
            string userName = Console.ReadLine ();
            Console.WriteLine ($"{userName}님 반갑습니다.");

            Console.WriteLine ("저는 초기버전 인공지능이다보니 부족한 부분이 많습니다.");
            Console.WriteLine ("풀고 싶은 문제를 말씀하여 주시면 제가 풀어드리겠습니다. " +
                " 지금 지원되는 기능은 구구단, 현재 시간 알려드리기, 읽고 말하기 수열 구하기입니다.");
            Console.WriteLine ("입력 방식은 숫자 혹은 문제 이름의 핵심 키워드를 말해주세요.");
            Console.WriteLine ("예시) 구구단하기 = 구구단, 현재시간 구하기 = 시간,  읽고 말하기 = 개미수열, 읽고말하기수열");


            while (true) {
                Console.WriteLine ("무엇을 해보시겠습니까?");
                string input = Console.ReadLine ();
                if (input.Contains ("구구단")) {
                    Console.WriteLine ("구구단을 시작하겠습니다.");
                    gugudan();
                    Console.WriteLine ("구구단을 완성하였습니다.");

                } else if (input.Contains ("시간")) {
                    Console.WriteLine("현재는 " + DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초") + " 입니다.");

                } else if (input.Contains ("읽고") || input.Contains ("말하기") || input.Contains("개미")) {
                    antPattern();
                } else if(input.Contains("종료")) {
                    Console.WriteLine ("감사합니다. 또 이용해주세요^^");
                    break;
                } 
                else {
                    Console.WriteLine ("현재는 지원되지 않는 기능이오니 양해부탁드립니다.");
                    continue;
                }
            }

        }
        static void gugudan()
        {
            for(int i = 2; i < 10; i++)
            {
                for(int j = 1; j<10; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i*j}");
                }
            }
        }

        static void antPattern()
        {
            
            string start = "1";
             Console.WriteLine ("몇 번째 수열까지 구하실건가요? 숫자만 입력해주세요.");
            string input_s = Console.ReadLine();
            int.TryParse (input_s, out int input);
            Console.WriteLine ("시작");

            for (int i = 0; i < input; i++) {
                Console.WriteLine ($"{i+1}번째 : {start}");

                string end = "";
                char number = start[0];
                int count = 0;
                for (int j = 0; j < start.Length; j++) {
                    if (start[j] != number) {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    } else {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }
        }
    }
}