using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        // 연습문제 5-3: 클래스 선언 부분
        class Book
        {
            public string name;
            public DateTime publishedDate;
            public string author;
            public string owner;
            public string publisher;
            public string seniorEditor;
            public string producer;
            public string editor;
            public string designer;
        }

        static void Main(string[] args)
        {
            // 연습문제 5-3: 인스턴스 생성 부분
            Book book = new Book()
            {
                name = "PHP 프로그래밍 입문",
                publishedDate = new DateTime(2013, 5, 20),
                author = "황재호",
                owner = "김태헌",
                publisher = "한빛아카데미(주)",
                seniorEditor = "김현용",
                producer = "김이화",
                editor = "김이화",
                designer = "여동일"
            };

            // 연습문제 5-4
            Random random = new Random();
            int answer = random.Next();
            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                int input = int.Parse(Console.ReadLine());

                if (input > answer)
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                }
                else if (input < answer)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다...!");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
