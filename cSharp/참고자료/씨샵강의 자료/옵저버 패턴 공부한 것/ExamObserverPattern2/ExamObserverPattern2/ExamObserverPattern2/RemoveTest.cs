using ObserverPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamObserverPattern2
{
    public partial class RemoveTest : Form, Observer
    {
        SubForm1 sb1;
        SubForm2 sb2;
        Subject subject;
        //생성자 오버로딩


        //여기선 구독 추가 및 삭제를 구독자들이 마음대로 한다.
        //주체를 제공자로 잡고 싶었다면 Main에서 바로 실행하면 된다.(observers 리스트에서 바로 remove or add 하기)
        
        public RemoveTest(Subject subject, SubForm1 sb1)
        {
            this.subject = subject;
            this.sb1 = sb1;
            InitializeComponent();
        }
        public RemoveTest()
        {
            InitializeComponent();
        }

        public void update(int value)
        {
            Console.WriteLine("!!!!");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //옵저버 리스트에 subform1 추가
            this.subject.registerObserver(sb1); //Observer를 구현한 녀석 아무나 들어오면 됨
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            //옵저버 리스트에 subform1 제거
            //이 모든 걸 할 수 있는 이유는 subform1이 Observer 인터페이스를 상속받고있다.

            this.subject.removeObserver(sb1); //Observer를 구현한 녀석 아무나 들어오면 됨
        }
    }
}
