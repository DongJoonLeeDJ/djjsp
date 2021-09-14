using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap08
{
    public partial class Form1 : Form
    {
        //x, y 현재 위치
        //vx, vy : 방향
        //nx, ny = 다음 위치
        void NextPosition
            (int x, int y, int vx, int vy, 
            out int nx, out int ny)
        {
            nx = x + vx;
            ny = y = vy;
        }

        public Form1()
        {
            InitializeComponent();
            List<int> temp = new List<int>();

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            MessageBox.Show($"Before : x : {x}, y:{y}");
            NextPosition
            (x, y, vx, vy, out x, out y);
            MessageBox.Show($"After x : {x}, y:{y}");


        }
    }
}
