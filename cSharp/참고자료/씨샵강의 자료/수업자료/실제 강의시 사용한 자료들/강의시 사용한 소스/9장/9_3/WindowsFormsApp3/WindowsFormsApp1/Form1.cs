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

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(textBox_directory.Text))
            {
                writer.WriteLine("c# 과목");
                writer.WriteLine("정말 매");
                writer.WriteLine("우 재미있습니다.");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine($"프로그래밍이 재미있습니다. - {i + 1}");
                }
            }

            label_readText.Text = File.ReadAllText(textBox_directory.Text);
        }
    }
}
