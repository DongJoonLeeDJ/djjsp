using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_classfile_separate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GameCharacterClass mario = new GameCharacterClass() { mId = "mario" };
            GameCharacterClass luigi = new GameCharacterClass() { mId = "luigi" };
            GameCharacterClass yosi = new GameCharacterClass() { mId = "yosi" };

            List<string> IdList = new List<String>();

            IdList.Add(mario.mId);
            IdList.Add(luigi.mId);
            IdList.Add(yosi.mId);


            int i = 1;
            foreach (var item in IdList)
            {
                Label label = new Label();
                label.Text = item;
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);
                i++;
            }

            MessageBox.Show($"게임 총 회원수는 {GameCharacterClass.mCountOfMember}명 입니다.");
        }
    }
}

3



