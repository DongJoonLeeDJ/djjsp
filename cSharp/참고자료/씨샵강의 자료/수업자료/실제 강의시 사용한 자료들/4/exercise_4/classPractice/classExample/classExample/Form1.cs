using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classExample
{

    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public int mId;
            public string mMajor;
            public double mGrade;
            public int mGender; //0 : 남 1: 여

            public void mStudy()
            {
                Console.WriteLine("공부중...");
            }

            public void mPlay()
            {
                Console.WriteLine("노는중...");
            }

            public static string mIdentity = "공부하는 사람";
        }

        public Form1()
        {
            InitializeComponent();

            //김성영, 권강혁, 이동준...
            string[] studentname = new string[4];
            int[] id = new int[4];

            studentname[0] = "김성영";
            studentname[1] = "권강혁";
            studentname[2] = "이동준";
            studentname[3] = "이동준";

            id[0] = 9004;
            id[1] = 1001;
            id[2] = 0902;
            id[3] = 1901;

            string tempStudent;
            tempStudent = studentname[0];
            int tempId;
            tempId = id[0];

            /*
             public string name;
            public int id;
            public string major;
            public double grade;
            public int gender; //0 : 남 1: 여*/
            Student[] students = new Student[3];

            Student temporaryStdeunt = new Student();
            temporaryStdeunt.mName = "이동준";
            temporaryStdeunt.mId = 0909;
            temporaryStdeunt.mMajor = "정보전자과";
            temporaryStdeunt.mGrade = 3.0;
            temporaryStdeunt.mGender = 0;

            students[0] = temporaryStdeunt;


            Student temporaryStdeunt2 = new Student();
            temporaryStdeunt2.mName = "김성영";
            temporaryStdeunt2.mId = 1919;
            temporaryStdeunt2.mMajor = "컴퓨터공학과";
            temporaryStdeunt2.mGrade = 4.5;
            temporaryStdeunt2.mGender = 0;

            students[1] = temporaryStdeunt2;

            students[2] = new Student() { mName = "김은주", mId = 1919, mMajor = "컴퓨터공학과", mGrade = 4.5, mGender = 1 };





            //students[0].mName = "김성영";
            //students[0].mId = 9004;
            //students[0].mMajor = "컴퓨터공학";
            //students[0].mGrade = 4.5;
            //students[0].mGender = 0;


            //Student tempStudentData = students[0];
            //tempStudentData.mStudy();

            //students[1].mName = "권강혁";
            //students[1].mId = 1001;
            //students[1].mMajor = "축구";
            //students[1].mGrade = 2.0;
            //students[1].mGender = 0;

            //Student SoccerStudent = students[1];
            //SoccerStudent.mPlay();

            //students[2].mName = "유니나";
            //students[2].mId = 2020;
            //students[2].mMajor = "뷰티헤어과";
            //students[2].mGrade = 4.3;
            //students[2].mGender = 1;



            Console.WriteLine(Student.mIdentity);
            Console.WriteLine(Math.PI);



        }
    }
}
