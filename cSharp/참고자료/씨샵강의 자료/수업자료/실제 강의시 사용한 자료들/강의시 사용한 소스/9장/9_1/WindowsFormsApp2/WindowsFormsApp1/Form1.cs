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

        class Product : IComparable
        {
            public string name;
            public int price;

            public int CompareTo(object obj) //정렬해주는 메서드
            {
                //return this.price.CompareTo((obj as Product).price);
                return this.price.CompareTo(((Product)obj).price);//price를 기준으로 정렬
            }

            public override string ToString()//최상위단의 Object의 ToString을 덮어씀
            {
                return $"{name} : {price}원";
            }
        }
        public Form1()
        {
            InitializeComponent();

            //case 1
            List<Product> productlist1 = new List<Product>();

            Product product1 = new Product() { name = "고구마", price = 500};
            Product product2 = new Product() { name = "상추", price = 100};
            Product product3 = new Product() { name = "사과", price = 1500};
            Product product4 = new Product() { name = "감자", price = 150};
            Product product5 = new Product() { name = "겨울시금치", price = 1000};

            productlist1.Add(product1);
            productlist1.Add(product2);
            productlist1.Add(product3);
            productlist1.Add(product4);
            productlist1.Add(product5);

            //case 2
            List<Product> productlist2 = new List<Product>()
            {
                new Product() { name = "고구마", price = 500 },
                new Product() { name = "상추", price = 100 },
                new Product() { name = "사과", price = 1500 },
                new Product() { name = "감자", price = 150 },
                new Product() { name = "겨울시금치", price = 1000 }
            };

            for(int i = 0; i < productlist1.Count; i++)
            {
                Label label = new Label();
                label.Location = new Point(10, 10+(30*i));
                label.Text = productlist1[i].ToString();
                label.AutoSize = true;
                Controls.Add(label);
            }

            productlist1.Sort();


            for (int i = 0; i < productlist1.Count; i++)
            {
                Label label = new Label();
                label.Location = new Point(170, 10 + (30 * i));
                label.Text = productlist1[i].ToString();
                label.AutoSize = true;
                Controls.Add(label);
            }

        }
    }
}
