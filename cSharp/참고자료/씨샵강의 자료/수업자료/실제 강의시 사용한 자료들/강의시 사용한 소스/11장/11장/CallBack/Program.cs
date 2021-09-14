using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string name, double score)
        {
            this.Name = name;
            this.Score = score;
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Score;
        }
    }

    class Students
    {
        private List<Student> listOfStudent = new List<Student>();

        public delegate void PrintProcess(Student list); //PrintProcess 타입 변수를 통하여 리턴타입이 void이면서 매개변수가 Student 타입인 함수를 매개변수로 사용할 수 있게 된 것임

        public PrintProcess protoss = (student) => {
            Console.WriteLine("!@!");
            Console.WriteLine("델리게이터 이해하자 아자자아자");
            Console.WriteLine("!@!");
        };


        public PrintProcess zerg = (student) => {
            Console.WriteLine();
            Console.WriteLine("z-----z");
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Score);
            Console.WriteLine("z-----z");
            Console.WriteLine();
        };

        public PrintProcess terran = printstudent2;

        public PrintProcess honjong = (student) => { Console.WriteLine("..."); };

        public void Add(Student student)
        {
            listOfStudent.Add(student);
        }

        public void Print() //콜백 : 콜백은 함수를 직접 호출하지 않고 다른 함수가 대신 호출하게 하는 것입니다.
        {
            Print((student) =>
            {
                Console.WriteLine(student);
            }); 
        } //print()를 호출하면 print는 print(PrintProcess process)를 선언한다.

        public void print2()
        {
            Print(printstudent);
        }

        public void Print(PrintProcess process)
        {
            foreach (var item in listOfStudent)
            {
                process(item);
            }
        }

        public void printstudent(Student stu)
        {
            Console.WriteLine(stu);
        }

        public static void printstudent2(Student stu)
        {
            Console.WriteLine(stu);
        }

        public void test()
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("윤인성", 4.2));
            students.Add(new Student("연하진", 4.4));

            students.Print();
            students.print2();
            students.Print((student) =>
            {
                Console.WriteLine();
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("학점: " + student.Score);
            });
            students.Print(students.protoss);
            students.Print(students.zerg);
            students.Print(students.terran);

            Console.WriteLine("!-------------!");
            Students.PrintProcess terran222 = students.printstudent;
            students.Print(terran222);
            Console.WriteLine("!-------------!");

            Console.WriteLine("!~~~~~~~~~~~~!");

            Student example = new Student("이동준", 100);
            students.zerg(example);

            Console.WriteLine(1);

        }
    }
}
