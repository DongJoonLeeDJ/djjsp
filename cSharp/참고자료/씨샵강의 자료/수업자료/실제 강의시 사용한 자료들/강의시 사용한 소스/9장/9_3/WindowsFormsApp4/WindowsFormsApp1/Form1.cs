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
            label_readText.Text = "";
            using (StreamReader reader = new StreamReader(textBox_directory.Text))
            {
                string line;
                while((line = reader.ReadLine()) != null) // 한 줄씩 읽는 코드
                {
                    label_readText.Text += line + Environment.NewLine;  //한 줄씩 읽고 label에 써준다.
                }
            }
        }
    }
}
