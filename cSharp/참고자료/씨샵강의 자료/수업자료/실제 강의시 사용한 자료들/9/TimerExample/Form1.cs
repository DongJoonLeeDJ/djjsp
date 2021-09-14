using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            DialogResult result;
            do
            {
                result =
                    MessageBox.Show
                    ("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //button1.Text = count.ToString();
            //count++;
            button1.Text 
            = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Show(); //모달리스(Modeless)
            f.ShowDialog();//모달(Modal)
        }
    }
}
