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

namespace FileControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_fileWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText
                (textBox_directory.Text, 
                textBox_contents.Text);
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            //첫번째 스타일
            label_contents.Text = 
                File.ReadAllText(textBox_directory.Text);

            //두번째 스타일
            string readDirectory = 
                File.ReadAllText
                (textBox_directory.Text);
            label_contents.Text = readDirectory;

            //경로 관련 참고사항(코드에서 경로 받아올 때)
            //첫번째 스타일
            string directory1 = "‪C:\\c_work\\test.txt";
            //두번째 스타일
            string directory2 = @"‪C:\c_work\test.txt";



        }

        private void button_writeStream_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = 
                new StreamWriter(textBox_directory.Text))
            {
                writer.WriteLine("1번");
                writer.WriteLine("2번");
                for(int i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i}번~~~");
                }
            }
        }

        private void button_readStream_Click(object sender, EventArgs e)
        {
            label_readStream.Text = "";
            using (StreamReader reader = new StreamReader(textBox_directory.Text))
            {
                string line;
                while((line = reader.ReadLine()) != null )
                {
                    label_readStream.Text += line + Environment.NewLine;
                }
            }
        }
    }
}
