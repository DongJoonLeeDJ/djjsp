using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaKaoApiMapView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MyLocale> mls = KaKaoAPI.Search(textBox1.Text);

            listBox1.Items.Clear();
            foreach (MyLocale item in mls)
            {
                listBox1.Items.Add(item); //가장 나중에 들어간 것이 가장 나중에 위치
                //listBox1.Items.Insert(0, item); //가장 첫번째 들어간 것이 가장 나중에 위치
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return; //엉뚱한 곳을 클릭하게 되면 이 함수를 실행하지 않음

            MyLocale ml = listBox1.SelectedItem as MyLocale;
            object[] ps = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", ps);


        }
    }
}
