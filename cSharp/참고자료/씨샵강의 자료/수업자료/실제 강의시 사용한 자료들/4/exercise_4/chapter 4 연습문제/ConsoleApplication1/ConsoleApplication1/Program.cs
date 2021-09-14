using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j>=i; j--)
                {
                    Console.Write(" "); //공백은 밑으로 갈수록 줄어듭니다.
                }

                for(int j = 0; j<2*i+1; j++)
                {
                    Console.Write("*"); //<| 이 모양 삼각형의 2배라고 보면 됩니다. 그래서 해당 칸에 * 그릴 때 2배를 더 그립니다.
                }
                Console.WriteLine();
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자를 입력해주세요");
                int input = int.Parse(Console.ReadLine());
                if (input < min) { min = input; }
                if (input > max) { max = input; }
            }

            Console.WriteLine($"max : {max} \n min : {min}");
            
                string start = "1";
                //Console.WriteLine("input");
                //string input_s = Console.ReadLine();
                //int.TryParse(input_s, out int input);
                Console.WriteLine("start");

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"{i + 1}번째 : {start}");

                    string end = "";
                    char number = start[0];
                    int count = 0;
                    for (int j = 0; j < start.Length; j++)
                    {
                        if (start[j] != number)
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
                    end = end + number + count;
                    start = end;
                }

                //1                         = 1
                //1이 1개                   = 11
                //1이 2개                   = 12
                //1이 1개, 2가 1개          = 1121
                //1이 2개 2가 1개 1이 1개   = 122111
                //1이 1개 2가 2개 1이 3개   = 112213

                Console.WriteLine("End");
           

        }
    }
}
