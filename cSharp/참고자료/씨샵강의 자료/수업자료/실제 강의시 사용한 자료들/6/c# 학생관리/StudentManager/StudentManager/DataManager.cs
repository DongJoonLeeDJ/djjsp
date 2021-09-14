using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace StudentManager
{
    class DataManager
    {
        public static List<Student> Students = new List<Student>();
        public static List<Major> Majors = new List<Major>();

        public static void Load_Students()
        {
            try
            {
                Students.Clear();
                string sOutput = File.ReadAllText(@"./studentsList.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("student"))
                {
                    string name = item.Element("name").Value;
                    string Id = item.Element("id").Value;
                    double Score = double.Parse(item.Element("score").Value);
                    int Grade = int.Parse(item.Element("grade").Value);
                    DateTime temp_RegDate = item.Element("regDate").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("regDate").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감

                    Student tempStudent = new Student()
                    {
                        mName = name,
                        mId = Id,
                        mScore = Score,
                        mGrade = Grade,
                        RegDate = temp_RegDate
                    };
                    Students.Add(tempStudent);
                }

                //Cars = (from item in carsXElement.Descendants("")
                //        select new ParkingCar()
                //        {
                //            ParkingSpot = int.Parse(item.Element("parkingSpot").Value),
                //            CarNumber = item.Element("carNumber").Value,
                //            DriverName = item.Element("driverName").Value,
                //            PhoneNumber = item.Element("phoneNumber").Value,
                //            ParkingTime = item.Element("parkingTime").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value) //parkingTime값이 없는 경우(주차하지 않은 경우) Today값을 넣어둠. 아무것도 없으면 에러나서 실행 안 됨
                //        }).ToList<ParkingCar>();

                //XmlDocument xmlDoc = new XmlDocument();
                // xml.Load("D:\\test\\config.xml"); //"D:\\test\\config.xml" == @"D:\test\config.xml"
                // 출처: https://yi-chi.tistory.com/91 [2chi]
                //xmlDoc.Load(@"./studentsList.xml");
                //XmlNodeList xmlList = xmlDoc.SelectNodes("/students/student");
                /*
                 *  public string mName; //학생 이름
                    public string mId; //학생 학번
                    public double mScore; //학생 성적
                    public int mGrade; //학생 학년
                    public DateTime RegDate; //학생 등록 날짜

                    <name>이동준</name>
                    <id>2009038033</id>
                    <score>3.0</score>
                    <grade>4</grade>
                    <regDate>2020-08-10 오후 12:23:22</regDate>
                 */
                //foreach (XmlNode item in xmlList)
                //{
                //    string name = item.SelectSingleNode("name").Value;
                //    string Id = item.SelectSingleNode("id").Value;
                //    double Score = double.Parse(item.SelectSingleNode("score").Value);
                //    int Grade = int.Parse(item.SelectSingleNode("grade").Value);
                //    DateTime temp_RegDate = DateTime.Parse(item.SelectSingleNode("regDate").Value);

                //    Student tempStudent = new Student()
                //    {
                //        mName = name,
                //        mId = Id,
                //        mScore = Score,
                //        mGrade = Grade,
                //        RegDate = temp_RegDate
                //    };
                //    Students.Add(tempStudent);
                //}
            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_students();
                Save_Students();
                Load_Students();
            }
        }
        public static void Save_Students()
        {
            string studentsOutput = "";
            studentsOutput += "<students>" + Environment.NewLine;
            if(Students.Count > 0)
            {
                foreach (var item in Students)
                {
                    studentsOutput += "<student>" + Environment.NewLine;
                    studentsOutput += "     <name>"+item.mName+"</name>" + Environment.NewLine;
                    studentsOutput += "     <id>"+item.mId+"</id>" + Environment.NewLine;
                    studentsOutput += "     <score>"+item.mScore+"</score>" + Environment.NewLine;
                    studentsOutput += "     <grade>"+item.mGrade+"</grade>" + Environment.NewLine;
                    studentsOutput += "     <regDate>" + item.RegDate+ "</regDate>" + Environment.NewLine;
                    studentsOutput += "</student>" + Environment.NewLine;
                }
            }
            else
            {
                studentsOutput += "<student>" + Environment.NewLine;
                studentsOutput += "     <name>" + "" + "</name>" + Environment.NewLine;
                studentsOutput += "     <id>" + "" + "</id>" + Environment.NewLine;
                studentsOutput += "     <score>" + "" + "</score>" + Environment.NewLine;
                studentsOutput += "     <grade>" + "" + "</grade>" + Environment.NewLine;
                studentsOutput += "     <regDate>" + "" + "</regDate>" + Environment.NewLine;
                studentsOutput += "</student>" + Environment.NewLine;

            }

            studentsOutput += "</students>" + Environment.NewLine;

            File.WriteAllText(@"./studentsList.xml", studentsOutput);

        }
        public static void CreateFile_students()
        {
            string fileName = @"./studentsList.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
        public static void Load_Majors()
        {
            try
            {
                Majors.Clear();
                string sOutput = File.ReadAllText(@"./majorsList.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("major"))
                {
                    string name = item.Element("name").Value;
                    string code = item.Element("code").Value;

                    Major temp = new Major()
                    {
                        mMajorName = name,
                        mMajorCode = code
                    };
                    Majors.Add(temp);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_majors();
                Save_Majors();
                Load_Majors();
            }
        }
        public static void Save_Majors()
        {
            string majorsOutput = "";
            majorsOutput += "<majors>" + Environment.NewLine;
            if (Majors.Count > 0)
            {
                foreach (var item in Majors)
                {
                    majorsOutput += "<major>" + Environment.NewLine;
                    majorsOutput += "     <name>" + item.mMajorName + "</name>" + Environment.NewLine;
                    majorsOutput += "     <code>" + item.mMajorCode + "</code>" + Environment.NewLine;
                    majorsOutput += "</major>" + Environment.NewLine;
                }
            }
            else
            {
                majorsOutput += "<major>" + Environment.NewLine;
                majorsOutput += "     <name>" + "" + "</name>" + Environment.NewLine;
                majorsOutput += "     <code>" + "" + "</code>" + Environment.NewLine;
                majorsOutput += "</major>" + Environment.NewLine;

            }

            majorsOutput += "</majors>" + Environment.NewLine;

            File.WriteAllText(@"./majorsList.xml", majorsOutput);
        }
        public static void CreateFile_majors()
        {
            string fileName = @"./majorsList.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ProgramHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ProgramHistory" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]"+contents);
            }
        }
    }
}
