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

        public static int mMaxArea = 100;
        public static int mMinArea = 1;
        private static int temp = 1;
        public static bool check_Area(int area)
        {
            if(area > mMaxArea)
            {
                MessageBox.Show("너무 넓습니다.");
                return false;
            }
            if(area < mMinArea)
            {
                MessageBox.Show("너무 좁습니다.");
                return false;
            }
            return true;
        }
    }
}
