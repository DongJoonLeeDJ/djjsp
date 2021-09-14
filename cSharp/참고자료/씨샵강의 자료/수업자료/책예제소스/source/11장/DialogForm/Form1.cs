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

namespace DialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|csfile(*.cs)|*.cs";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "텍스트 파일 (*.txt)|*.txt|ssfile(*.ss)|*.ss";
            dialog.Title = "-_-a";
            ColorDialog vlog = new ColorDialog();
            vlog.ShowDialog();
            dialog.ShowDialog();
            File.WriteAllText(dialog.FileName, textBox1.Text);
        }
    }
}
