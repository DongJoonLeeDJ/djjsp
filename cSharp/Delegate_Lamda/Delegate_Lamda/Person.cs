using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lamda
{
    class Person
    {
        //java나 c++ 버전
        private string name_;
        public string getName() { return name_; }
        public void setName(string name) { name_ = name; }

        //c#에서의 get set
        private string name;
        public string Name { get => name; set => name = value; }
        
        //최종적인 축약형태
        public string name2 { get; set; }

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("드르르렁");
        }

        public Person()
        {

        }
    }
}
