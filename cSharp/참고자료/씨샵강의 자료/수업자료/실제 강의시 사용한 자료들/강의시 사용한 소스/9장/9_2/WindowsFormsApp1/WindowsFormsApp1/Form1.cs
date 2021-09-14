using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        class Parent
        {

        }

        class TestClass : Parent, IBasic, IDisposable, IComparable
        {
            public int TestProperty 
            { 
                get 
                {
                    throw new NotImplementedException(); 
                } 
                set 
                { 
                    throw new NotImplementedException(); 
                } 
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }

        public Form1()
        {
            InitializeComponent();
            //IBasic basic = new IBasic();
            IBasic basic = new TestClass(); //다형성

        }
    }
}
