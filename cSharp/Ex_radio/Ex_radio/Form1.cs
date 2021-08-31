using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Controls : Form 안에 있는 컨트롤들(=컴포넌트들)(=구성요소)
            foreach (var item in Controls)
            {
                Console.WriteLine(item.GetType());
                if(item is GroupBox)
                {
                    foreach (var i in (item as GroupBox).Controls)
                    {
                        Console.WriteLine(i.GetType());
                    }
                }
            }
        }
    }
}
