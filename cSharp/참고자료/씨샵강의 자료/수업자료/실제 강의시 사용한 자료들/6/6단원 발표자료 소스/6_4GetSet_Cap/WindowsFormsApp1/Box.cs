/*
 * internal 접근자는 외부에서의 접근은 제한하고 프로그래밍되는 어셈블리에서는 public 과 같은 효과를 갖게 하려고 할 때 사용합니다. 같은 어셈블리 내에서는 public, 다른 어셈블리에선 private 으로 되는셈이죠.

internal 접근자는 도움 클래스(Helper Class) 등을 만드는데 주로 사용됩니다.



출처: https://slaner.tistory.com/69 [꿈꾸는 프로그래머]
 */
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Box
    {
        private double width;
        public double mWidth
        {
            get
            {
                return width;
            }
            set
            {
                if(value <= 0)
                {
                    MessageBox.Show("너비 값은 0이상의 숫자여야 합니다!!!");
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }
        private double height;
        //public double mHeight { get ; set; }
        public double mHeight
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("높이 값은 0이상의 숫자여야 합니다!!!");
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area() { return this.width * this.height; }

        public Box(double w, double h)
        {
            mWidth = w;
            mHeight = h;
        }
    }
}