using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customMath
{
    public partial class Form1 : Form
    {
        class MyMath
        {
            public static double PI = 3.141592;
        }
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(MyMath.PI.ToString());
            Close();
        }
    }
}
