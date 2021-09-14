using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capsule
{
    class Box
    {
        private int width;
        private int height;

        public int Tmp { get; set; } //public int Tmp;
        public int Tmp2 { get { return Tmp2; }
            set {
                if (value <= 0)
                {
                    MessageBox.Show("nono");
                }
                else
                {
                    Tmp2 = value;
                }
            } 
        }

        public Box(int w, int h)
        {
            Width = w;
            Height = h;
        }

        //c# 스타일
        public int Width {
            get {
                return width;
            }
            set
            {
                if(value <= 0)
                {
                    MessageBox.Show("!!!");
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Area()
        {
            //return Width * Height;
            return width * height;
        }


        //C++ 이나 javaStyle
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int wid)
        {
            width = wid;
        }
    }
}
