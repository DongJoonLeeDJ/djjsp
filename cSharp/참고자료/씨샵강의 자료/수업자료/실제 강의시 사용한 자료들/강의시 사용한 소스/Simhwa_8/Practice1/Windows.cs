using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    class Windows : ComputerOs
    {
        public new string mOsName;

        public string mConnectionTime
        {
            get
            {
                return DateTime.Now.ToString("yyyy/MM/dd    hh:mm:ss");
            }
        }

        public override void mPrint()
        {
            MessageBox.Show(mOsName + "의 아버지 빌 게이츠 : :) blue...sc....");
        }

        public Windows()
        {
            mOsName = "윈도우즈";
        }
    }
}
