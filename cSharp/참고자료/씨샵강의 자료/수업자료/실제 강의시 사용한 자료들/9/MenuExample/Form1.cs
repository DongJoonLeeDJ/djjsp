using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("죄송합니다. 현재 준비중.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text 
                = DateTime.Now.ToString
                ("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }
    }
}
