using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capsule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Box box1 = new Box();
            //box1.Width = 100;
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_w.Text, out int wi);
            int.TryParse(textBox_h.Text, out int he);
            Box box1 = new Box(wi, he);
            //box1.Width = 100;
            int test = box1.Width;
            MessageBox.Show(test.ToString());
            label_area.Text = box1.Area().ToString();
        }
    }
}
