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
            DirectoryInfo di = new DirectoryInfo(@"D:\test");
            if(!di.Exists)
            {
                di.Create();
            }

            using(StreamWriter writer = new StreamWriter(@"D:\test\test.txt", true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss") + "] button 선택");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\test");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter(@"D:\test\test.txt", true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss") + "] Label 선택~~~~~~~~");
            }
        }
    }
}
