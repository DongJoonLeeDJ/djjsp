using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            label_area.Text = "-";
            double.TryParse(textBox_w.Text, out double wid);
            double.TryParse(textBox_h.Text, out double hei);
            Box box = new Box(wid, hei);
            if(box.mWidth == 0 || box.mHeight == 0)
            {
                return;
            }
            label_area.Text = box.Area().ToString();
        }
    }
}
