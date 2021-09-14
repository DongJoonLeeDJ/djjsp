using Book_re.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class Member_Login : Form
    {

        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "아이디";
        const string PwPlaceholder = "비밀번호";
        public bool islogin;
        int count = 0;//예외처리를 위한 변수
        public Member_Login()
        {
            InitializeComponent();
            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txt_ID_login, txt_PW_login };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_ID_login) txt.Text = IdPlaceholder;
                else if (txt == txt_PW_login) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txt_PW_login) 
                    txt_PW_login.PasswordChar = '*';
            }
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txt_ID_login) txt.Text = IdPlaceholder;
                else if (txt == txt_PW_login) { txt.Text = PwPlaceholder; txt_PW_login.PasswordChar = default; }
            }
        }

        private void bt_join_login_Click(object sender, EventArgs e)
        {
            new Join_Main().ShowDialog();
        }

        private void bt_login_login_Click(object sender, EventArgs e)
        {
            loginexe(txt_ID_login.Text, txt_PW_login.Text);
        }

        public void loginexe(string login_id, string login_password)
        {            
            // 로그인 할 id 를 검색
            string sql = "SELECT * FROM member WHERE id=\'" + login_id + "\' ";
            DBHelper.ConnectDB_member();
            SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);
            SqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                // 검색된 아이디와 비밀번호가 일치한 경우 로그인된 것으로 봄
                if (login_id == (string)mdr["id"] && login_password == (string)mdr["pwd"])
                { //sql상에 컬럼이름 id, pwd
                    islogin = true;
                    MessageBox.Show("로그인 성공");
                    Application.OpenForms["Member_Login"].Close();
                }
            }
            mdr.Close();
            if (islogin)
            {
                this.LoginID = txt_ID_login.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                count = 1;
                MessageBox.Show("아이디/암호를 확인해 주세요.");
                if (count == 1)
                {
                    label_find.Text = "로그인 정보를 잊으셨나요...?";
                }
            }
            txt_ID_login.Text = null;
            txt_PW_login.Text = null;
        }
        public string LoginID
        {
            get;
            private set;
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Member_Login"].Close();
            this.islogin = false;
        }

        private void login_KeyUp_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginexe(txt_ID_login.Text, txt_PW_login.Text);
            }
        }

        private void label_find_Click(object sender, EventArgs e)
        {           
            new Find_IDPW().Show();
            Application.OpenForms["Member_Login"].Close();
        }
    }
}
