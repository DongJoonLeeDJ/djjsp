using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            //Console.WriteLine(random.NextDouble());
            //            char randomchar = (char)random.Next('가', '힣');

            button1.Text = random.Next().ToString();

            Button button = new Button();
            //button.Location = new Point(100, 100);

            Point pt = new Point();
            pt.X = 500;
            pt.Y = 500;

            button.Location = pt;


            Controls.Add(button);


            for (int i = 0; i <5; i++)
            {
                Button button_temp = new Button();
                button_temp.Location = new Point(13, 50 + (23 + 3) * i);
                button_temp.Text = $"{i + 1}번째 생성";
                button_temp.Width = 300;

                Random rand = new Random();
                //bool visible = rand.NextDouble() > 0.5 ? true : false;
                bool visible = rand.Next(0, 2) == 0 ? false : true;

                Thread.Sleep(10);

                button_temp.Visible = visible;
                Controls.Add(button_temp);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Text = random.Next().ToString();
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("c# 수업 너무 재미있어요.");
        }
    }
}
