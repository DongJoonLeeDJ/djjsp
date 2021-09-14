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

namespace WindowsFormsApplicationStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //button_Test.Text = "프로그램 시작 후 변경됨";
            //button_Test.AutoSize = true;

            Random random = new Random();
            button_Test.Text = random.NextDouble().ToString();

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                Point Point = new Point();
                Point.X = 13;
                Point.Y = 100 + 13 + (23 + 3) * i;
                //button.Location = new Point(13, 13 + 23 + 3);
                button.Location = Point;
                button.Text = "코드상에서의 생성" + (i+1);
                button.AutoSize = true;
                Random rand = new Random();
                bool visible = rand.Next(2) == 0 ? false : true;
                Thread.Sleep(10);
                button.Visible = visible;
            }
        }
    }
}
