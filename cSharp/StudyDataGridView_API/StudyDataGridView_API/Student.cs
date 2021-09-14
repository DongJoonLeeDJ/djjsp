using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDataGridView_API
{
    public class Student : IComparable
    {
        public string name { get; set; }
        public int age { get; set; }
        public string hakbeon { get; set; }

        public Student(string name, int age, string hakbeon)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
        }

        public int CompareTo(object obj)
        {
            return this.age.CompareTo((obj as Student).age);
            //throw new NotImplementedException();
        }
    }
}
