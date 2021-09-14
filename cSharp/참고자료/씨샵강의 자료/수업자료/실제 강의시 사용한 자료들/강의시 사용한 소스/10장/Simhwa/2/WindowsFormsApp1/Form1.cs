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
        public Form1()
        {
            InitializeComponent();
            Product product1 = new Product() { name = "감자", price = 100};
            Product product2 = new Product() { name = "고구마", price = 1000};
            Product product3 = new Product() { name = "광어", price = 10000};
            Product product4 = new Product() { name = "우럭", price = 20000};

            Product product5 = new Product() { name = "시금치", price = 150 };
            Product product6 = new Product() { name = "무", price = 10 };
            Product product7 = new Product() { name = "배추", price = 500 };

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

        private void button1_Click(object sender, EventArgs e)
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
        }

    }
}
