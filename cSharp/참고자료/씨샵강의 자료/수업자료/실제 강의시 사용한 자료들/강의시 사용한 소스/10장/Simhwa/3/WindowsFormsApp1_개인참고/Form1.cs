using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Product> Products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            Product product1 = new Product() { name = "감자", price = 100};
            Products.Add(product1);
            Product product2 = new Product() { name = "고구마", price = 1000};
            Products.Add(product2);
            Product product3 = new Product() { name = "광어", price = 10000};
            Products.Add(product3);
            Product product4 = new Product() { name = "우럭", price = 20000};
            Products.Add(product4);

            Product product5 = new Product() { name = "시금치", price = 150 };
            Products.Add(product5);
            Product product6 = new Product() { name = "무", price = 10 };
            Products.Add(product6);
            Product product7 = new Product() { name = "배추", price = 500 };
            Products.Add(product7);

            groupBox1.Text = "식물";
            groupBox2.Text = "물고기";

            radioButton1.Text = product1.name;
            radioButton2.Text = product2.name;
            radioButton3.Text = product3.name;
            radioButton4.Text = product4.name;

            checkBox1.Text = product5.name;
            checkBox2.Text = product6.name;
            checkBox3.Text = product7.name;

        }

        private void clickevent()
        {
            string selected_plant;
            if(radioButton1.Checked)
            {
                selected_plant = radioButton1.Text;
            }
            else
            {
                selected_plant = radioButton2.Text;
            }
            string selected_fish;
            if (radioButton3.Checked)
            {
                selected_fish = radioButton3.Text;
            }
            else
            {
                selected_fish = radioButton4.Text;
            }

            List<string> list = new List<string>();

            foreach(var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if(checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            if(list.Count > 0)
            {
                LogClass.PrintLog(@"D:\test", "test.txt",
                    $"식물은 {selected_plant}, 물고기는 {selected_fish}를 선택하셨습니다. " +
                    $"그리고 {string.Join(",", list)}를 추가 구매 원하십니다.");

            }
            else
            {
                LogClass.PrintLog(@"D:\test", "test.txt",
                    $"식물은 {selected_plant}, 물고기는 {selected_fish}를 선택하셨습니다. ");

            }

            //productBindingSource.Add(new Product() { name = "감자", price = 500 });


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                productBindingSource.Add(Products[0]);
            }
            clickevent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
            {
                productBindingSource.Add(Products[1]);
            }
            clickevent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked) 
            {

                productBindingSource.Add(Products[2]);
            }
            clickevent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
            {

                productBindingSource.Add(Products[3]);
            }
            clickevent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {

                productBindingSource.Add(Products[4]);
            }
            clickevent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {

                productBindingSource.Add(Products[5]);
            }
            clickevent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {

                productBindingSource.Add(Products[6]);
            }
            clickevent();
        }
    }
}
