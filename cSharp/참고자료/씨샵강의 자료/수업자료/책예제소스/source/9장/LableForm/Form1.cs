using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LableForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 레이블과 링크 레이블을 생성합니다.
            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 10),
            };
            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(10, 50)
            };

            // 요소에 이벤트를 연결합니다.
            linkLabel.Click += LabelClick;

            // 요소를 화면에 추가합니다.
            Controls.Add(label);
            Controls.Add(linkLabel);
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hanb.co.kr");    System.Diagnostics.Process.Start("notepad.exe");
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
