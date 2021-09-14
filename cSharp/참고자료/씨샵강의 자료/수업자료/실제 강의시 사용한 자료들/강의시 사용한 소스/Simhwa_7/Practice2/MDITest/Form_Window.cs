using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
    public partial class Form_Window : Form
    {
        public Form_Window()
        {
            InitializeComponent();
            IsMdiContainer = true;

            WindowForm1 form1 = new WindowForm1();
            form1.MdiParent = this;
            form1.Show();
            WindowForm2 form2 = new WindowForm2();
            form2.MdiParent = this;
            form2.Show();
            WindowForm3 form3 = new WindowForm3();
            form3.MdiParent = this;
            form3.Show();

        }
    }
}
