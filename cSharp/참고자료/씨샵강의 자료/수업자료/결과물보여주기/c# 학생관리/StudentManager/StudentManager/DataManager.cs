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
                    double Score = 0;
                    double.TryParse(item.Element("score").Value, out Score);
                    int Grade = 0;
                    int.TryParse(item.Element("grade").Value, out Grade);
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
