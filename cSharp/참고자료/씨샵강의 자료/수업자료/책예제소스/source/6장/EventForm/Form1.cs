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

namespace EventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            FormClosed += Form1_FormClosed; ;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다!";
            Thread.Sleep(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";

        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            //textBox1.Text = elapsedTime + "초 경과";
            //label1.Text = elapsedTime + "초 경과";
        }
    }
}
