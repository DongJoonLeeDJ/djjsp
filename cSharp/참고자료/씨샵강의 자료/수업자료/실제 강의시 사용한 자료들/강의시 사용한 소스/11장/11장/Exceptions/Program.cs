using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        // 코드 10-5: finally 구문을 사용하지 않은 코드
        static void WithOutFinally()
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
            Console.WriteLine("프로그램이 종료되었습니다.");        
        }

        // 코드 10-6: finally 구문 사용
        static void WithFinally()
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
                return;
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }

        // 코드 10-12: 사용자 정의 예외
        class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            {

            }
        }
        
        static void Main(string[] args)
        {
            // 코드 10-5 호출
            WithOutFinally();
            Console.WriteLine();

            // 코드 10-6 호출
            WithFinally();
            Console.WriteLine();

            // 코드 10-12 호출
            try
            {
                throw new CustomException("사용자 정의 예외");
            }
            catch (CustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
