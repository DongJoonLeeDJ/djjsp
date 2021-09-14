using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Common
{
    //이승직
    class MySQL_Helper
    {
        public static MySqlConnection Myconn = new MySqlConnection();
        public static MySqlDataAdapter da;
        public static DataSet ds;

        public static void ConnectDB()
        {
            try
            {
                string pwd = "1234";
                string strConn = "Server=192.168.0.104; Port:3306; Database=ATM;Uid=root;Pwd=" + pwd + ";Charset=utf8";
                Myconn = new MySqlConnection(strConn);
                Myconn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Query_Select()
        {
            try
            {
                ConnectDB();

                string sql = "SELECT * FROM account";
                da = new MySqlDataAdapter();
                MySqlCommand cmd = Myconn.CreateCommand();
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "account");

                Myconn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
