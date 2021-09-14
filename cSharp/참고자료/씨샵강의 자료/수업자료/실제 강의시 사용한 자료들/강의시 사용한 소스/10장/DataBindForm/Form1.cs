using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "사과", Price = 700 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 400 });
            productBindingSource.Add(new Product() { Name = "배추", Price = 600 });
            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });

            comboBox1.SelectedIndexChanged += DataSelect;
            listBox1.SelectedIndexChanged += DataSelect;
        }

        private void DataSelect(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                Product product = (Product)comboBox.SelectedItem;
                MessageBox.Show(comboBox.SelectedValue.ToString());
                MessageBox.Show(product.Name + " : " + product.Price);
            }
            else if (sender is ListBox)
            {
                ListBox listBox = (ListBox)sender;
                Product product = (Product)listBox.SelectedItem;
                MessageBox.Show(listBox.SelectedValue.ToString());
                MessageBox.Show(product.Name + " : " + product.Price);
            }
        }
    }
}
