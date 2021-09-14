using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiExample
{
    public partial class Form1 : Form
    {
        class CustomForm : Form { }
        public Form1()
        {
            InitializeComponent();
            //1. 부모에 해당하는 폼에서 자신을 Mdi 컨테이너라고 지정해야 함
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.MdiParent = this; //2. 자식에 해당하는 폼 호출할 때, 부모를 지정한다.
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }
    }
}
