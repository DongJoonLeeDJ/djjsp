using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Product product1 = new Product("감자", 1000);
            Product product2 = new Product("무", 100);

            string showtext = $"{product1.mId}:{product1.mName}" +
                $"\n{product2.mId}:{product2.mName}" +
                $"\n{Product.mCounter}개 생성되었습니다.";

            MessageBox.Show(showtext);
        }
    }
}
