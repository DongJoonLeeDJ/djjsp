using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class Mysql
    {

        public static MySqlConnection MyConn = new MySqlConnection();
        public static MySqlDataAdapter da;
        public static DataSet ds;

        public static void ConnectDB()
        {
            try
            {
                string pwd = "12345678";
                string dbName = "MEMBER";
                string strConn = "Server = 192.168.0.88;" +
                    "Database = " + dbName + ";" +
                    "Uid = mapmember;" +
                    "Pwd=" + pwd + ";" +
                    "Charset=utf8";
                MyConn = new MySqlConnection(strConn);
                MyConn.Open();
            }
            catch (Exception)
            {

            }
        }

        public string Logcheck(string id) //최근 로그인기록을 가져오는 구문
        {
            string Log = "";
            ConnectDB();
            string sql = $"select Log from log where id='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, MyConn);
            object scalarValue = cmd.ExecuteScalar();
            if (scalarValue == null)
                scalarValue = "";
            Log = (scalarValue.ToString());
            MyConn.Close();
            return Log;
        }
        public void LogSave(string Log, string id) //로그인기록을 저장하는 구문
        {
            ConnectDB();
            MySqlCommand cmd;
            string sql="";
            if (Log != "")
            {
                sql = $"update log set Log = now() where id = '{id}'";
                cmd = new MySqlCommand(sql, MyConn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                sql = $"insert into log(id) values('{id}')";
                cmd = new MySqlCommand(sql, MyConn);
                cmd.ExecuteNonQuery();
            }
            MyConn.Close();
        }

        public void Insert(string id, string pw, string name , string phone)
        {
            ConnectDB();
            string sqlCommand = $"insert into member values('{id}','{pw}','{name}','{phone}')";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, MyConn);
            cmd.ExecuteNonQuery();
            MyConn.Close();
        }

        public int ID_Check(string id)
        {
            int res = 0 ;
            ConnectDB();
            string sql = $"select count(*) from member where id='{id}'";
            MySqlCommand cmd = new MySqlCommand(sql, MyConn);
            object scalarValue = cmd.ExecuteScalar();
            res = int.Parse(scalarValue.ToString());
            MyConn.Close();
            return res;

        }

        public string selectID(string id, string pw)
        {
            string userid = "";
            try
            {
                ConnectDB();
                string sql = $"select id from member where id='{id}' and pw ='{pw}'";
                MySqlCommand cmd = new MySqlCommand(sql, MyConn);
                object scalarValue = cmd.ExecuteScalar();
                if (scalarValue == null)
                {
                    MessageBox.Show("회원정보가 일치하지 않습니다.");
                    return "";
                }
                userid = (scalarValue.ToString());
                MyConn.Close();
                return userid;
            }
            catch (Exception)
            {
                return userid;
            }
            
        }
    }
}
