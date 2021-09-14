using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        Mysql mysql = new Mysql();
        int idcheck = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ImageButton_Login_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2ImageButton_SignUp_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button_SignUp_Click(object sender, EventArgs e)    //회원가입버튼
        {
            IDText.Text = "";
            NameText.Text = "";
            PWText.Text = "";
            PhoneText.Text = "";

            panel_SignUp.Visible = true;
        }

        private void guna2Button_Login_Click(object sender, EventArgs e)    //로그인버튼
        {
            if (guna2TextBox_ID.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                guna2TextBox_ID.Focus();
                return;
            }
            else if (guna2TextBox_PW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                guna2TextBox_PW.Focus();
                return;
            }
            else
            {
                string userid = mysql.selectID(guna2TextBox_ID.Text, guna2TextBox_PW.Text);
                string log = mysql.Logcheck(guna2TextBox_ID.Text);
                if (userid != "")
                {
                    mysql.LogSave(log, guna2TextBox_ID.Text);
                    Main main = new Main(userid, log);
                    main.Show();
                    this.Hide();

                    guna2TextBox_ID.Text = "";
                    guna2TextBox_PW.Text = "";
                }
                else if (userid == "")
                    return;
                
            }
        }

        private void guna2Button_OK_Click(object sender, EventArgs e)       //회원가입 완료버튼
        {
            try
            {
                if (idcheck == 0)
                {
                    MessageBox.Show("아이디를 확인해주세요");
                    return;
                }
                else if (IDText.Text == "")
                {
                    MessageBox.Show("아이디를 입력해주세요");
                    return;
                }
                else if (PWText.Text == "")
                {
                    MessageBox.Show("비밀번호를 입력해주세요");
                    return;
                }
                else if (NameText.Text == "")
                {
                    MessageBox.Show("이름을 입력해주세요");
                    return;
                }
                else if (PhoneText.Text == "")
                {
                    MessageBox.Show("전화번호를 입력해주세요");
                    return;
                }
                else
                {
                    mysql.Insert(IDText.Text, PWText.Text, NameText.Text, PhoneText.Text);
                    MessageBox.Show("회원가입완료");
                    panel_SignUp.Visible = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("회원정보를 확인해주세요");
            }

        }


        private void guna2Button_IDcheck_Click(object sender, EventArgs e)  //ID중복확인
        {
            int res = mysql.ID_Check(IDText.Text);
            if (res == 1)
                MessageBox.Show("이미 사용중인 아이디입니다.");
            else
            {
                MessageBox.Show("사용가능한 아이디입니다.");
                idcheck = 1;
            }
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {
            idcheck = 0;
        }

        private void guna2TextBox_PW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                guna2Button_Login_Click(sender, e);
            }
        }

        private void panel_Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Helper.ReleaseCapture();
                Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
            }
        }

        private void panel_SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Helper.ReleaseCapture();
                Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
            }
        }
    }
}
