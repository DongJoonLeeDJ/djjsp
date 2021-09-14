using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    enum JudgementResult
    {
        Win, Loose, Draw
    }
    public partial class Form1 : Form
    {
        private delegate JudgementResult JudgementProcess(Game me, Game pc); //반환형이 JudgementResult이면서 타입이 Game인 매개변수 2개인 메서드를 매개변수로 사용할 수 있게 한다.

        JudgementProcess test = (a, b) => { };

        public Form1()
        {
            InitializeComponent();
        }

        private void button_s_Click(object sender, EventArgs e)
        {

            Game mychoice = Game.Scissors;
            Game Pc = (Game)new Random().Next(3);
            
            ShowResult((m, p) => { return JudgementResult.Win; });

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
    }
}
