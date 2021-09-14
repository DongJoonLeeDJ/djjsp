using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarManager_Modified
{
    class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                Cars = (from item in carsXElement.Descendants("car")
                        select new ParkingCar()
                        {
                            ParkingSpot = int.Parse(item.Element("parkingSpot").Value),
                            CarNumber = item.Element("carNumber").Value,
                            DriverName = item.Element("driverName").Value,
                            PhoneNumber = item.Element("phoneNumber").Value,
                            ParkingTime = item.Element("parkingTime").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value) //parkingTime값이 없는 경우(주차하지 않은 경우) Today값을 넣어둠. 아무것도 없으면 에러나서 실행 안 됨
                        }).ToList<ParkingCar>();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Cars 파일이 누락되었습니다!!!");
                CreateFile(); //파일 새로 만들기
                Save(); //만들어진 파일에 텍스트 저장
                Load(); //저장된 파일을 다시 불러들이기
            }
        }

        public static void CreateFile()
        {
            string fileName = @"./Cars.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }

        public static void Save()
        {
            // 도서 XML 생성
            string booksOutput = "";
            booksOutput += "<cars>\n";
            if(Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += "  <parkingSpot>" + item.ParkingSpot + "</parkingSpot>\n";
                    booksOutput += "  <carNumber>" + item.CarNumber + "</carNumber>\n";
                    booksOutput += "  <driverName>" + item.DriverName + "</driverName>\n";
                    booksOutput += "  <phoneNumber>" + item.PhoneNumber + "</phoneNumber>\n";
                    booksOutput += "  <parkingTime>" + item.ParkingTime + "</parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            else //CreateFile에 의하여 파일을 만든 경우
            {
                for(int i = 1; i <=5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"  <parkingSpot>{i}</parkingSpot>\n";
                    booksOutput += "  <carNumber></carNumber>\n";
                    booksOutput += "  <driverName></driverName>\n";
                    booksOutput += "  <phoneNumber></phoneNumber>\n";
                    booksOutput += "  <parkingTime></parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            booksOutput += "</cars>";


            // 저장
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        public static void PrintLog(string contents) //ParkingHistory 폴더 안의 ParkingHistory.txt파일에 로그 저장
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ParkingHistory" + "\\" + "ParkingHistory" + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
