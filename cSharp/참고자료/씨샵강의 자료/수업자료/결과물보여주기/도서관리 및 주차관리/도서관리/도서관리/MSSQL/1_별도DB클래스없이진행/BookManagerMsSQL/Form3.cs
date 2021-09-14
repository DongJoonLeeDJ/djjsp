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
    public partial class Form3 : Form
    {
        public SqlConnection conn = new SqlConnection();
        public DataTable dt;
        enum enumUser
        {
            UserId, UserName
        }

        public Form3()
        {
            InitializeComponent();
            Text = "사용자관리";

            selectQuery();

            //=> 람다 
            button_Add.Click += (sender, e) =>
            {
                try
                {
                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("이미 등록된 사용자입니다.");
                    }
                    else
                    {
                        insertQuery();
                        selectQuery();
                    }
                }
                catch (Exception)
                {

                }
            };

            button_Modify.Click += (sender, e) =>
            {
                try
                {

                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("등록되지 않은 사용자입니다.");
                    }
                    else
                    {
                        //BookTable의 UserName도 UserTable 값에 맞추기
                        updateQuery_Book();

                        //설정한 이름으로 변경
                        updateQuery_User();

                        selectQuery();
                    }
                }
                catch (Exception exception)
                {

                }
            };

            button_Delete.Click += (sender, e) =>
            {
                try
                {
                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("등록되지 않은 사용자입니다.");
                    }
                    else
                    {
                        bool isRemove = true;
                        updateQuery_Book(isRemove);
                        deleteQuery();
                        selectQuery();
                    }
                }
                catch (Exception)
                {
                }
            };

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

        private void selectQuery(int id = 0)
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (id == 0)
            {
                cmd.CommandText = "SELECT * FROM UserTable";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView_Users.DataSource = ds;
                dataGridView_Users.DataMember = "UserTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM UserTable Where id = " + id;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "UserTable");

                dt = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        private void insertQuery()
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
                cmd.Parameters.AddWithValue("@p1", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@p2", textBox_Name.Text);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void updateQuery_Book(bool isRemove = false)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                //Isbn, Name, Publisher, Page,
                if(isRemove)
                {
                    //sql server management studio에서 userid와 id를 외래키로 지정하였고, 관계를 정하였음.
                    //따라서 만약 해당 사용자를 삭제하면 userid 부분은 null이 된다.
                    //나머지 부분들은 여기서 수동으로 변경해준다.
                    sqlcommand = "Update BookTable set UserName = null, isBorrowed = 0, BorrowedAt = null where UserId = @p1";
                    cmd.Parameters.AddWithValue("@p1", textBox_ID.Text);
                }
                else
                {
                    sqlcommand = "Update BookTable set UserName = @p1 where UserId = @p2";
                    cmd.Parameters.AddWithValue("@p1", textBox_Name.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox_ID.Text);
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

        private void updateQuery_User()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                //Isbn, Name, Publisher, Page,
                sqlcommand = "Update UserTable set Name = @p1 where Id = @p2";

                cmd.Parameters.AddWithValue("@p1", textBox_Name.Text);
                cmd.Parameters.AddWithValue("@p2", textBox_ID.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
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
                sqlcommand = "Delete UserTable where Id = @p1";

                cmd.Parameters.AddWithValue("@p1", textBox_ID.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }
        private void DataGridView_Users_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var user = dataGridView_Users.CurrentRow;
                textBox_ID.Text = user.Cells[(int)enumUser.UserId].Value.ToString();
                textBox_Name.Text = user.Cells[(int)enumUser.UserName].Value.ToString();
            }
            catch (Exception ee)
            {

            }
        }
    }
}
