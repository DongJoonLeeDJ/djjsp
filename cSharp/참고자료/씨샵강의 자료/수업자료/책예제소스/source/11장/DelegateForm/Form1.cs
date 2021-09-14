using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // 버튼을 생성하고 설정합니다.
            Button button = new Button();
            button.Text = "버튼";
            button.Click += delegate (object sender, EventArgs args)
            {
                MessageBox.Show("무명 딜리게이트를 사용한 이벤트 연결입니다.");
            };
            button.Click += (sender, args) =>
            {
                MessageBox.Show("람다를 사용한 이벤트 연결입니다.");
            };

            // 버튼을 화면에 추가합니다.
            Controls.Add(button);
        }
    }
}
