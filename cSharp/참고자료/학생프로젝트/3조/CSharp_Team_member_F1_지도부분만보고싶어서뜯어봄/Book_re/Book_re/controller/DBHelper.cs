using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        public static void ConnectDB()
        {//접속해주는 함수
            try
            {
                string connect = string.Format("Data Source={0};" +
                "Initial Catalog = {1};" +
                "Persist Security Info = True;"+
                "User ID=team;Password=1234",
                "192.168.0.84,1433", "Csharp_Team");
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("connect Fail");
            }
        }

        public static void SearchBname(string bname)
        {
            ConnectDB();
            string sqlcommand = "Select * from dbo.book where bname like '%'+@p+'%'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            MainForm form1 = new MainForm();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p", bname);
            cmd.CommandText = sqlcommand;
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);

            conn.Close();
        }


        
        public static void BookRnetCount(string bid)
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.book set count=count+1 where isbn=@p";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void RentBook(string pid, string bid, string bname)
        {
            ConnectDB();
            string sqlcommand = "Insert Into Csharp_Team.dbo.rentBook(pid, rentDate, returnDate, bid, bname) values (@p1, @p2, @p3, @p4, @p5)";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p3", DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@p4", bid);
            cmd.Parameters.AddWithValue("@p5", bname);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("대여가 완료되었습니다.");
        }

        public static void ReturnBook(string pid, string bid) //반납
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.rentBook set returnCheck = '1' where pid=@p1 and bid=@p2 and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExtendDate(string pid, string bid) //연장
        {
            try
            {
                ConnectDB();
                string sqlcommand = "update Csharp_Team.dbo.rentBook set exCheck = '1', returnDate=DATEADD(DAY,14,returnDate) where pid=@p1 and bid=@p2 and exCheck='0'";
                da = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", pid);
                cmd.Parameters.AddWithValue("@p2", bid);

                cmd.CommandText = sqlcommand;

                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                MessageBox.Show("연장 되었습니다.");
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("이미 연장된 책입니다.");
            }

        }

        public static bool CheckRent(string bid) //확인
        {
            ConnectDB();
            string sqlcommand = "select returnCheck from Csharp_Team.dbo.rentBook where bid=@p and returnCheck='0'";
            //반납안된책있는지 검색
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", bid);

            cmd.CommandText = sqlcommand;
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                string check = item["returnCheck"].ToString();//있다면 값을 넣는다
                Console.WriteLine(check);

                if (!string.IsNullOrEmpty(check)) // null = 반납안된 책이 있음
                {
                    return true;
                    
                }

            }
            return false;
            conn.Close();
            
        }

        public static void UpdateOverDue(string pid, int overdueDay)
        {
            ConnectDB();
            string sqlcommand = "update Csharp_Team.dbo.member set overdue=(DATEADD(DD,@p1,Getdate())) where id = @p2;";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p1", overdueDay);
            cmd.Parameters.AddWithValue("@p2", pid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static DateTime CheckOverdue(string pid, string bid)
        {
            string returnedDate;
            ConnectDB();
            string sqlcommand = "select returnDate from Csharp_Team.dbo.rentBook where pid=@p1 and bid=@p2 and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p1", pid);
            cmd.Parameters.AddWithValue("@p2", bid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            returnedDate = cmd.ExecuteScalar().ToString();
            DateTime returntime = DateTime.Parse(returnedDate);

            conn.Close();
            return returntime;
        }

        public static bool CheckOverdue(string pid)
        {
            ConnectDB();
            string sqlcommand = "select returnDate from Csharp_Team.dbo.rentBook where pid=@p1 and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p1", pid);

            cmd.CommandText = sqlcommand;
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                //반환 날짜가 이미 지났다면 -1이고, 이런 경우에 연체이다.

                string Now = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime returnDateTime = DateTime.Parse(item["returnDate"].ToString());
                string returnDate = returnDateTime.ToString("yyyy-MM-dd");

                if (DateTime.Compare(DateTime.Parse(returnDate), DateTime.Parse(Now)) == -1)
                    return true;

            }

            conn.Close();
            return false;
        }

        public static void ReadRentalList(string pid)
        {
            ConnectDB();
            string sqlcommand = "select * from Csharp_Team.dbo.rentBook where pid=@p and returnCheck='0'";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", pid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            da.Fill(ds);

            conn.Close();
        }

        public static DateTime OverdueMember(string pid)
        {
            ConnectDB();
            string overdueDate;
            string sqlcommand = "select overdue from Csharp_Team.dbo.member where id=@p";
            da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p", pid);

            cmd.CommandText = sqlcommand;

            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            ds = new DataSet();
            overdueDate = cmd.ExecuteScalar().ToString();
            DateTime returntime = DateTime.Parse(overdueDate);

            conn.Close();

            return returntime;
        }
        public static void Query_Select()
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct rank() over(order by sum(count) desc) as 순위, rtrim(category) as category from book group by category";

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감

                ds = new DataSet();
                da.Fill(ds, "book");//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void count(string query)
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감

                ds = new DataSet();
                da.Fill(ds);//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void BookRank(string category)
        {
            try
            {
                ConnectDB();//연결

                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = cmd.Parameters.AddWithValue("@category", category);
                cmd.Connection = conn;
                cmd.CommandText = "select rank() over(order by count desc) as bookrank," +
                    "controlNumber, rtrim(bname) as title, rtrim(author) as writer, publisher, pyear, rtrim(category) as category from book where category = @category";

                //DataAdapter와 DataSet으로 DB table 불러오기
                da = new SqlDataAdapter(cmd); //select 구문이 들어감
                
                ds = new DataSet();
                da.Fill(ds, "book");//SELECT * FROM TB_CUST의 결과가 da에 입력됨

                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "TB_CUST";
                conn.Close(); //연결 해제~중요함
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //----------------------member관련-----------------------------------------------------

        //member관련
        public static void ConnectDB_member()
        {//MSSQL 접속해주는 함수
            try
            {
                string connect = string.Format("Data Source={0};" +
                "Initial Catalog = {1};" +
                "Persist Security Info = True;" +
                "User ID=team;Password=1234",
                "192.168.0.84,1433", "Csharp_Team");
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void Query_Select_member(string id = "")
        {
            ConnectDB_member();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (id == "")
                cmd.CommandText = "SELECT * FROM member";
            else
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "SELECT * FROM member where id = @id";

            }
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();
        }

        public static void Query_Select_member_findid(string name, string email)
        {
            ConnectDB_member();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id FROM member where name = @name " +
                    "and email = @email";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();
        }

        public static void Query_Select_member_findpw(string id, string email)
        {
            ConnectDB_member();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM member where id = @id " +
                    "and email = @email";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@email", email);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();
        }
        public static void Query_Update_member_findpw(string pwd, string id, string email)
        {
            try
            {
                ConnectDB_member();

                string sqlcommand = "Update member set " +
                        "pwd=@p1 where id=@p2 and email = @p3";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", pwd);
                cmd.Parameters.AddWithValue("@p2", id);
                cmd.Parameters.AddWithValue("@p3", email);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                System.Windows.Forms.MessageBox.Show("입력정보를 확인하세요");
            }
        }

        public static void Query_Insert_member(string name, string gender,
                    string id, string pwd, string email, string phone)
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "Insert Into member(name, gender, id, pwd, email, phone)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@p2", gender);
                cmd.Parameters.AddWithValue("@p3", id);
                cmd.Parameters.AddWithValue("@p4", pwd);
                cmd.Parameters.AddWithValue("@p5", email);
                cmd.Parameters.AddWithValue("@p6", phone);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();//실행
                conn.Close();
            }
            catch (Exception ex1)
            {
                throw new Exception(ex1.Message);
            }
        }

        public static void Query_Update_member(
                    string id, string pwd, string email, string phone)
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "Update member set " +
                    "pwd=@p1, email=@p2, phone=@p3 where id=@p4";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", pwd);
                cmd.Parameters.AddWithValue("@p2", email);
                cmd.Parameters.AddWithValue("@p3", phone);
                cmd.Parameters.AddWithValue("@p4", id);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }

        public static void Query_Delete_member()
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "DELETE member";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }
        public static void Query_Delete_member(string id)
        {
            ConnectDB_member();
            try
            {
                string sqlcommand = "DELETE member where id=@p1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", id);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1);
            }
        }
        //----------------------지도 관련------------------------------------
        public static void All()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Location";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            da.Fill(ds, "Location");

            conn.Close();
        }


        public static void Read(string category)
        {
            Console.WriteLine(category);
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"select * from Location where category ='{category}'";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            da.Fill(ds, "Location");
            conn.Close();
        }


    }
}
