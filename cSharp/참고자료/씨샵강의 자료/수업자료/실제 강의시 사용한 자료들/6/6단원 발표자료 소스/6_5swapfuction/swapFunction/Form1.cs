using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swapFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_a1.Text, out int a);
            int.TryParse(textBox_b1.Text, out int b);
            swapFuction(ref a, ref b);
            textBox_a2.Text = a.ToString();
            textBox_b2.Text = b.ToString();
        }

        private void swapFuction(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString());
        }
    }
}
