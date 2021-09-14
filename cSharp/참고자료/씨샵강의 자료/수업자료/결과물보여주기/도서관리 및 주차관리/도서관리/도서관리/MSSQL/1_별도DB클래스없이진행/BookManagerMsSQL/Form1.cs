using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection();
        public DataTable dt_book;
        public DataTable dt_user;

        enum enumBook
        {
            Isbn, BookName
        }

        enum enumUser
        {
            UserId, UserName
        }

        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";
            refreshStatus();
        }

        private void refreshStatus()
        {
            selectQuery_Book();
            selectQuery_User();
            //selectQuery();
            //dt_book.Rows[0]["isBorrowed"].ToString()
            //전체 도서 수
            label_allBookCount.Text = dt_book.Rows.Count.ToString();
            //사용자 수
            label_allUserCount.Text = dt_user.Rows.Count.ToString();

            int borrowCount = 0;

            //대출중인 도서의 수
            foreach (DataRow item in dt_book.Rows)
            {
                if (bool.Parse(item["isBorrowed"].ToString()))
                    borrowCount++;
            }
            label_allBorrowedBook.Text = borrowCount.ToString();

            //연체중인 도서의 수
            borrowCount = 0;
            foreach (DataRow item in dt_book.Rows)
            {
                if (bool.Parse(item["isBorrowed"].ToString()))
                {
                    DateTime oldDay = DateTime.Parse(item["BorrowedAt"].ToString());
                    TimeSpan timeDiff = DateTime.Today - oldDay;
                    int diffDays = timeDiff.Days;
                    if (diffDays > 7)
                    {
                        borrowCount++;
                    }
                }
            }
            label_allDelayedBook.Text = borrowCount.ToString();
        }
        private void selectQuery_Book(string Isbn = "")
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (Isbn == "")
            {
                cmd.CommandText = "SELECT * FROM BookTable";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView_BookManager.DataSource = ds;
                dataGridView_BookManager.DataMember = "BookTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM BookTable Where Isbn = '" + Isbn + "'";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        private void selectQuery_User(int Id = -1)
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (Id < 0)
            {
                cmd.CommandText = "SELECT * FROM UserTable";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView_UserManager.DataSource = ds;
                dataGridView_UserManager.DataMember = "UserTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM UserTable Where Id = " + Id;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        private void updateQuery(int userId = 0, bool doBorrow = false)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                if (doBorrow) //대출
                {
                    //User Id를 이용하여 User 값들을 가져온다. 그리드뷰값을 가져올 수도 있지만, 그 것보다는 DB에서 UserId를 이용하여 조회를 하는 것이 더 안전한 것 같다.
                    //ex) user쪽 gridview에서 userid가 2인 것을 선택해놓고, textbox에는 1을 입력하는 경우에는 textbox에 적힌 1의 user가 책을 빌렸다고 봐야하기 때문...
                    
                    //dt.Rows[0]["CarNumber"].ToString();
                    string userName = dt_user.Rows[0]["Name"].ToString();
                    sqlcommand = "Update BookTable set UserId = @p1, UserName = @p2, isBorrowed = 1, BorrowedAt = @p3 where Isbn = @p4";

                    cmd.Parameters.AddWithValue("@p1", userId);
                    cmd.Parameters.AddWithValue("@p2", userName);
                    cmd.Parameters.AddWithValue("@p3", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p4", textBox_isbn.Text);
                }
                else //반납
                {
                    sqlcommand = "Update BookTable set UserId = null, UserName = null, isBorrowed = 0, BorrowedAt = null where Isbn = @p1";
                    cmd.Parameters.AddWithValue("@p1", textBox_isbn.Text);
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }

        private void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                    "Initial Catalog = {1};" +
                    "Integrated Security = {2};" +
                    "Timeout = 3"
                    , "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        private void DataGridView_BookManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var book = dataGridView_BookManager.CurrentRow;
                textBox_isbn.Text = book.Cells[(int)enumBook.Isbn].Value.ToString();
                textBox_bookName.Text = book.Cells[(int)enumBook.BookName].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_UserManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var user = dataGridView_UserManager.CurrentRow;
                textBox_id.Text = user.Cells[(int)enumUser.UserId].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("사용자 Id를 입력해주세요.");
            }
            else
            {
                try
                {
                    int.TryParse(textBox_id.Text.Trim(), out int userid);
                    if (userid <= 0)
                    {
                        MessageBox.Show("유효한 사용자 Id를 입력해주세요. 0 이상의 숫자여야 합니다.");
                    }
                    //1. 해당 도서의 상태를 체크하기 위하여, 해당 도서를 조회함
                    selectQuery_Book(textBox_isbn.Text);

                    //2. isBorrowed 값을 이용하여 판별함
                    bool isBorrowed = bool.Parse(dt_book.Rows[0]["isBorrowed"].ToString());
                    if (isBorrowed)
                    {
                        //2-1. true이면 이미 대여중이라고 할 것
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        //대출할 책 이름 가져옴
                        string bookName = dt_book.Rows[0]["Name"].ToString();

                        // 대출자의 id를 이용하여 대출자의 이름을 가져옴
                        selectQuery_User(userid);
                        string userName = dt_user.Rows[0]["Name"].ToString();

                        bool doBorrow = true;
                        updateQuery(userid, doBorrow);

                        MessageBox.Show("\"" + bookName + "\"이/가\"" + userName + "\"님께 대여되었습니다.");

                        refreshStatus(); //대출 하고 나서 db table에 적혀 있는 값들을 다시 보여줌
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.(대여)");
                }
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else
            {
                try
                {
                    //1. 해당 도서의 상태를 체크하기 위하여, 해당 도서를 조회함
                    selectQuery_Book(textBox_isbn.Text);

                    //2. isBorrowed 값을 이용하여 판별함
                    bool isBorrowed = bool.Parse(dt_book.Rows[0]["isBorrowed"].ToString());

                    string bookName = dt_book.Rows[0]["Name"].ToString();
                    if (isBorrowed)
                    {
                        DateTime oldDay = DateTime.Parse(dt_book.Rows[0]["BorrowedAt"].ToString());
                        updateQuery();

                        TimeSpan timeDiff = DateTime.Today - oldDay;
                        int diffDays = timeDiff.Days;

                        if (diffDays > 7)
                        {
                            MessageBox.Show("\"" + bookName + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + bookName + "\"이/가 반납되었습니다.");
                        }
                        refreshStatus();
                    }
                    else
                    {
                        MessageBox.Show("대여상태가 아닙니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.(반납)");
                }

            }

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new Form2().ShowDialog();
                Form2 temp = new Form2();
                temp.ShowDialog();
                refreshStatus();
                //DataManager.Load();
                //dataGridView_BookManager.DataSource = null;
                //dataGridView_BookManager.DataSource = DataManager.Books;
            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Form3().ShowDialog();
                refreshStatus();
            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }

        }

    }
}
