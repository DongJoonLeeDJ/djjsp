using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power
{
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }

        public void Print()
        {
            MessageBox.Show("메시지 출력");
        }
    }
}
