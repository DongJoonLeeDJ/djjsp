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
    public partial class WindowForm1 : Form
    {
        private int number;
        public WindowForm1()
        {
            InitializeComponent();
            number = new Random().Next(1, 11); // 1 ~ 10
            Console.WriteLine(Environment.NewLine + number + Environment.NewLine);

            string test = "\n  \r";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out int choiceNumber);

            int j = int.Parse("123");

            if (choiceNumber > number)
            {
                MessageBox.Show("선택한 숫자가 더 큽니다.");
            }
            else if (choiceNumber < number)
            {
                MessageBox.Show("선택한 숫자가 더 작습니다.");
            }
            else
            {

                MessageBox.Show("정답입니다.");
                number = new Random().Next(1, 11);
                Console.WriteLine(Environment.NewLine + number + Environment.NewLine);
            }

        }
    }
}
