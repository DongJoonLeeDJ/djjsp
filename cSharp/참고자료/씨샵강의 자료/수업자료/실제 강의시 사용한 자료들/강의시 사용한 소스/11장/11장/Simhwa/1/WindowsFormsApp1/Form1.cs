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
        private int number;
        private delegate bool PrintProcess();
        int choiceNumber;

        bool FindResult()
        {
            if (choiceNumber > number)
            {
                MessageBox.Show("선택한 숫자가 더 큽니다.");
                return false;
            }
            else if (choiceNumber < number)
            {
                MessageBox.Show("선택한 숫자가 더 작습니다.");
                return false;
            }
            else
            {
                number = new Random().Next(1, 11);
                label_answer.Text = number.ToString();
                return true;
            }
        }

        bool Print(PrintProcess process) //bool을 리턴하고 매개변수 없는 함수를 매개변수로 받아와서 동작 수행하는 함수
        {
            if(process())
            {
                MessageBox.Show("정답!");
                return true;
            }
            else
            {
                MessageBox.Show("오답!");
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            number = r.Next(1, 11); // 1 ~ 10
            label_answer.Text = number.ToString();
        }

        private void button_check_Click(object sender, EventArgs e)
        {

            bool valueresult = int.TryParse(textBox_input.Text, out choiceNumber);

            if (!valueresult)
            {
                MessageBox.Show("유효한 값이 아닙니다.");
                return;
            }

            //case 1
            //Print(
            //    () =>
            //    {
            //        if (choiceNumber > number)
            //        {
            //            MessageBox.Show("선택한 숫자가 더 큽니다.");
            //            return false;
            //        }
            //        else if (choiceNumber < number)
            //        {
            //            MessageBox.Show("선택한 숫자가 더 작습니다.");
            //            return false;
            //        }
            //        else
            //        {
            //            number = new Random().Next(1, 11);
            //            label_answer.Text = number.ToString();
            //            return true;
            //        }
            //    }
            //);

            //case 2
            //PrintProcess example = delegate ()
            //{
            //    if (choiceNumber > number)
            //    {
            //        MessageBox.Show("선택한 숫자가 더 큽니다.");
            //        return false;
            //    }
            //    else if (choiceNumber < number)
            //    {
            //        MessageBox.Show("선택한 숫자가 더 작습니다.");
            //        return false;
            //    }
            //    else
            //    {
            //        number = new Random().Next(1, 11);
            //        label_answer.Text = number.ToString();
            //        return true;
            //    }
            //};

            //Print(example);

            //case 3
            PrintProcess example2 = FindResult;
            Print(example2);
        }
    }
}
