using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleManager
{
    class Rectangle //class명은 대문자로 시작
    {
        public int mWidth; //m=멤버변수
        public int mHeight;

        public int Cal_Area()
        {
            if(mWidth <= 0)
            {
                MessageBox.Show("w가 0이하!");
                mWidth = 0;
            }
            if(mHeight <= 0)
            {
                MessageBox.Show("h가 0이하!");
                mHeight = 0;
            }
            return mWidth * mHeight;
        }
    }
}
