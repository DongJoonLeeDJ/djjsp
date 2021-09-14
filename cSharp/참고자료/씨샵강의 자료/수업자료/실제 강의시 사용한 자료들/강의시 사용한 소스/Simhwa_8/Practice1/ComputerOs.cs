using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class ComputerOs
    {
        public string MOsName; //소문자 m : 클래스의 멤버라는 의미

        public ComputerOs()
        {
            MOsName = "No OS";
        }

        public virtual void mPrint()
        {

        }
    }
}
