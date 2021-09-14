using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class MainForm : Form
    {
        public static Member_Login login = new Member_Login();
        public bool islogon = false;
        public bool test = false;
        Sunny.UI.UITextBox[] txtList;
        const string searchHold = "검색어를 입력하세요.";
        public string[] tbArray;
        DataManager instances = new DataManager();

        public MainForm()
        {
            InitializeComponent();
            DataLoad();

            //ID, Password TextBox Placeholder 설정
            txtList = new Sunny.UI.UITextBox[] { txt_search };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_search) txt.Text = searchHold;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

       private void RemovePlaceholder(object sender, EventArgs e)
        {
            Sunny.UI.UITextBox txt = (Sunny.UI.UITextBox)sender;
            if (txt.Text == searchHold)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            Sunny.UI.UITextBox txt = (Sunny.UI.UITextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txt_search) txt.Text = searchHold;
            }
        }

        private void DataLoad()
        {

            try
            {

                DataManager.Load();
                DGV_Subject.DataSource = null;
                DGV_Subject.DataSource = DataManager.rank; 
                tb1.Text = DGV_Subject.Rows[0].Cells[1].FormattedValue.ToString();
                tb2.Text = DGV_Subject.Rows[1].Cells[1].FormattedValue.ToString();
                tb3.Text = DGV_Subject.Rows[2].Cells[1].FormattedValue.ToString();
                tb4.Text = DGV_Subject.Rows[3].Cells[1].FormattedValue.ToString();
                tb5.Text = DGV_Subject.Rows[4].Cells[1].FormattedValue.ToString();
                tb6.Text = DGV_Subject.Rows[5].Cells[1].FormattedValue.ToString();
                tb7.Text = DGV_Subject.Rows[6].Cells[1].FormattedValue.ToString();
                tb8.Text = DGV_Subject.Rows[7].Cells[1].FormattedValue.ToString();
                tb9.Text = DGV_Subject.Rows[8].Cells[1].FormattedValue.ToString();
                tb10.Text = DGV_Subject.Rows[9].Cells[1].FormattedValue.ToString();

                tbArray = new string[]
                {
                tb1.Text,
                tb2.Text,
                tb3.Text,
                tb4.Text,
                tb5.Text,
                tb6.Text,
                tb7.Text,
                tb8.Text,
                tb9.Text,
                tb10.Text
                };

                UIDataGridView[] udArray = new UIDataGridView[]
                {
                DGV_rank1,DGV_rank2, DGV_rank3,DGV_rank4,DGV_rank5,DGV_rank6,DGV_rank7,DGV_rank8,
                DGV_rank9, DGV_rank10
                };

                for (int i = 0; i < 10; i++)
                {
                    show_data(tbArray[i], udArray[i]);
                }
            }
            catch (Exception)
            {

                //throw;
            }


           
        }

        private void show_data(string text, UIDataGridView ud)
        {
            DBHelper.BookRank(text);
            ud.DataSource = DBHelper.ds;
            ud.DataMember = "book";
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DGV_Subject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //UIDataGridView[] udArray = new UIDataGridView[]
            //{
            //    DGV_rank1,DGV_rank2, DGV_rank3,DGV_rank4,DGV_rank5,DGV_rank6,DGV_rank7,DGV_rank8,
            //    DGV_rank9, DGV_rank10
            //};

            //for (int i = 0; i < 10; i++)
            //{
            //    show_data(udArray[i]);
            //}
            uiTabControl1.SelectedIndex = DGV_Subject.CurrentRow.Index;
            Console.WriteLine(((UIDataGridView)sender).ToString());
        }

        private void DGV_rank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string btitle = (sender as UIDataGridView).Rows[e.RowIndex].Cells[3].Value.ToString();
            BookInfoForm bifrm = new BookInfoForm(btitle);
            bifrm.Owner = this;
            bifrm.Show();
            //MessageBox.Show(btitle);
        }

        private void bt_chart_Click(object sender, EventArgs e)
        {
            new chartView().ShowDialog();
        }

        private void bt_signin_Click(object sender, EventArgs e)
        {
            if (this.islogon)
            {
                MessageBox.Show("이미 로그인 했습니다.");
                return;
            }

            login.ShowDialog();
            this.islogon = login.islogin;
            //new Member_Login(islogon).ShowDialog();            
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {
            if (this.islogon)
            {
                MessageBox.Show("이미 로그인 했습니다.");
                return;
            }
            new Join_Main().ShowDialog();
        }

        private void bt_mypage_Click(object sender, EventArgs e)
        {
            if(this.islogon)
                new Mypage(login.LoginID).ShowDialog();
            else
                MessageBox.Show("로그인 후 이용하여 주시길 바랍니다.");
        }

        private void bt_icon_signout_Click(object sender, EventArgs e)
        {
            this.islogon = false;
            MessageBox.Show("로그아웃 되었습니다.");
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            instances.Load(txt_search.Text);
            new BookSearcher(DataManager.searchbooks, login.LoginID).ShowDialog();
        }

        private void bt_recommend_Click(object sender, EventArgs e)
        {
            new LibraryRecommand().ShowDialog();

        }
    }
}
