using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lamda
{
    //name값을 기본으로 갖고 hakbeon을 추가로 갖는 클래스
    class Student : Person
    {
        public string hakbeon { get; set; }
        //sleep 기능에 이어서 study 기능도 추가된 클래스
        public void study() 
        {
            System.Windows.Forms.MessageBox.Show("공부하는 중...");
        }
    }
}
