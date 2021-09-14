using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInheritance
{
    // 코드 7-4: Animal 클래스
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }

    // 코드 7-5: Animal 클래스의 상속을 받는 Dog 클래스와 Cat 클래스
    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

        // 코드 7-6: 부모에게서 상속 받은 메서드 호출
        public void Test()
        {
            Eat();
            Sleep();
        }
    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
