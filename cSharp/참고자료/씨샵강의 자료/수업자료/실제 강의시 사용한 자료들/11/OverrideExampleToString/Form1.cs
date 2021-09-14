using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverrideExampleToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Product p = new Product("감자", 1000);
            //p.printProduct();
            MessageBox.Show(p.ToString());


            //참고용
            int a = 100;
            double abc = 100.101;

            a.ToString();
            abc.ToString();
            //참고용
        }
    }
}
