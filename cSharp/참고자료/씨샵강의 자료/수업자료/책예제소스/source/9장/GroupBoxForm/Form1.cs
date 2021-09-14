using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 라디오 버튼을 생성합니다.
            GroupBox groupBox1 = new GroupBox();
            GroupBox groupBox2 = new GroupBox();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            Button button = new Button();

            // 요소의 속성을 설정합니다.
            groupBox1.Text = "식물";
            groupBox2.Text = "물고기";
            radio1.Text = "감자";
            radio2.Text = "고구마";
            radio3.Text = "광어";
            radio4.Text = "우럭";
            button.Text = "클릭";

            groupBox1.Size = new Size(120, 100);
            groupBox2.Size = new Size(120, 100);

            groupBox1.Location = new Point(10, 10);
            groupBox2.Location = new Point(140, 10);

            radio1.Location = new Point(10, 30);
            radio2.Location = new Point(10, 60);
            radio3.Location = new Point(10, 30);
            radio4.Location = new Point(10, 60);
            button.Location = new Point(10, 120);

            // 요소에 이벤트를 연결합니다.
            button.Click += ButtonClick;

            // 라디오버튼을 그룹박스에 추가합니다.
            groupBox1.Controls.Add(radio1);
            groupBox1.Controls.Add(radio2);

            groupBox2.Controls.Add(radio3);
            groupBox2.Controls.Add(radio4);

            // 요소를 화면에 추가합니다.
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            foreach (var outerItem in Controls)
            {
                if (outerItem is GroupBox)
                {
                    foreach (var innerItem in ((GroupBox)outerItem).Controls)
                    {
                        RadioButton radioButton = innerItem as RadioButton;
                        if (radioButton != null && radioButton.Checked)
                        {
                            MessageBox.Show(radioButton.Text);
                        }
                    }
                }
            }
        }
    }
}
