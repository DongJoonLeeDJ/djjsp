using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {            
            //참고
            string directory1 = "c:\\test\\test1.txt";
            string directory2 = @"c:\test\test2.txt";//가독성 향상
            
            File.WriteAllText(textBox_directory.Text, textBox_contents.Text);
            File.WriteAllText(directory1, textBox_contents.Text);
            File.WriteAllText(directory2, textBox_contents.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_readText.Text = File.ReadAllText(textBox_directory.Text);
        }
    }
}
