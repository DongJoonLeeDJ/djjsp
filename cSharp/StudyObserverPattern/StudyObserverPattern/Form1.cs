using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyObserverPattern
{
    public partial class Form1 : Form, ISubject
    {

        //IList 인터페이스가 적용되어 있는 객체 리스트
        IList _observers = new ArrayList();

        //java로 치면...
        //ArrayList<IObserver> obs = new ArrayList<IObserver>();
        List<IObserver> obs = new List<IObserver>();

        public Form1()
        {
            InitializeComponent();

            //C#에서의 ArrayList = javaScript의 배열

            //하나의 리스트에 여러가지 자료형이 담김
            ArrayList example = new ArrayList();
            example.Add(1);
            example.Add("aaaa");

            //C#에서의 List와 자바에서의 ArrayList가 똑같음
        }

        public void notify()
        {
            throw new NotImplementedException();
        }

        public void register(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void remove(IObserver o)
        {
            throw new NotImplementedException();
        }
    }
}
