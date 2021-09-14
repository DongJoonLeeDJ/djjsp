using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button_test_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            //button2.AutoSize = true;
            //button2.Text += "+";
            Random r = new Random();
            //label_number.Text = r.Next(1, 10).ToString();

            Point pos_temp = new Point();
            pos_temp.X = 100;
            pos_temp.Y = 100;
            foreach (var item in Controls)
            {
                if(item is Label)
                {
                    if( (item as Label).Location == pos_temp)
                    {
                        Controls.Remove(item as Control);
                    }
                }
            }

            button_test.Text = "ldj";
            Label l1 = new Label();

            //Controls.Remove(l1);
            l1.Text = r.Next(1, 10).ToString();

            Point pos = new Point();
            pos.X = 100;
            pos.Y = 100;

            l1.Location = pos;

            Controls.Add(l1);


        }
    }
}
