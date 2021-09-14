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
    enum Game
    {
        Scissors, Rock, Paper
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            Game mychoice = Game.Scissors;
            Game Pc = (Game)new Random().Next(3);
            label_me.Text = "가위";

            if(Pc == Game.Paper)
            {
                label_you.Text = "보";
                label_answer.Text = "이김";
            }
            else if (Pc == Game.Rock)
            {
                label_you.Text = "바위";
                label_answer.Text = "짐";
            }
            else
            {
                label_you.Text = "가위";
                label_answer.Text = "비김";
            }

        }

        private void button_r_Click(object sender, EventArgs e)
        {
            Game mychoice = Game.Rock;
            Game Pc = (Game)new Random().Next(3);

            label_me.Text = mychoice.ToString();
            label_you.Text = Pc.ToString();

            if (Pc == Game.Paper)
            {
                label_answer.Text = "Lose";
            }
            else if (Pc == Game.Rock)
            {
                label_answer.Text = "Draw";
            }
            else
            {
                label_answer.Text = "Win";
            }

        }

        private void button_p_Click(object sender, EventArgs e)
        {
            Game mychoice = Game.Paper;
            Game Pc = (Game)new Random().Next(3);

            label_me.Text = mychoice.ToString();
            label_you.Text = Pc.ToString();

            if (Pc == Game.Paper)
            {
                label_answer.Text = "비김";
            }
            else if (Pc == Game.Rock)
            {
                label_answer.Text = "이김";
            }
            else
            {
                label_answer.Text = "짐";
            }

        }

        private void button_directory_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "텍스트 파일(*.txt)|*txt";
            dlg.ShowDialog();
            string result = string.Format("나: {0}\n컴퓨터 : {1}\n결과:{2}", label_me.Text, label_you.Text, label_answer.Text);
            File.WriteAllText(dlg.FileName, result);
            
        }
    }
}
