using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
    class MacWelcomeMessage : WelcomeMessage
    {
        public override void ShowWelcomeMessage()
        {
            if(DialogResult.No == MessageBox.Show("윈도우 환경에서 맥을 켜다니... 해킹토시를 깔았군. -_-+++", "Mac", MessageBoxButtons.YesNo))
            {
                MessageBox.Show("그럼 맥 pc에 윈도우를 깐거야!? 아이고 고객님 맥을 익혀주시면 감사하겠습니다.");
            }
        }

    }
}
