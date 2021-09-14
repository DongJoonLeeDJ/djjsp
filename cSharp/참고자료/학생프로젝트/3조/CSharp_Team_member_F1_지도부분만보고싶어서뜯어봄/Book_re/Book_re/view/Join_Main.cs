using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class Join_Main : Form
    {
        member temp = new member();
        public Join_Main()
        {
            InitializeComponent();
            Rbt_M.Checked = true;

            label_pw_check.Text = "일치합니다.";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Join_Main"].Close();
        }

        private void Rbt_M_CheckedChanged(object sender, EventArgs e)
        {
            Rbt_M.Text = "남자";
            temp.Gender = Rbt_M.Text;
        }
        private void Rbt_F_CheckedChanged(object sender, EventArgs e)
        {
            Rbt_F.Text = "여자";
            temp.Gender = Rbt_F.Text;
        }

        private void txt_pwd_join_TextChanged(object sender, EventArgs e)
        {
            if (txt_pwd_join.Text == txt_pwdck_join.Text)
            {
                label_pw_check.Text = "일치합니다.";
            }
            else
            {
                label_pw_check.Text = "일치하지 않습니다.";
            }
        }

        private void txt_pwdck_join_TextChanged(object sender, EventArgs e)
        {
            if (txt_pwd_join.Text == txt_pwdck_join.Text)
            {
                label_pw_check.Text = "일치합니다.";
            }
            else
            {
                label_pw_check.Text = "일치하지 않습니다.";
            }
        }
        private void bt_submit_join_Click(object sender, EventArgs e)
        {
            try
            {
                temp.Name = txt_name_join.Text;
                temp.Id = txt_id_join.Text;
                temp.Pwd = txt_pwd_join.Text;
                temp.Email = txt_email_join.Text;
                temp.Phone = txt_phone_join.Text;
                if (temp.Name == "" || temp.Id == "" || temp.Pwd == "" || txt_pwdck_join.Text == ""
                    || temp.Email == "" || temp.Phone == "")
                {
                    MessageBox.Show("입력되지 않은 값이 있습니다");
                    return;
                }
                else if (txt_pwd_join.Text != txt_pwdck_join.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.");
                    return;
                }
                else if (!isValidPassword(txt_pwd_join.Text))
                {
                    MessageBox.Show("비밀번호는 영문, 숫자, 특수문자를 포함해야합니다.");
                    return;
                }
                DBHelper.Query_Insert_member(temp.Name, temp.Gender, temp.Id, temp.Pwd, temp.Email, temp.Phone);
                MessageBox.Show("회원가입이 완료되었습니다");
                Application.OpenForms["Join_Main"].Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("아이디가 중복됩니다");
            }
        }

        private void bt_join_login_Click(object sender, EventArgs e)
        {
            new Member_Login().ShowDialog();
        }
        public static bool isValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 1-32자리
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~`!@#$%\^&*()-+=.]).{1,32}$");
            Match match = regex.Match(Text);
            return match.Success;
        }

        private void bt_submit_join_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "누르면";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.bt_submit_join, "회원가입이 완료됩니다.");
        }
    }
}
