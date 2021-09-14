using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{

    class SchoolStudent
    {
        public static int NumberOfMember = 0;
        public string name;
        public string id;
        public SchoolStudent() { NumberOfMember++; }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public static void removeNumberOfMember() { NumberOfMember = 0; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            SchoolStudent s1 = new SchoolStudent();
            s1.setName("송진영");
            s1.id = "123123";
            SchoolStudent s2 = new SchoolStudent();
            s2.setName("윤철희");
            s2.id = "111000";

            Console.WriteLine(s1.getName());
            Console.WriteLine("총원은 " + SchoolStudent.NumberOfMember+"명");
            SchoolStudent.removeNumberOfMember();
            Console.WriteLine("총원은 " + SchoolStudent.NumberOfMember + "명");

            //책 style
            Console.WriteLine(Multi(10,20));

            //위에 것과 동일한 스타일
            int temp = Multi(3, 4);
            Console.WriteLine(temp);

            //수학 애호가 클럽

            
            MyMath a = new MyMath();
            MyMath b = new MyMath();
            MyMath c = new MyMath();

            int member = MyMath.NumberOfMember;
            

        }
        static int Multi(int x, int y)
        {
            return x * y;
        }
    }



    class MyMath
    {
        //회원수
        public static int NumberOfMember = 0;

        public MyMath()
        {
            NumberOfMember++;
        }

        //파이
        public static double PI = 3.14;

        //절대값
        public static int Abs(int parameter)
        {
            if (parameter < 0)
            {
                parameter = parameter * -1;
            }
            return parameter;
        }
    }
}
