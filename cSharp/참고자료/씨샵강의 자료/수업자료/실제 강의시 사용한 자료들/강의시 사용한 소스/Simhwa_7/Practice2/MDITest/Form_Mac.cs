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
    public partial class Form_Mac : Form
    {
        public Form_Mac()
        {
            InitializeComponent();
            AutoSize = true; //Form_Window는 Form에서 직접 설정함
            Width = 1070;
            Height = 660;
            IsMdiContainer = true;

            MacForm1 form1 = new MacForm1();
            form1.MdiParent = this;
            form1.Show();
            MacForm2 form2 = new MacForm2();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
