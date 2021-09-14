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

namespace CarManager_Modified
{
    public partial class Form1 : Form
    {

        public static SqlConnection conn = new SqlConnection();
        public static DataTable dt;

        enum CarEnum
        {
            ParkingSpot, CarNumber, DriverName, PhoneNumber
        }
        public Form1()
        {
            InitializeComponent();
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

        //selectQuery() => parkingSpot = -1
        //selectQuery(int값) => parkingSport = int값
        private void selectQuery(int parkingSpot = -1)
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (parkingSpot < 0)
            {
                cmd.CommandText = "SELECT * FROM CarManager";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "CarManager");

                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView_parkingManager.DataSource = ds;
                dataGridView_parkingManager.DataMember = "CarManager";
                conn.Close(); //연결 해제
            }
            else
            {
                cmd.CommandText = "SELECT * FROM CarManager Where ParkingSpot = " + parkingSpot;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "CarManager");

                dt = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.

                conn.Close(); //연결 해제

            }
        }

        private void insertQuery(int parkingSpot)
        {

            try
            {
                ConnectDB();
                string sqlcommand = "Insert Into CarManager (ParkingSpot) values (@parameter1)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@parameter1", parkingSpot);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void updateQuery(bool isRemove = false) //출차인 경우에는 true 값을 넣어줌
        {
            try
            {

                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                if (isRemove)
                {
                    sqlcommand = "Update CarManager set CarNumber = '', DriverName = '', PhoneNumber = '', ParkingTime = null where ParkingSpot = @p1";

                    cmd.Parameters.AddWithValue("@p1", textBox_parkingSpot.Text);
                }
                else
                {

                    sqlcommand = "Update CarManager set CarNumber = @p1, DriverName = @p2, PhoneNumber = @p3, ParkingTime = @p4 where ParkingSpot = @p5";

                    cmd.Parameters.AddWithValue("@p1", textBox_carNumber.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox_driverName.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox_phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", textBox_parkingSpot.Text); //제대로 된 숫자 입력하지 않으면 이 부분까지 코드가 실행되지도 못 하도록 짜여있음
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

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
            //공간번호 입력 필수
            if (textBox_parkingSpot.Text.Trim() == "")
            {
                MessageBox.Show("주차공간을 입력해주세요.");
            }
            //차량번호 입력 필수
            else if (textBox_carNumber.Text.Trim() == "")
            {
                MessageBox.Show("차량 번호를 입력해주세요.");
            }
            else
            {
                try
                {
                    //주차 공간조회처럼 KeyPress 부분을 수정하면 숫자만 입력받게 할 수 있음.
                    int.TryParse(textBox_parkingSpot.Text, out int parkingSpot);
                    if (parkingSpot <= 0)
                    {
                        MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다!!!");
                        return;
                    }
                    selectQuery(parkingSpot);

                    if (dt.Rows.Count < 1) //해당 주차 공간이 없는 경우
                    {
                        MessageBox.Show("해당 주차 공간은 존재하지 않습니다.");
                        return;
                    }
                    else
                    {
                        string ParkedCar = dt.Rows[0]["CarNumber"].ToString();
                        if (ParkedCar != "")
                        {
                            MessageBox.Show("해당 공간에는 이미 차가 존재합니다!!!");
                            return;
                        }

                        updateQuery();
                        string contents = $"주차공간 {parkingSpot}에 {textBox_carNumber.Text}을/를 주차하였습니다.";
                        WriteLog(contents);
                        selectQuery();

                    }

                }
                catch (Exception)
                {
                    //아예 없는 주차공간일 경우
                    string contents = $"주차할 수 없습니다. 주차공간 {textBox_parkingSpot.Text} 은(는) 존재하지 않습니다.";
                    MessageBox.Show(contents);
                }
            }
        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {
            //공간번호 입력 필수
            if (textBox_parkingSpot.Text.Trim() == "")
            {
                MessageBox.Show("주차공간을 입력해주세요.");
            }
            else
            {
                try
                {
                    //주차 공간조회처럼 KeyPress 부분을 수정하면 숫자만 입력받게 할 수 있음.
                    int.TryParse(textBox_parkingSpot.Text, out int parkingSpot);
                    if (parkingSpot <= 0)
                    {
                        MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다!!!");
                        return;
                    }
                    selectQuery(parkingSpot);

                    if (dt.Rows.Count < 1) //해당 주차 공간이 없는 경우
                    {
                        MessageBox.Show("해당 주차 공간은 존재하지 않습니다.");
                        return;
                    }
                    else
                    {
                        string ParkedCar = dt.Rows[0]["CarNumber"].ToString();
                        if (ParkedCar == "")
                        {
                            MessageBox.Show("해당 공간에는 이미 차가 없습니다!!!");
                            return;
                        }
                        bool isRemove = true;
                        updateQuery(isRemove);
                        string contents = $"주차공간 {parkingSpot}에 {ParkedCar}을/를 출차하였습니다.";
                        WriteLog(contents);
                        selectQuery();

                    }

                }
                catch (Exception)
                {
                    //아예 없는 주차공간일 경우
                    string contents = $"주차할 수 없습니다. 주차공간 {textBox_parkingSpot.Text} 은(는) 존재하지 않습니다.";
                    MessageBox.Show(contents);
                }
            }
        }

        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBox_parkingSpot_lookUp.Text, out int parkingSpot);
                if (parkingSpot <= 0) //KeyPress 부분에 필터를 걸어서 숫자 이외의 값은 안 들어온다.
                {
                    MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다!!!");
                    return;
                }

                //입력한 주차공간번호 조회
                selectQuery(parkingSpot);

                //어차피 주차공간은 pk이므로 Row의 길이는 0아니면 1이다.
                if (dt.Rows.Count < 1) //해당 주차 공간이 없는 경우
                {
                    MessageBox.Show("해당 주차 공간은 존재하지 않습니다.");
                    return;
                }
                else
                {
                    string ParkedCar = dt.Rows[0]["CarNumber"].ToString();
                    if (ParkedCar != "")
                    {
                        string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.";
                        WriteLog(contents);
                    }
                    else
                    {
                        string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차된 차가 없습니다.";
                        WriteLog(contents);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("주차공간번호가 유효하지 않습니다.");
            }

        }

        private void timer_DisplayNowtime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Now.Text = "현재 시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void dataGridView_parkingManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var car = dataGridView_parkingManager.CurrentRow;

                //현재 선택한 부분의 값을 textbox에 나타냄
                textBox_parkingSpot.Text = dataGridView_parkingManager.CurrentRow.Cells[(int)CarEnum.ParkingSpot].Value.ToString();
                textBox_carNumber.Text = dataGridView_parkingManager.CurrentRow.Cells[(int)CarEnum.CarNumber].Value.ToString();
                textBox_driverName.Text = dataGridView_parkingManager.CurrentRow.Cells[(int)CarEnum.DriverName].Value.ToString();
                textBox_phoneNumber.Text = dataGridView_parkingManager.CurrentRow.Cells[(int)CarEnum.PhoneNumber].Value.ToString();

            }
            catch (Exception exception)
            {

            }
        }

        private void WriteLog(string contents)
        {
            string logContents = "[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss") + "] " + contents; //연/월/일 시:분:초 형식으로 로그찍기
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_parkingSpot_lookUp.Text, out int parkingSpot);
            if (parkingSpot <= 0)
            {
                MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다!!!");
                return;
            }

            //입력한 주차공간번호 조회
            selectQuery(parkingSpot);

            //어차피 주차공간은 pk이므로 Row의 길이는 0아니면 1이다.
            if (dt.Rows.Count < 1) //해당 주차 공간이 없는 경우
            {
                insertQuery(parkingSpot);
                //주차 공간 추가했다고 할 것
                string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}이/가 추가되었습니다.";
                WriteLog(contents);
                selectQuery();
            }
            else
            {
                MessageBox.Show("해당 주차공간은 이미 존재합니다.");
            }

        }

        private void button_AllLookUp_Click(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void textBox_parkingSpot_lookUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }


            //출처: https://terrorjang.tistory.com/39 [개발자 공간]
        }
    }
}
