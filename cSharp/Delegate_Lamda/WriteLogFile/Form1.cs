using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteLogFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void displayLog(string m)
        {
            string msg = DateTime.Now.ToString("[yyyy/MM/dd hh:mm:ss.fff]") + m;
            //listBox1.Items.Add(m);        //가장 최근에 추가한 게 가장 아래로 감
            listBox1.Items.Insert(0, msg);    //가장 최근에 추가한 게 가장 위로 감
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            displayLog(textBox1.Text);
            WriteLog.writeFileLog(textBox1.Text);
        }
    }
}
