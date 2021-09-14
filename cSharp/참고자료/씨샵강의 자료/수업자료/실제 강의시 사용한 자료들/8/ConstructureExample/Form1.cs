using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructureExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Product proudct1 = new Product();
            Product product1 = new Product("감자", 1000);
            MessageBox.Show($"{product1.mName}의 " +
                $"가격은 {product1.mPrice}원입니다.");

        }
    }
}
