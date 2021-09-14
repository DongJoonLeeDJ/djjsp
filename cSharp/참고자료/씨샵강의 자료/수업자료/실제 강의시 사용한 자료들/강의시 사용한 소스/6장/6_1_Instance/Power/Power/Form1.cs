using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Test().Print(); //프로그램 실행하자마자 Print 함수 호출
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_num1.Text, out int parameter); //string을 int로 바꾸는 기능. 예외처리가 내장되어 있음
            Test test = new Test();
            int result = test.Power(parameter);
            label_power.Text = result.ToString();
            
        }

        private void button2_multi_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_multi_num1.Text, out int parameter1);
            int.TryParse(textBox_multi_num2.Text, out int parameter2);
            Test test = new Test();
            int result = test.Multi(parameter1, parameter2);
            label_multi.Text = result.ToString();
        }
    }
}
