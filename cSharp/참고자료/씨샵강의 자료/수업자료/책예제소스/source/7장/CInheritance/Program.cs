using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInheritance
{
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 코드 7-8: 코드 중복
            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();
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

            // 코드 7-9: 다형성을 사용한 코드 중복 해결
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                
                // 코드 7-10: 무작정 변환해서 호출
                // 예외가 발생하므로 주석 처리
                // ((Cat)item).Meow();
            }

            // 코드 7-12: Object 객체의 다형성 예제(1)
            List<Object> listOfObjectA = new List<Object>();
            listOfObjectA.Add(new Dog());
            listOfObjectA.Add(new Cat());

            // 코드 7-13: Object 객체의 다형성 예제(2)
            List<Object> listOfObjectB = new List<Object>();
            listOfObjectB.Add(new Dog());
            listOfObjectB.Add(new Cat());
            listOfObjectB.Add(52);
            listOfObjectB.Add(52l);
            listOfObjectB.Add(52.273f);
            listOfObjectB.Add(52.273);
        }
    }
}