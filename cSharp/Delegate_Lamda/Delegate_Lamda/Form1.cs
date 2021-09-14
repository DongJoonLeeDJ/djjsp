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

namespace Delegate_Lamda
{
    public partial class Form1 : Form
    {
        //일종의 자료형을 하나 선언한 것
        //이 자료형은...
        //함수를 저장하는 자료형
        //매개변수랑 반환형이 없는 함수를 저장하는 자료형
        public delegate void TempFunc();
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("안녕");


            button1.Click -= button1_Click; //이벤트 빼는 것도 됨
            button1.Click += Button1_Click; //델리게이트

            //람다 이용해서 추가
            button1.Click += (object s, EventArgs e) =>
            {
                MessageBox.Show("메시지 박스 너무 지겹다");
            };
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 클릭시 이벤트 여러개 주렁주렁 추가 가능");
        }

        public void myFunc()
        {
            MessageBox.Show("Test");
        }
        public void iteratorFunction(TempFunc t, int count)
        {
            for (int i = 0; i < count; i++)
                t();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = "온창민";
            MessageBox.Show(p.Name);
            p.Sleep();

            Student s = new Student();
            s.Name = "이동준";
            s.study();
            s.Sleep();

            TempFunc ttt = myFunc;
            iteratorFunction(ttt, 3);

            TempFunc ttt2 = () => { MessageBox.Show("aaa"); };
            iteratorFunction(ttt2, 3);
            iteratorFunction(() => { MessageBox.Show("lamda"); }, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => { 
                for(int i = 0; i<50; i++)
                Console.Write("A");
            });
            Thread t2 = new Thread(
                () => {
                for (int i = 0; i < 50; i++)
                    Console.Write("B"); 
            }
                );

            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Form2().Show(); //뒤에꺼 선택가능 : 모달리스(Modeless)

            //Modal(모달)
            new Form2().ShowDialog(); //Message Box처럼 뒤에꺼 선택X

        }
    }
}
