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

        //조상에 있는 원래 함수(=메소드)
        public virtual void Study()
        {
            System.Windows.Forms.MessageBox.Show("겅부겅부");
        }

        //값을 3가지 반환함
        //음수 : obj의 값보다 작은 경우
        // 0 : 같은 경우
        // 양수 : 더 큰 경우
        public int CompareTo(object obj)
        {
            return this.age.CompareTo((obj as Student).age);
            //throw new NotImplementedException();
        }
        public override string ToString()
        {

            //base : java에서의 super
            //return base.ToString();
            return $"이름:{name}, 나이:{age}, 학번:{hakbeon}";
        }
    }
}
