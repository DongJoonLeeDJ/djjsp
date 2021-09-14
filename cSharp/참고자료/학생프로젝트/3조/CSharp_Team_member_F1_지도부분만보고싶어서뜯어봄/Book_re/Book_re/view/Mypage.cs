using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Book_re
{
    public partial class Mypage : Form
    {

        const int NAME = 0;
        const int ID = 2;
        const int PASSWORD = 3;
        const int EMAIL = 4;
        const int PHONE = 5;
        member temp = new member();
        DataManager instances = new DataManager();
        string id;

        public Mypage(string Id)
        {
            InitializeComponent();

            label_pw_check.Text = "일치합니다.";

            DBHelper.Query_Select_member(Id);
            label_name.Text = DBHelper.ds.Tables[0].Rows[0][NAME].ToString();
            label_id.Text = DBHelper.ds.Tables[0].Rows[0][ID].ToString();
            id = DBHelper.ds.Tables[0].Rows[0][ID].ToString();

            txt_pwd.Text = DBHelper.ds.Tables[0].Rows[0][PASSWORD].ToString();
            txt_pwdck.Text = DBHelper.ds.Tables[0].Rows[0][PASSWORD].ToString();

            txt_email.Text = DBHelper.ds.Tables[0].Rows[0][EMAIL].ToString();
            txt_phone.Text = DBHelper.ds.Tables[0].Rows[0][PHONE].ToString();

            DataManager instances = new DataManager();
            instances.ViewMyList(id);
            // 오류 수정
            dataGridView1.DataSource = null;
            if (DataManager.rentalLists.Count > 0)
                dataGridView1.DataSource = DataManager.rentalLists;

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {
            if (txt_pwd.Text == txt_pwdck.Text)
            {
                label_pw_check.Text = "일치합니다.";
            }
            else
            {
                label_pw_check.Text = "일치하지 않습니다.";
            }
        }

        private void txt_pwdck_TextChanged(object sender, EventArgs e)
        {
            if (txt_pwd.Text == txt_pwdck.Text)
            {
                label_pw_check.Text = "일치합니다.";
            }
            else
            {
                label_pw_check.Text = "일치하지 않습니다.";
            }
        }

        private void bt_update_check_Click(object sender, EventArgs e)
        {
            int count=0;//메시지 박스 예외처리 위한 변수
            temp.Id = label_id.Text;
            temp.Pwd = txt_pwd.Text;
            temp.Email = txt_email.Text;
            temp.Phone = txt_phone.Text;
            if (temp.Pwd == "" || txt_pwdck.Text == ""
                || temp.Email == "" || temp.Phone == "")
            {
                MessageBox.Show("입력되지 않은 값이 있습니다");
                return;
            }            
            else if (temp.Pwd != txt_pwdck.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다");
                return;
            }
            else if (!isValidPassword(temp.Pwd))
            {
                MessageBox.Show("비밀번호는 영문, 숫자, 특수문자를 포함해야합니다.");
                return;
            }
            else if (temp.Pwd == DBHelper.ds.Tables[0].Rows[0][PASSWORD].ToString() &
                txt_pwdck.Text == DBHelper.ds.Tables[0].Rows[0][PASSWORD].ToString() &
                temp.Email == DBHelper.ds.Tables[0].Rows[0][EMAIL].ToString() &
                temp.Phone == DBHelper.ds.Tables[0].Rows[0][PHONE].ToString())
            {
                MessageBox.Show("변경된 값이 없습니다.");
                count=1;
            }
            DBHelper.Query_Update_member(label_id.Text,
                                         txt_pwd.Text,
                                         txt_email.Text,
                                         txt_phone.Text);
            if (count != 1) { 
            MessageBox.Show("수정이 완료되었습니다.");
            }
        }

        public static bool isValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 1-32자리
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~`!@#$%\^&*()-+=.]).{1,32}$");
            Match match = regex.Match(Text);
            return match.Success;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            lb_borrowDate.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            lb_returnDate.Text= dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void bt_borrow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            instances.Return(id,dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            instances.Extend(id, dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
        }
    }
}
