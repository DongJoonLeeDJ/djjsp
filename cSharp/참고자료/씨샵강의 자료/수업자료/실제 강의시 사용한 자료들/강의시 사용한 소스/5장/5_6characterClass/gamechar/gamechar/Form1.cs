using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamechar
{
    public partial class Form1 : Form
    {
        class Gamecharacter
        {
            public static int mCountOfMember = 0;
            public string mId;

            public Gamecharacter()
            {
                mCountOfMember++;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Gamecharacter mario = new Gamecharacter() { mId = "mario" };
            Gamecharacter luigi = new Gamecharacter() { mId = "luigi" };

            List<string> IdList = new List<String>();

            IdList.Add(mario.mId);
            IdList.Add(luigi.mId);


            int i = 1;
            foreach(var item in IdList)
            {
                Label label = new Label();
                label.Text = item;
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);
                i++;
            }

            MessageBox.Show($"게임 총 회원수는 {Gamecharacter.mCountOfMember}명 입니다.");
        }

    }
}
