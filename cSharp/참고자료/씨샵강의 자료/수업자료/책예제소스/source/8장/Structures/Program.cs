using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    // 코드 8-9: 구조체에 매개변수 없는 생성자는 불가능
    // 오류가 발생하므로 주석 처리했습니다.
    /* struct PointA
    {
        public int x;
        public int y;

        public PointA()
        {

        }
    } */

    // 코드 8-10: 구조체의 생성자
    struct PointB
    {
        public int x;
        public int y;

        public PointB(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    // 코드 8-12: 구조체는 생성자에서 모든 변수를 초기화 해야함
    // 오류가 발생하므로 주석 처리했습니다.
    /* struct PointC
    {
        public int x;
        public int y;
        public string testA;
        public string testB = "init";

        public PointC(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    } */

    // 코드 8-13: 구조체의 초기화 형태
    struct PointD
    {
        public int x;
        public int y;
        public string testA;
        public string testB;

        public PointD(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.testA = "초기화";
            this.testB = "초기화";
        }

        public PointD(int x, int y, string test)
        {
            this.x = x;
            this.y = y;
            this.testA = test;
            this.testB = test;
        }
    }

    // 코드 8-14: 구조체에서 클래스 인스턴스를 멤버 변수로 선언
    struct PointE
    {
        public int x;
        public int y;
        public Program program;

        public PointE(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.program = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
