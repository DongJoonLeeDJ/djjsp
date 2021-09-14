using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력: ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력 숫자: " + index);
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine(exception.GetType());
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }
    }
}
