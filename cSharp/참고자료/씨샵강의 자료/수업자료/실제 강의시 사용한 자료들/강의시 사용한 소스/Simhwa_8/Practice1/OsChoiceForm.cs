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
    public partial class OsChoiceForm : Form
    {
        struct FormPosition
        {
            public int x;
            public int y;
            public FormStartPosition StartPosition;

            public FormPosition(int x, int y)
            {
                this.x = x;
                this.y = y;
                StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
        }

        public OsChoiceForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Os를 선택해주세요.";
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Windows를 선택하셨습니다.";
            WindowsForm winform = new WindowsForm();
            FormPosition pos;
            pos.x = 500;
            pos.y = 500;
            pos.StartPosition = FormStartPosition.Manual;
            winform.Location = new Point(pos.x, pos.y);
            winform.StartPosition = pos.StartPosition;
            winform.ShowDialog();
        }

        private void macToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "맥을 선택하셨습니다.";
            MacForm macForm = new MacForm();
            FormPosition pos;
            pos.x = 1000;
            pos.y = 100;
            pos.StartPosition = FormStartPosition.CenterParent;
            macForm.Location = new Point(pos.x, pos.y);
            macForm.StartPosition = pos.StartPosition;
            macForm.ShowDialog();//CenterParent는 ShowDialog를 써줘야 한다.
        }
    }
}
