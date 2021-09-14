using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            // 한 번에 쓰고 읽기
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다");
            Console.WriteLine(File.ReadAllText(@"c:\a\test.txt"));

            // 스트림으로 쓰기
            using (StreamWriter writer = new StreamWriter(@"c:\test\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));

            // 스트림으로 읽기
            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
