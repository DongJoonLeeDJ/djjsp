using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_Modified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try //DB에 행이 하나도 없는 경우에 대한 예외 처리 추가
            {
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carNumber.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_driverName.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber.ToString();
            }
            catch(Exception e)
            {
                DataManager.PrintLog(e.Message);
                DataManager.PrintLog(e.StackTrace);
            }
            dataGridView_parkingManager.DataSource = DataManager.Cars;

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
                    //이미 해당 공간에 차가 있는 경우에는 안 된다고 하기
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text.ToString());
                    if (car.CarNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공간에는 이미 차가 존재합니다.");
                    }
                    else
                    {
                        //참조 복사를 사용하므로, car의 속성이 바뀌면 Cars에 있는 해당 속성들이 바뀐다.
                        car.ParkingSpot = int.Parse(textBox_parkingSpot.Text);
                        car.CarNumber = textBox_carNumber.Text;
                        car.DriverName = textBox_driverName.Text;
                        car.PhoneNumber = textBox_phoneNumber.Text;
                        car.ParkingTime = DateTime.Now;

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;
                        //바뀐 List 값을 DB Table에도 업데이트해줘야 함
                        DataManager.Save(textBox_parkingSpot.Text, textBox_carNumber.Text, textBox_driverName.Text, textBox_phoneNumber.Text);

                        string contents = $"주차 공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차하였습니다.";
                        
                        //이 두 줄과 아래 한 줄은 같은 기능
                        //DataManager.PrintLog(contents);
                        //MessageBox.Show(contents);
                        
                        WriteLog(contents);
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
            //차량번호나 공간번호 입력 필수
            if (textBox_parkingSpot.Text.Trim() == "")
            {
                MessageBox.Show("주차공간을 입력해주세요.");
            }
            else//존재하지 않은 경우에 알람(add와 반대)
            {
                try
                {
                    //해당 공간에 차가 아직 없는 경우에는 안 된다고 하기
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text.ToString());
                    if (car.CarNumber.Trim() == "")
                    {
                        MessageBox.Show("해당 공간에는 아직 주차된 차가 없습니다.");
                    }
                    else
                    {
                        //참조 복사를 사용하므로, car의 속성이 바뀌면 Cars에 있는 해당 속성들이 바뀐다.
                        string oldcar = car.CarNumber;
                        car.ParkingSpot = int.Parse(textBox_parkingSpot.Text);
                        car.CarNumber = "";
                        car.DriverName = "";
                        car.PhoneNumber = "";
                        car.ParkingTime = new DateTime();

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;
                        bool isRemove = true; //가독성을 위하여 변수를 선언 후 파라메터에 넣음
                        DataManager.Save(textBox_parkingSpot.Text, "", "", "", isRemove);
                        string contents = $"{oldcar}차를 주차 공간 {textBox_parkingSpot.Text}에서 출차하였습니다.";

                        //이 두 줄과 아래 한 줄은 같은 기능
                        //DataManager.PrintLog(contents);
                        //MessageBox.Show(contents);

                        WriteLog(contents);
                    }

                }
                catch (Exception)
                {
                    //아예 없는 주차공간일 경우
                    string contents = $"출차할 수 없습니다. 주차공간 {textBox_parkingSpot.Text} 은(는) 존재하지 않습니다.";
                    MessageBox.Show(contents);
                }
            }

        }

        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {

            try
            {
                int parkingSpot = int.Parse(textBox_parkingSpot_lookUp.Text);
                string ParkedCar = lookUpParkingFunction(parkingSpot);
                if (ParkedCar != "")
                {
                    string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.";

                    //이 두 줄과 아래 한 줄은 같은 기능
                    //DataManager.PrintLog($"주차공간 {textBox_carNumber_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.");
                    //MessageBox.Show($"주차공간 {textBox_carNumber_lookUp.Text}에 주차되어 있는 차는 {ParkedCar}입니다.");
                    
                    WriteLog(contents);
                }
                else
                {
                    string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}에 주차된 차가 없습니다.";

                    //이 두 줄과 아래 한 줄은 같은 기능
                    //DataManager.PrintLog($"주차공간 {textBox_carNumber_lookUp.Text}에 주차된 차가 없습니다.");
                    //MessageBox.Show($"주차공간 {textBox_carNumber_lookUp.Text}에 주차된 차가 없습니다.");
                    
                    WriteLog(contents);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("주차공간번호가 유효하지 않습니다.");
            }

        }

        private string lookUpParkingFunction(int parkingSpot) //조회하는 함수(연계 필요 데이터 식별)
        {
            try
            {
                // 공간 번호를 받는다, Single로 조회를 한다.(ver1)
                //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot == parkingSpot);
                //string ParkedCarNumber = car.CarNumber;
                //return ParkedCarNumber;

                //ver2
                // foreach문으로 조회한다.(single이 어려울 경우)
                string ParkedCarNumber = "";
                foreach (var item in DataManager.Cars)
                {
                    if (item.ParkingSpot == parkingSpot)
                        ParkedCarNumber = item.CarNumber;
                }
                return ParkedCarNumber;

            }
            catch(Exception e)
            {
                throw;
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
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;

                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.CarNumber;
                textBox_driverName.Text = car.DriverName;
                textBox_phoneNumber.Text = car.PhoneNumber;

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

        private void button_AllLookUp_Click(object sender, EventArgs e)
        {
            //select * 문을 다시 실행함
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            dataGridView_parkingManager.DataSource = DataManager.Cars;
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
            DBHelper.selectQuery(parkingSpot);

            //어차피 주차공간은 pk이므로 Row의 길이는 0아니면 1이다.
            if (DBHelper.dt.Rows.Count < 1) //해당 주차 공간이 없는 경우
            {
                DBHelper.insertQuery(parkingSpot);
                //주차 공간 추가했다고 할 것
                string contents = $"주차공간 {textBox_parkingSpot_lookUp.Text}이/가 추가되었습니다.";
                WriteLog(contents);
                button_AllLookUp.PerformClick(); //button_AllLookUp 버튼 클릭하게 하기
            }
            else
            {
                MessageBox.Show("해당 주차공간은 이미 존재합니다.");
            }
        }
    }
}
