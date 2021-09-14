using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
    public partial class WindowForm3 : Form
    {
        List<string> text = new List<string>()
        {
            "abc",
            "efg",
            "경북산업직업전문",
            "학교",
            "울라울라"
        };

        public WindowForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = text[new Random().Next(text.Count)];
        }
    }
}
