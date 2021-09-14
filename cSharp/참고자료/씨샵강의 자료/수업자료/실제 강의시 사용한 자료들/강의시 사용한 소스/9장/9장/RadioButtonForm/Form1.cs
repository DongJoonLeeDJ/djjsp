using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 라디오 버튼을 생성합니다.
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            Button button = new Button();

            // 요소의 속성을 설정합니다.
            radio1.Text = "감자";
            radio2.Text = "고구마";
            radio3.Text = "토마토";
            button.Text = "클릭";

            radio1.Location = new Point(10, 10);
            radio2.Location = new Point(10, 40);
            radio3.Location = new Point(10, 70);
            button.Location = new Point(10, 100);

            // 요소에 이벤트를 연결합니다.
            button.Click += ButtonClick;

            // 요소를 화면에 추가합니다.
            Controls.Add(radio1);
            Controls.Add(radio2);
            Controls.Add(radio3);
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        MessageBox.Show(radioButton.Text);
                    }
                }
            }
        }
    }
}
