using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExample
{
    public class Student
    {
        public string name;
        public int age;
        public string id;

        public override string ToString()
        {
            return "학번 : " + name + "나이 : " + age + "학번 : " + id;
        }
    }
}
