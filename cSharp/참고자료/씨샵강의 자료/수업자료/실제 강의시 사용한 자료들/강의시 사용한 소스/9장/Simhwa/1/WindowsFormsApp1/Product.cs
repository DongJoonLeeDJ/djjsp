using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Product : IBasic
    {
        public string name;
        public int price;

        public int TestProperty { get ; set; }
        public void TestInstanceMethod()
        {
            MessageBox.Show($"작물명 : {name}, 작물 가격 : {price}, 작물 고유 값 : {TestProperty}");
        }
    }
}
