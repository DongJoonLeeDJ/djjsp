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
    public partial class MacForm2 : Form
    {
        public MacForm2()
        {
            InitializeComponent();
        }
        private int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > limitTime || timer == -1)
            {
                label2.Text = "Game Over!!!";
                timer = 0;
                timer1.Enabled = false;
            }
            timer++;
        }
        private int limitTime = 0;
        int answer = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer = 0;
            label2.Text = "Game Start!";
            answer = new Random().Next(1, 26);
            Console.WriteLine("answer : " + answer);
            int cout = 1; //순차적으로 text 써줌
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    Point point = new Point();
                    point.X = 13 + 100 * j;
                    point.Y = 13 + 13 + (23 + 3) * i;
                    button.Location = point;
                    button.Click += Button_Click;
                    button.Text = cout.ToString();

                    cout++;

                    Controls.Add(button);
                }
            }


            timer1.Enabled = true;
            //if(!int.TryParse(textBox1.Text, out limitTime))
            if (int.TryParse(textBox1.Text, out limitTime) == false)
            {
                timer = -1;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == answer.ToString())
            {
                label2.Text = "You Win!!!";
                timer = 0;
                timer1.Enabled = false;
            }
            else
            {
                label2.Text = "This is not treasure!!!";
            }
        }
    }
}
