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
    enum Scissors_Rock_Paper
    {
        가위, 바위, 보 //0 = 가위, 1 = 바위, 2 = 보
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.가위;

            Scissors_Rock_Paper choiceOfPc = (Scissors_Rock_Paper)new Random().Next(0, 3);

            label2.Text = mychoice.ToString();
            label3.Text = choiceOfPc.ToString();

            if(choiceOfPc == mychoice)
            {
                label6.Text = "비김";
            }
            else if(choiceOfPc == Scissors_Rock_Paper.바위)
            {
                label6.Text = "짐";
            }
            else //보
            {
                label6.Text = "이김";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.바위;

            Scissors_Rock_Paper choiceOfPc = (Scissors_Rock_Paper)new Random().Next(0, 3);

            label2.Text = mychoice.ToString();
            label3.Text = choiceOfPc.ToString();

            if (choiceOfPc == mychoice)
            {
                label6.Text = "비김";
            }
            else if (choiceOfPc == Scissors_Rock_Paper.보)
            {
                label6.Text = "짐";
            }
            else //가위
            {
                label6.Text = "이김";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.보;

            Scissors_Rock_Paper choiceOfPc = (Scissors_Rock_Paper)new Random().Next(0, 3);

            label2.Text = mychoice.ToString();
            label3.Text = choiceOfPc.ToString();

            if (choiceOfPc == mychoice)
            {
                label6.Text = "비김";
            }
            else if (choiceOfPc == Scissors_Rock_Paper.가위)
            {
                label6.Text = "짐";
            }
            else //바위
            {
                label6.Text = "이김";
            }
        }
    }
}
