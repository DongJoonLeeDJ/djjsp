using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAttributes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button의 글자 위치 옮기기
            button1.TextAlign = ContentAlignment.TopRight;

            //StringBuilder 활용하여 String의 특정 글자 바꾸기
            String next = "asdf";
            StringBuilder t = new StringBuilder(next);
            t[0] = '1';
            next = t.ToString();
            MessageBox.Show(next);

            //UserControl이 도구 상자에 자동으로 나타나게 하기
            //도구->옵션->Windows Form 디자이너 -> 도구상자 -> 도구상자 자동채우기
        }
    }
}
