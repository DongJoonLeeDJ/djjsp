using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2Click;
            //delegate = 대리자
            //익명 함수
            //함수의 변수화
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("델리궤이트");
            };

            //람다 = 델리게이트의 축약형
            button3.Click += 
            (object sender, EventArgs e) =>
            {
                MessageBox.Show("람다");
            };
            
        }

        private void button2Click(object sender, EventArgs e)
        {
            MessageBox.Show(button2.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button1.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //"다른 이름으로 저장"창이 뜸
            saveFileDialog1.Filter = "모든파일(*.*)|*.*|txt File(*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            int j = 0;
            try
            {
                int a = 10;
                int b = 0;
                j = int.Parse("asb");
                int c = a / b;
            }
            catch (FileLoadException)
            {

                MessageBox.Show("ㅎㅎㅎㅎ");
            }
            catch (Exception except)
            {
                MessageBox.Show("헉");
                MessageBox.Show(except.Message);
                MessageBox.Show(except.StackTrace);
                j = 0;
                //throw;
            }

            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
