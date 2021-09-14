using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    class Mac : ComputerOs
    {
        public new string mOsName;
        private long mCdKey;

        public long CdKey //get set 생성자의 경우에는 앞에 m을 붙이지 않았으나, 회사마다 다를 수 있음
        {
            get
            {
                return mCdKey;
            }
            set
            {
                mCdKey = value;
            }
        }

        public override void mPrint()
        {
            MessageBox.Show(mOsName + "의 아버지 스티브 잡스 : 삼성 갤럭시 너 고소!");
        }

        public Mac(long cdkey)
        {
            mOsName = "매킨토시";
            mCdKey = cdkey;
        }
    }
}
