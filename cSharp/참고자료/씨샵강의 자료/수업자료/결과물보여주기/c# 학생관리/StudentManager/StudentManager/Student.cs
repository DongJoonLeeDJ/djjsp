using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        public string mName { get; set; } //학생 이름
        public string mId { get; set; } //학생 학번
        public double mScore { get; set; } //학생 성적
        public int mGrade { get; set; } //학생 학년
        public DateTime RegDate { get; set; } //학생 등록 날짜
    }
}
