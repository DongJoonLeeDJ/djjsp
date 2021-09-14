using System;
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
    public partial class Form2 : Form, IObserver
    {
        public Form2(ISubject sub)
        {
            //sub의 register 호출한다. -> ISubject 인터페이스를 구현하고 있는 객체의 register를 호출한다.
            //Form1은 ISubject 인터페이스가 구현되어 있고, 그러므로 Form1의 regester를 호출한다는 소리임
            sub.subscribe(this); 
            InitializeComponent();
        }

        public void update(string value)
        {
            textBox1.Text = value;
            //throw new NotImplementedException();
        }
    }
}
