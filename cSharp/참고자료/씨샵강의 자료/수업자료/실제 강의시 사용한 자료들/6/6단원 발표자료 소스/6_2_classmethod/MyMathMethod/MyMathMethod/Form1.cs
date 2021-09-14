using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMathMethod
{
    public partial class Form1 : Form
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            public static double Abs(double input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_abs_Click(object sender, EventArgs e)
        {
            int result;
            int.TryParse(textBox_input.Text, out result);
            MessageBox.Show(MyMath.Abs(result).ToString());
            double value;
            double.TryParse(textBox_input.Text, out value);
            MessageBox.Show(MyMath.Abs(value).ToString());

        }
    }
}
