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

            label_abs.Text = Math.Abs(-90).ToString();
            label_ceiling.Text = Math.Ceiling(50.123).ToString();
            label_floor.Text = Math.Floor(50.123).ToString();
            label_max.Text = Math.Max(50, 52).ToString();
            label_min.Text = Math.Min(50, 52).ToString();
            label_round.Text = Math.Round(50.523).ToString();
        }
    }
}
