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

        private void button_save_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textBox_directory_save.Text);
            if(!di.Exists)
            {
                di.Create();
            }
            
            //true를 입력하면 끝에 텍스트가 계속 추가가 됨
            using (StreamWriter writer = new StreamWriter(textBox_directory_save.Text 
                + "\\" +
                textBox_filename_save.Text/*, true*/))
            {
                writer.WriteLine(textBox_contents.Text);
            }

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            label_contents.Text = "";
            DirectoryInfo di = new DirectoryInfo(textBox_directory_load.Text);
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamReader reader = new StreamReader(textBox_directory_save.Text + "\\" + textBox_filename_save.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null) // 한 줄씩 읽는 코드
                {
                    label_contents.Text += line + Environment.NewLine;  //한 줄씩 읽고 label에 써준다.
                }
            }

        }
    }
}
