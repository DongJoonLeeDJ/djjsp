using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re.UI
{
    public partial class Find_IDPW : Form
    {
        public bool test = false;
        TextBox[] txtList;
        const string namePlaceholder = "이름";
        const string emailPlaceholder = "이메일";
        public Find_IDPW()
        {
            InitializeComponent();
            label_output.Text = "";
            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txt_name_FIND, txt_email_FIND };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_name_FIND) txt.Text = namePlaceholder;
                else if (txt == txt_email_FIND) txt.Text = emailPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == namePlaceholder | txt.Text == emailPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
            }
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txt_name_FIND) txt.Text = namePlaceholder;
                else if (txt == txt_email_FIND)
                { 
                    txt.Text = emailPlaceholder; 
                }
            }
        }

        private void findid(string name, string email)
        {
            try
            {

                label_output.Text = "당신의 id는 ";
                DBHelper.Query_Select_member_findid(name, email);
                label_output.Text += DBHelper.ds.Tables[0].Rows[0][0];
                label_output.Text += " 입니다.";
            }
            catch (Exception ex)
            {
                label_output.Text = "존재하지 않는 사용자입니다.";
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void changePw(string pw, string id, string email)
        {
            DBHelper.Query_Update_member_findpw(pw, id, email);
            MessageBox.Show("비밀번호가 변경되었습니다.");
            //Application.OpenForms["Find_IDPW"].Close();           
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            findid(txt_name_FIND.Text, txt_email_FIND.Text);
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Find_IDPW"].Close();
        }

        private void label_findpw_Click(object sender, EventArgs e)
        {//비밀번호재설정1
            panel_idck.Visible = true;
        }               
        private void bt_pwreset1_Click_1(object sender, EventArgs e)
        {//비밀번호재설정2
            DBHelper.Query_Select_member_findpw(txt_id.Text, txt_email.Text);
            int count = DBHelper.ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("존재하지 않는 ID 혹은 email입니다.");
                return;
            }
            else
            {
                panel_idck.Hide();
                panel_pw_reset.Visible = true;
            }


        }
        private void bt_pwinput_Click(object sender, EventArgs e)
        {//비밀번호재설정3
            if(txt_password.Text != txt_passwordck.Text)
            {
                MessageBox.Show("비밀번호가 다릅니다.");
            }
            else
            {
                changePw(txt_password.Text, txt_id.Text, txt_email.Text);

            }

        }
        
        private void label_findid_Click(object sender, EventArgs e)
        {
            panel_idck.Visible = false;
            panel_pw_reset.Visible = false;
        }

        private void label_calllogin_Click(object sender, EventArgs e)
        {
            new Member_Login().Show();
        }

       
    }
}
