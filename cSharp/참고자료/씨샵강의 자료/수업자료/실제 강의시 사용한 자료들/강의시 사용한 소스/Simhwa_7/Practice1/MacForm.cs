using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class MacForm : Form
    {
        List<long> Diablo2CdKeyList;
        Mac os;

        public MacForm()
        {
            InitializeComponent();

            Diablo2CdKeyList = new List<long>()
            {
                8901872945645556,
                1296628834221119,
                1276887979221234,
                9712576999128549
            }; //참고: https://leon2.tistory.com/entry/디아블로-시디키-입니다 [수달이의 게임로그]}

            os = new Mac(Diablo2CdKeyList[new Random().Next(Diablo2CdKeyList.Count)]);
            label_nowCdkey.Text = os.CdKey.ToString();

            Label title = new Label();
            title.Text = "cd키 리스트";
            title.Location = new Point(100, 70);
            Controls.Add(title);

            for (int i = 0; i < Diablo2CdKeyList.Count; i++)
            {
                Label label = new Label();
                label.Text = Diablo2CdKeyList[i].ToString();
                label.Location = new Point(100, 100+(35*i));
                Controls.Add(label);
            }
            os.mPrint();
        }

        private void button_changecdkey_Click(object sender, EventArgs e)
        {
            long.TryParse(label_nowCdkey.Text, out long nowCdKey);
            long.TryParse(textBox_cdkey.Text, out long newCdKey);
            if(newCdKey == nowCdKey)
            {
                MessageBox.Show("이미 해당 cd키를 사용하고 계십니다.");
            }
            else if(Diablo2CdKeyList.Contains(newCdKey))
            {
                MessageBox.Show($"cd키가 변경되었습니다. 기존 cd키 : {nowCdKey}, 변경된 cd키 : {newCdKey}");
                os.CdKey = newCdKey;
                label_nowCdkey.Text = os.CdKey.ToString();
            }
            else
            {
                MessageBox.Show("너 고소!", "경고!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
