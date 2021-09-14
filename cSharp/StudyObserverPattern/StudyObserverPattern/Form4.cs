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
    public partial class Form4 : Form, IObserver
    {
        Form2 frm2;
        Form3 frm3;
        ISubject sub;
        public Form4(ISubject sub, Form2 frm2, Form3 frm3)
        {
            this.sub = sub;
            this.frm2 = frm2;
            this.frm3 = frm3;
            InitializeComponent();
        }

        public void update(string value)
        {
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub.register(frm2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sub.remove(frm2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sub.register(frm3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sub.remove(frm3);
        }
    }
}
