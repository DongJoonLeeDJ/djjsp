using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern;
using System.Collections;

namespace ExamObserverPattern2
{
    public partial class MainForm : Form, Subject
    {
        SubForm1 _subForm1 = null;
        SubForm2 _subForm2 = null;
        RemoveTest removeTest = null;
        IList _observers = new ArrayList(); //ArrayList가 IList라는 인터페이스를 구현했으므로
                                            //IList가 참조변수처럼 쓰일 수 있는거다.
                                            //ArrayList는 자바스크립트의 배열처럼 아무거나 다 들어감
        public MainForm()
        {
            InitializeComponent();

            _subForm1 = new SubForm1(this);
            _subForm1.TopLevel = false;
            _subForm1.FormBorderStyle = FormBorderStyle.None;
            _subForm1.Dock = DockStyle.Fill;
            panelTab1.Controls.Add(_subForm1);
            _subForm1.Show();

            _subForm2 = new SubForm2(this);
            _subForm2.TopLevel = false;
            _subForm2.FormBorderStyle = FormBorderStyle.None;
            _subForm2.Dock = DockStyle.Fill;
            panelTab2.Controls.Add(_subForm2);
            _subForm2.Show();


            removeTest = new RemoveTest(this, _subForm1); //sub1 지워보기
            removeTest.TopLevel = false;
            removeTest.FormBorderStyle = FormBorderStyle.None;
            removeTest.Dock = DockStyle.Fill;
            panelTab3.Controls.Add(removeTest); //탭페이지 위에 파넬을 추가해줘야 함
            removeTest.Show();
        }

        public void notifyObservers()
        {

            //통지한다라는 말을 쓰는데...
            //쉽게 말해서 옵저버 인터페이스에 지정해 둔 메소드들을
            //옵저버 인터페이스 추가한 녀석들이 모두 다 호출하는 것이다.
            foreach (Observer o in _observers)
                o.update(Convert.ToInt32(textBoxValue.Text));
        }

        public void registerObserver(Observer o)
        {
            //리스트 자체에는 아무거나 들어간다. 하지만 메소드의 매개변수 자체가
            //옵저버 인터페이스를 구현한 녀석들만 들어가게 한다.
            _observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            _observers.Remove(o);
        }
        //엔터쳐야지 반영됨
        private void TextBoxValue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int value = Convert.ToInt32(textBoxValue.Text);
                notifyObservers();
            }
        }
    }
}
