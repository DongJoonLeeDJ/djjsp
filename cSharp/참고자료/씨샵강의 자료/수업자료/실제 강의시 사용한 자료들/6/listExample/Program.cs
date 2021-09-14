using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenst = new List<Student>();
            /*
             
             
        string name;
        int age;
        string id;
             */

            for (int i = 0; i < 3; i++)
            {
                string tempName = Console.ReadLine();
                int tempAge = int.Parse(Console.ReadLine());
                string tempId = Console.ReadLine();
                Student tempStudent = new Student() { name = tempName, age = tempAge, id = tempId };
                studenst.Add(tempStudent);
            }
            for (int i = 0; i < studenst.Count; i++)
            {

                Console.WriteLine(studenst[i].name + "     " + studenst[i].age + "     " + studenst[i].id);
                Console.WriteLine(studenst[i]);
            }
        }
    }
}
