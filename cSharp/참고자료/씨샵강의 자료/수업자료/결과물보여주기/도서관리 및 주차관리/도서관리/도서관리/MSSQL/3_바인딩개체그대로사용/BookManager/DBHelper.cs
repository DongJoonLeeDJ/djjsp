using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static DataSet ds;
        public static DataTable dt_book;
        public static DataTable dt_user;

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                    "Initial Catalog = {1};" +
                    "Integrated Security = {2};" +
                    "Timeout = 3"
                    , "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery_Book(string Isbn = "")
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
                ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView_BookManager.DataSource = ds;
                //dataGridView_BookManager.DataMember = "BookTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM BookTable Where Isbn = " + Isbn;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "BookTable");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        public static void selectQuery_User(int Id = -1)
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
                ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView_UserManager.DataSource = ds;
                //dataGridView_UserManager.DataMember = "UserTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM UserTable Where Id = " + Id;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        //public static void updateQuery(string isbn, int userId = 0, bool doBorrow = false)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        if (doBorrow) //대출
        //        {
        //            //User Id를 이용하여 User 값들을 가져온다. 그리드뷰값을 가져올 수도 있지만, 그 것보다는 DB에서 UserId를 이용하여 조회를 하는 것이 더 안전한 것 같다.
        //            //ex) user쪽 gridview에서 userid가 2인 것을 선택해놓고, textbox에는 1을 입력하는 경우에는 textbox에 적힌 1의 user가 책을 빌렸다고 봐야하기 때문...

        //            //dt.Rows[0]["CarNumber"].ToString();
        //            string userName = dt_user.Rows[0]["Name"].ToString();
        //            sqlcommand = "Update BookTable set UserId = @p1, UserName = @p2, isBorrowed = 1, BorrowedAt = @p3 where Isbn = @p4";

        //            cmd.Parameters.AddWithValue("@p1", userId);
        //            cmd.Parameters.AddWithValue("@p2", userName);
        //            cmd.Parameters.AddWithValue("@p3", DateTime.Now.ToString("yyyy-MM-dd"));
        //            cmd.Parameters.AddWithValue("@p4", isbn);
        //        }
        //        else //반납
        //        {
        //            sqlcommand = "Update BookTable set UserId = null, UserName = null, isBorrowed = 0, BorrowedAt = null where Isbn = @p1";
        //            cmd.Parameters.AddWithValue("@p1", isbn);
        //        }
        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {

        //    }

        //}

        //public static void selectQuery_BookForm(string Isbn = "")
        //{
        //    ConnectDB();

        //    //SQL 명령어 선언
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    if (Isbn == "")
        //    {
        //        cmd.CommandText = "SELECT Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt FROM BookTable";

        //        //DataAdapter와 DataSet으로 DB table 불러오기
        //        //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
        //        SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
        //        ds = new DataSet();
        //        da.Fill(ds, "BookTable");

        //        dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
        //        //dataGridView에 DB에서 가져온 데이터 입력하기
        //        //dataGridView_book.DataSource = ds;
        //        //dataGridView_book.DataMember = "BookTable";

        //    }
        //    else
        //    {
        //        cmd.CommandText = "SELECT Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt  FROM BookTable Where Isbn = " + Isbn;

        //        //DataAdapter와 DataSet으로 DB table 불러오기
        //        //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
        //        SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
        //        ds = new DataSet();
        //        da.Fill(ds, "BookTable");

        //        dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
        //    }

        //    conn.Close(); //연결 해제
        //}

        //public static void insertQuery_BookForm(string isbn, string bookName, string publisher, string page)
        //{

        //    try
        //    {
        //        ConnectDB();
        //        string sqlcommand = "Insert Into BookTable (Isbn, Name, Publisher, Page, isBorrowed) values (@p1, @p2, @p3, @p4, 0)";
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;
        //        //Column 명은 별도의 파라메터 형태로 선언함
        //        //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
        //        cmd.Parameters.AddWithValue("@p1", isbn);
        //        cmd.Parameters.AddWithValue("@p2", bookName);
        //        cmd.Parameters.AddWithValue("@p3", publisher);
        //        cmd.Parameters.AddWithValue("@p4", page);
        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}

        //public static void updateQuery_BookForm(string bookName, string publisher, string page, string isbn)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        //Isbn, Name, Publisher, Page,
        //        sqlcommand = "Update BookTable set Name = @p1, Publisher = @p2, Page = @p3 where Isbn = @p4";

        //        cmd.Parameters.AddWithValue("@p1", bookName);
        //        cmd.Parameters.AddWithValue("@p2", publisher);
        //        cmd.Parameters.AddWithValue("@p3", page);
        //        cmd.Parameters.AddWithValue("@p4", isbn);

        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {
        //    }

        //}

        //public static void deleteQuery_BookForm(string isbn)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        //Isbn, Name, Publisher, Page,
        //        sqlcommand = "Delete BookTable where Isbn = @p1";

        //        cmd.Parameters.AddWithValue("@p1", isbn);

        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {
        //    }

        //}
        //public static void updateQuery_Book_UserForm(string id, string name, bool isRemove = false)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        //Isbn, Name, Publisher, Page,
        //        if (isRemove)
        //        {
        //            //sql server management studio에서 userid와 id를 외래키로 지정하였고, 관계를 정하였음.
        //            //따라서 만약 해당 사용자를 삭제하면 userid 부분은 null이 된다.
        //            //나머지 부분들은 여기서 수동으로 변경해준다.
        //            sqlcommand = "Update BookTable set UserName = null, isBorrowed = 0, BorrowedAt = null where UserId = @p1";
        //            cmd.Parameters.AddWithValue("@p1", id);
        //        }
        //        else
        //        {
        //            sqlcommand = "Update BookTable set UserName = @p1 where UserId = @p2";
        //            cmd.Parameters.AddWithValue("@p1", name);
        //            cmd.Parameters.AddWithValue("@p2", id);
        //        }


        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {
        //    }
        //}

        //public static void updateQuery_User_UserForm(string name, string id)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        //Isbn, Name, Publisher, Page,
        //        sqlcommand = "Update UserTable set Name = @p1 where Id = @p2";

        //        cmd.Parameters.AddWithValue("@p1", name);
        //        cmd.Parameters.AddWithValue("@p2", id);

        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {
        //    }
        //}

        //public static void deleteQuery_UserForm(string id)
        //{
        //    try
        //    {
        //        ConnectDB();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;

        //        string sqlcommand;
        //        //Isbn, Name, Publisher, Page,
        //        sqlcommand = "Delete UserTable where Id = @p1";

        //        cmd.Parameters.AddWithValue("@p1", id);

        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception eee)
        //    {
        //    }

        //}

        //public static void insertQuery_User_UserForm(string id, string name)
        //{

        //    try
        //    {
        //        ConnectDB();
        //        string sqlcommand = "Insert Into UserTable (Id, Name) values (@p1, @p2)";
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.Text;
        //        //Column 명은 별도의 파라메터 형태로 선언함
        //        //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
        //        cmd.Parameters.AddWithValue("@p1", id);
        //        cmd.Parameters.AddWithValue("@p2", name);
        //        cmd.CommandText = sqlcommand;
        //        cmd.ExecuteNonQuery(); //쿼리 실행
        //        conn.Close();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}
        
        public static void allInsertIntoBookTable(string Isbn, string Name, string Publisher, int Page, int? UserId, string UserName, bool isBorrowed, DateTime BorrowedAt)
        {
            try
            {
                ConnectDB();
                string sqlcommand;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                if(UserId != null && UserId > 0 && BorrowedAt != DateTime.MinValue) //대여중
                {
                    sqlcommand = "Insert Into BookTable (Isbn, Name, Publisher, Page, UserId, UserName, isBorrowed, BorrowedAt) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                    cmd.Parameters.AddWithValue("@p1", Isbn);
                    cmd.Parameters.AddWithValue("@p2", Name);
                    cmd.Parameters.AddWithValue("@p3", Publisher);
                    cmd.Parameters.AddWithValue("@p4", Page);
                    cmd.Parameters.AddWithValue("@p5", UserId);
                    cmd.Parameters.AddWithValue("@p6", UserName);
                    cmd.Parameters.AddWithValue("@p7", isBorrowed);
                    cmd.Parameters.AddWithValue("@p8", BorrowedAt.ToString("yyyy-MM-dd"));
                }
                else //대여중이지 않은 상태(userid, username, borrowedat 값이 모두 null임)
                {
                    sqlcommand = "Insert Into BookTable (Isbn, Name, Publisher, Page, isBorrowed) values (@p1, @p2, @p3, @p4, @p5)";
                    cmd.Parameters.AddWithValue("@p1", Isbn);
                    cmd.Parameters.AddWithValue("@p2", Name);
                    cmd.Parameters.AddWithValue("@p3", Publisher);
                    cmd.Parameters.AddWithValue("@p4", Page);
                    cmd.Parameters.AddWithValue("@p5", isBorrowed);

                }

                //string sqlcommand = "Insert Into BookTable (Isbn, Name, Publisher, Page, UserId, UserName, isBorrowed, BorrowedAt) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                //SqlCommand cmd = new SqlCommand();

                //cmd.Connection = conn;
                //cmd.CommandType = CommandType.Text;
                ////Column 명은 별도의 파라메터 형태로 선언함
                ////SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                //cmd.Parameters.AddWithValue("@p1", Isbn);
                //cmd.Parameters.AddWithValue("@p2", Name);
                //cmd.Parameters.AddWithValue("@p3", Publisher);
                //cmd.Parameters.AddWithValue("@p4", Page);
                //if(UserId == 0)
                //{
                //    cmd.Parameters.AddWithValue("@p5", "''");
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@p5", UserId);
                //}                
                //cmd.Parameters.AddWithValue("@p6", UserName);
                //cmd.Parameters.AddWithValue("@p7", isBorrowed);
                //if(BorrowedAt == DateTime.MinValue)
                //{
                //    cmd.Parameters.AddWithValue("@p8", "''");
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@p8", BorrowedAt.ToString("yyyy-MM-dd"));
                //}
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
            }
        }

        public static void allInsertIntoUserTable(int Id, string Name)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "Insert Into UserTable (Id, Name) values (@p1, @p2)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@p1", Id);
                cmd.Parameters.AddWithValue("@p2", Name);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
            }
        }
        
        public static void allDeleteTable(string tableName)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand;
                sqlcommand = $"Delete {tableName}";
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
            }
        }
    }
}
