using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            button_os1.Text = "윈도";
            button_os2.Text = "맥";
        }

        private void button_os1_Click(object sender, EventArgs e)
        {
            WelcomeMessage welcome = new WindowWelcomeMessage();
            welcome.ShowWelcomeMessage();
            Hide(); //Close를 하면 show한 것들도 닫힘
            Form_Window windowform = new Form_Window();
            windowform.FormClosed += Windowform_FormClosed;
            windowform.Show();
        }

        private void Windowform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button_os2_Click(object sender, EventArgs e)
        {
            WelcomeMessage welcome = new MacWelcomeMessage();
            welcome.ShowWelcomeMessage();
            Hide();
            Form_Mac macForm = new Form_Mac();
            macForm.FormClosed += MacForm_FormClosed;
            macForm.Show();
        }

        private void MacForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
