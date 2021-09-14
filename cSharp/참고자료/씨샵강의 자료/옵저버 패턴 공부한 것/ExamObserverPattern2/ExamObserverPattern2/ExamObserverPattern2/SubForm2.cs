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

namespace ExamObserverPattern2
{
    public partial class SubForm2 : Form, Observer
    {
        Subject _subject;
        public SubForm2(Subject subject)
        {
            _subject = subject;
            subject.registerObserver(this);
            InitializeComponent();
        }
        public SubForm2()
        {
            InitializeComponent();
        }

        public void update(int value)
        {
            textBoxValue.Text = value.ToString();
        }
    }
}
