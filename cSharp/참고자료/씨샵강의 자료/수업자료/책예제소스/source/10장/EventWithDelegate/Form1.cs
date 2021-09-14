using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWithDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 코드 11-4: 무명 딜리게이트를 사용한 이벤트 연결
            // 버튼을 생성합니다.
            Button buttonA = new Button();

            // 버튼의 속성을 지정합니다.
            buttonA.Text = "버튼";
            buttonA.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("딜리게이트");
            };

            // 버튼을 화면에 출력합니다.
            Controls.Add(buttonA);

            // 코드 11-5: 클로저
            // 변수를 선언합니다.
            int closerVariable = 52273;

            // 버튼을 생성합니다.
            Button buttonB = new Button();
            buttonB.Top = 30;

            // 버튼의 속성을 지정합니다.
            buttonB.Text = "버튼";
            buttonB.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("딜리게이트: " + closerVariable);
            };

            // 버튼을 화면에 출력합니다.
            Controls.Add(buttonB);
        }
    }
}
