using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //LinkLabel linklabel_temp = new LinkLabel();
            LinkLabel linklabel_temp = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(200, 200)
            };


            LinkLabel linklabel_temp2 = new LinkLabel();
            //if(true)
            //{
                //Text = "글자",
                //Location = new Point(200, 200)
            //}



            linklabel_temp.Click += linklabel_temp_Click;

            Controls.Add(linklabel_temp);

        }

        private void linklabel_temp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi~~~~~");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://naver.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var item in Controls)
            {
                //if(item is CheckBox)
                //if(item.GetType() == CheckBox)
                if (item is CheckBox)
                {
                    CheckBox c = item as CheckBox;
                    //CheckBox c = (CheckBox)item;
                    if(c.Checked)
                    {
                        list.Add(c.Text);
                    }
                }
            }
            string temp = string.Join(",", list);
            //temp = "list[0],list[1]...,list[Count-1]";
            MessageBox.Show(temp);

            //MessageBox.Show(string.Join(",", list));
            //"list[0],list[1]...,list[Count-1]"
        }
    }
}
