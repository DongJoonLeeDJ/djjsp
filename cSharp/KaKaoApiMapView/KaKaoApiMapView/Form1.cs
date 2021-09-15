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
                //listBox1.Items.Add(item);
                listBox1.Items.Insert(0, item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
