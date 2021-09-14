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

namespace BookManager
{
    public partial class Form2 : Form
    {
        public SqlConnection conn = new SqlConnection();
        public DataTable dt;

        enum enumBook
        {
            Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt
        }
        public Form2()
        {
            InitializeComponent();
            Text = "도서 관리";

            //dataGridView_book.DataSource = DataManager.Books;
            selectQuery();
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

        private void selectQuery(string Isbn = "")
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (Isbn == "")
            {
                cmd.CommandText = "SELECT Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt FROM BookTable";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView_book.DataSource = ds;
                dataGridView_book.DataMember = "BookTable";

            }
            else
            {
                cmd.CommandText = "SELECT Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt  FROM BookTable Where Isbn = " + Isbn;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        private void insertQuery()
        {

            try
            {
                ConnectDB();
                string sqlcommand = "Insert Into BookTable (Isbn, Name, Publisher, Page, isBorrowed) values (@p1, @p2, @p3, @p4, 0)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@p1", textBox_isbn.Text);
                cmd.Parameters.AddWithValue("@p2", textBox_bookName.Text);
                cmd.Parameters.AddWithValue("@p3", textBox_publisher.Text);
                cmd.Parameters.AddWithValue("@p4", textBox_page.Text);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("이미 존재하는 도서입니다.");
                }
                else
                {
                    int.TryParse(textBox_page.Text, out int page);
                    if(page <= 0)
                    {
                        MessageBox.Show("Page 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    insertQuery();
                    selectQuery();
                }
            }
            catch(Exception exception)
            {

            }
        }

        private void updateQuery()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                //Isbn, Name, Publisher, Page,
                sqlcommand = "Update BookTable set Name = @p1, Publisher = @p2, Page = @p3 where Isbn = @p4";

                cmd.Parameters.AddWithValue("@p1", textBox_bookName.Text);
                cmd.Parameters.AddWithValue("@p2", textBox_publisher.Text);
                cmd.Parameters.AddWithValue("@p3", textBox_page.Text);
                cmd.Parameters.AddWithValue("@p4", textBox_isbn.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }
        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBox_page.Text, out int page);
                if (page <= 0)
                {
                    MessageBox.Show("Page 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                    return;
                }

                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
                else
                {
                    updateQuery();
                    selectQuery();
                }
            }
            catch(Exception ex)
            {
            }

        }

        private void deleteQuery()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                //Isbn, Name, Publisher, Page,
                sqlcommand = "Delete BookTable where Isbn = @p1";

                cmd.Parameters.AddWithValue("@p1", textBox_isbn.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
                else
                {
                    deleteQuery();
                    selectQuery();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다.");
            }
        }

        private void dataGridView_book_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var book = dataGridView_book.CurrentRow;
                textBox_isbn.Text = book.Cells[(int)enumBook.Isbn].Value.ToString();
                textBox_bookName.Text = book.Cells[(int)enumBook.Name].Value.ToString();
                textBox_publisher.Text = book.Cells[(int)enumBook.Publisher].Value.ToString();
                textBox_page.Text = book.Cells[(int)enumBook.Page].Value.ToString();
            }
            catch(Exception eee)
            {

            }

        }
    }
}
