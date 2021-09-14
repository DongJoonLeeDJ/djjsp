using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_area_2.Text = "";
            button_calcArea.Text = "넓이";
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            //최신 스타일
            int.TryParse(textBox_w.Text, out int width);

            //옛날 스타일
            int height = 0;
            int.TryParse(textBox_h.Text, out height);

            //첫번째 스타일
            int area = Calculate_Area(width, height);
            label_area.Text = area.ToString();

            //두번째 스타일
            label_area.Text = Calculate_Area(width, height).ToString();
        }
        //두번째 스타일

        public int Calculate_Area(int w, int h)
        {
            if(w <= 0)
            {
                MessageBox.Show("너비 값이 0이하입니다.");
                w = 0;
            }
            if(h<=0)
            {
                MessageBox.Show("높이 값이 0이하입니다.");
                h = 0;
            }
            return w * h;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("야야야야야야야");
        }

        private void button_calcArea_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            int.TryParse(textBox_w.Text, out r.mWidth);
            int.TryParse(textBox_h.Text, out r.mHeight);

            Rectangle r2 = new Rectangle();
            int.TryParse(textBox_w.Text, out r2.mWidth);
            r2.mWidth = r2.mWidth * 2;
            int.TryParse(textBox_h.Text, out r2.mHeight);
            r2.mHeight = r2.mHeight * 2;

            label_area_2.Text = r.Cal_Area().ToString();
            MessageBox.Show(r2.Cal_Area() + "");
            //r2.Cal_Area() + "" = r2.Cal_Area().ToString()
        }
    }
}
