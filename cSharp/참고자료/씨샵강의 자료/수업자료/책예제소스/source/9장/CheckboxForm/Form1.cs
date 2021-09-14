using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 라디오 버튼을 생성합니다.
            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            CheckBox checkBox3 = new CheckBox();
            Button button = new Button();

            // 요소의 속성을 설정합니다.
            checkBox1.Text = "감자";
            checkBox2.Text = "고구마";
            checkBox3.Text = "토마토";
            button.Text = "클릭";

            checkBox1.Location = new Point(10, 10);
            checkBox2.Location = new Point(10, 40);
            checkBox3.Location = new Point(10, 70);
            button.Location = new Point(10, 100);

            // 요소에 이벤트를 연결합니다.
            button.Click += ButtonClick;

            // 요소를 화면에 추가합니다.
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            // 리스트를 생성합니다.
            List<string> list = new List<string>();

            // 리스트에 체크된 요소를 추가하고자 반복을 돌립니다.
            foreach (var item in Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            // 리스트를 붙여 문자열을 만듭니다.
            MessageBox.Show(string.Join(",", list));
        }
    }
}
