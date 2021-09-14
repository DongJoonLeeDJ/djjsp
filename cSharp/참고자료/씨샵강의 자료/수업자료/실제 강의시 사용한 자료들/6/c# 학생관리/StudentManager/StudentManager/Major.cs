using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Major
    {
        public string mMajorName { get; set; } //학과명
        public string mMajorCode { get; set; } //학과코드    int로 할 경우 문제 발생함. y2k 예로 들기. 그리고 033이 33으로 저장되는 것도 설명하기
    }
}
