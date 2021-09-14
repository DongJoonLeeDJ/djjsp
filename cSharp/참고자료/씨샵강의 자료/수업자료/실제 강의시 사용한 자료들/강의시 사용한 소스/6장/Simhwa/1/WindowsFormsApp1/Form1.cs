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
        private int number = 0;
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(1, 11);
            Console.WriteLine(Environment.NewLine + number + Environment.NewLine);
        }

        private int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time > 5)
            {
                label2.Text = "TimeOver";
                time = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int choiceNumber);

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
                time = 0;
                MessageBox.Show("정답입니다.");
                number = new Random().Next(1, 11);
                Console.WriteLine(Environment.NewLine + number + Environment.NewLine);
                label2.Text = "Finished";
            }

        }
    }
}
