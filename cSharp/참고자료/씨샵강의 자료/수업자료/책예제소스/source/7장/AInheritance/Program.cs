using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AInheritance
{
    // 코드 7-1: Dog 클래스
    class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }

    // 코드 7-2: Cat 클래스
    class Cat
    {
        public int Age { get; set; }

        public Cat() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }

    class Program
    {
        // 코드 7-3: {{Dog}} 클래스와 {{Cat}} 클래스의 인스턴스를 만들고 메서드 실행
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
}
