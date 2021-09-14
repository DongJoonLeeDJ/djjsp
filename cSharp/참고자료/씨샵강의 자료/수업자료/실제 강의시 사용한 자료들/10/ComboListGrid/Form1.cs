using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboListGrid
{
    public partial class Form1 : Form
    {
        List<Product> plist = new List<Product>();
        public Form1()
        {
            //List<Product> plist = new List<Product>();

            InitializeComponent();

            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 5000 });
            productBindingSource.Add(new Product() { Name = "토마토", Price = 1500 });

            plist.Add(new Product() { Name = "핸드폰", Price = 10000 });
            plist.Add(new Product() { Name = "컴퓨터", Price = 200000 });
            plist.Add(new Product() { Name = "자동차", Price = 5000000 });

            comboBox1.SelectedIndexChanged += DataSelected;
            listBox1.SelectedIndexChanged += DataSelected;

            //도서관리, 주차관리, 학생관리 스타일입니다.
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plist;
        }

        private void DataSelected(object sender, EventArgs e)
        { 
            if(sender is ComboBox)
            {
                ComboBox combo = (ComboBox)sender;
                Product product = (Product)combo.SelectedItem;
                MessageBox.Show($"재품명 : {product.Name}" +
                    $"{Environment.NewLine}" +
                                $"가격 : {product.Price}");
            }
            //else if(sender is ListBox)
            //{
            //    ListBox combo = (ListBox)sender;
            //    Product product = (Product)combo.SelectedItem;
            //    MessageBox.Show($"재품명 : {product.Name}" +
            //        $"{Environment.NewLine}" +
            //                    $"가격 : {product.Price}");
            //}
            //아무 것도 구현하지 않았다는 에러 메시지 입니다.
            //throw new NotImplementedException();

        }
    }
}
