using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondWinform
{
    public partial class Form1 : Form
    {
        Label l_11 = new Label();
        public Form1()
        {
            List<int> example = new List<int>();
            example.Add(0);
            example.Add(7);
            example.Add(99);
            example.Add(101);

            example.RemoveAt(0);

            example.Remove(101);


            InitializeComponent();
            button_name.Text = "ldjgood12";
            Point p = new Point();
            p.X = 150;
            p.Y = 150;
            //button_name.Location = p;
            button_name.Location = new Point(100, 100);
            
            l_11.Text = "11";
            l_11.Location = p;
            //l_11.Location = new Point(150,150);
            Controls.Add(l_11);
        }

        private void button_name_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_example.Text);
            Random r = new Random();
            label1.Text = r.Next(1,100).ToString();
            label2.Text = r.Next(1, 100).ToString();
            label3.Text = r.Next(1, 100).ToString();
            label4.Text = r.Next(1, 100).ToString();
            label5.Text = r.Next(1, 100).ToString();
            label6.Text = r.Next(1, 100).ToString();
            label7.Text = r.Next(1, 100).ToString();
            label8.Text = r.Next(1, 100).ToString();
            label9.Text = r.Next(1, 100).ToString();
            label10.Text = r.Next(1, 100).ToString();
            l_11.Text = r.Next(1, 10000).ToString();
        }
    }
}
