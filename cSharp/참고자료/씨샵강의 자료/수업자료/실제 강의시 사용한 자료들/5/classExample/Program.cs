using System;

namespace classExample
{
    class Car
    {
        public string carNumber;
        public int inTime;
        public int outTime;
        public bool isAccident;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[5];
            cars[0] = "30고9412";
            cars[1] = "10후1284";
            cars[2] = "32카1554";
            cars[3] = "35거9486";
            cars[4] = "70가9488";
            int idx = -1;
            for(int i = 0; i < cars.Length; i++)
            {
                if(cars[i] == "70겨9488")
                {
                    idx = i;
                    break;
                }
            }
            int[] inTime = new int[5];
            inTime[0] = 0;
            inTime[1] = 12;
            inTime[2] = 19;
            inTime[3] = 20;
            inTime[4] = 10;
            if(idx != -1)
                Console.WriteLine($"주차 시작 시간 : {inTime[idx]}");
            else
                Console.WriteLine("존재하지 않는 차량입니다.");

            int[] outTime = new int[5];
            outTime[0] = 0;
            outTime[1] = 12;
            outTime[2] = 16;
            outTime[3] = 20;
            outTime[4] = 10;

            bool[] isAccident = new bool[5];
            isAccident[0] = true;
            isAccident[1] = true;
            isAccident[2] = true;
            isAccident[3] = false;
            isAccident[4] = false;

            Car[] c_cars = new Car[3];
            c_cars[0].carNumber = "10후1284";
            c_cars[0].inTime = 0;
            c_cars[0].outTime = 1;
            c_cars[0].isAccident = true;

            c_cars[1] = new Car
            {
                carNumber = "30가9412",
                inTime = 1,
                outTime = 2,
                isAccident = true
            };

            c_cars[2] = new Car
            {
                carNumber = "30구9412",
                inTime = 10,
                outTime = 22,
                isAccident = false
            };

            for (int i = 0; i < c_cars.Length; i++)
            {
                if(c_cars[i].inTime == 10 
                    && c_cars[i].outTime == 22)
                {
                    Console.WriteLine($"차 번호 : " +
                        $"{c_cars[i].carNumber}");
                    break;
                }
            }

            for (int i = 0; i < c_cars.Length; i++)
            {
                if(c_cars[i].carNumber == "10후1284")
                {
                    Console.WriteLine($"inTime : " +
                        $"{c_cars[i].inTime}");
                    break;
                }
            }






        }
    }
}
