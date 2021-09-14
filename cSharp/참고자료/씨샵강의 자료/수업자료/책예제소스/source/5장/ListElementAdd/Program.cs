using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListElementAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수를 선언합니다.
            List<int> list = new List<int>();

            // 리스트에 요소를 추가합니다.
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            // 반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }
        }
    }
}
