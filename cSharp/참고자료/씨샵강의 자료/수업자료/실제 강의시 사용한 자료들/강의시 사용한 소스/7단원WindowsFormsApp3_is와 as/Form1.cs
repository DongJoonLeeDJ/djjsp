using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in Controls)
            {
                //04 03 Ver
                //if (item.GetType() == typeof(Button))
                //{
                //    if (((Button)item).Text.Contains("번째"))
                //    {
                //        ((Button)item).Visible = false;
                //    }
                //}

                ////is 활용
                //if (item is Button)
                //{
                //    if (((Button)item).Text.Contains("번째"))
                //    {
                //        ((Button)item).Visible = false;
                //    }
                //}

                //as 활용 1
                if (item is Button)
                {
                    if ((item as Button).Text.Contains("번째"))
                    {
                        (item as Button).Visible = false;
                    }
                }

                //더 일반적인 as 활용(형변환시 변환 실패시 null을 return반환)
                var button = item as Button;
                if (button != null && button.Text.Contains("번째"))
                {
                    button.Visible = false;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Button button_temp = new Button();
                button_temp.Location = new Point(13, 50 + (23 + 3) * i);
                button_temp.Text = $"{i + 1}번째 생성";
                button_temp.Width = 300;

                Random rand = new Random();
                //bool visible = rand.NextDouble() > 0.5 ? true : false;
                bool visible = rand.Next(0, 2) == 0 ? false : true;

                Thread.Sleep(10);

                button_temp.Visible = visible;
                Controls.Add(button_temp);
            }

        }
    }
}
