using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
     class WindowWelcomeMessage : WelcomeMessage
    {
        public override void ShowWelcomeMessage()
        {
            MessageBox.Show("윈도우즈에 오신 것을 환영합니다!");
        }
    }
}
