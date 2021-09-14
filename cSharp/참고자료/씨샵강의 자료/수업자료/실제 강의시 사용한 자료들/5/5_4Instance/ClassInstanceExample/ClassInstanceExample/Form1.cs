using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInstanceExample
{
    public partial class Form1 : Form
    {
        class Product
        {
            public string name;
            public int price;
        }

        public Form1()
        {
            InitializeComponent();

            Product product = new Product() { name = "감자", price = 1000 };

            label_name.Text = product.name;
            label_price.Text = product.price.ToString() + "원";
        }
    }
}
