using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    // 코드 6-26: Box 클래스
    class BoxA
    {
        public int width;
        public int height;

        public BoxA(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }

    // 코드 6-27: 변수 {{width}}와 {{height}}를 건드리지 못하게 수정
    class BoxB
    {
        private int width;
        private int height;

        public BoxB(int width, int height)
        {
            if (width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }

    // 코드 6-28: 겟터와 셋터
    class BoxC
    {
        // 변수
        private int width;
        private int height;

        // 생성자
        public BoxC(int width, int height)
        {
            if (width > 0 || height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }

        // 인스턴스 메서드
        public int Area() { return this.width * this.height; }

        // 겟터(Getter)
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        // 셋터(Setter)
        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
        }

        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //값 복사
            List<int> original = new List<int>();
            List<int> copy = new List<int>(original);

            //참조 복사
            copy = original;

           
        }
    }
}
