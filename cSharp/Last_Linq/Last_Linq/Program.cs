using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Last_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xxElement = XElement.Load(url);

            //1과 2는 사실상 동일한 코드이며, 1은 xml에 있는 것 다 긁어오지만
            //2는 hour값과 day값만 가져오고 있음 ㅜㅜ

            //1. linq 쓴 버전
            var xmlQuery = from item in xxElement.Descendants("data") select item;

            //2. linq 안 쓴 버전
            List<string> ttt = new List<string>();
            foreach (var item in xxElement.Descendants("data"))
            {
                //item에 있는 것들을 일일히 다 추가해줘야 하고
                //따로 클래스를 만들어야 할 수도 있다.
                ttt.Add(item.Element("hour").Value + item.Element("day").Value);
            }

            foreach (var item in xmlQuery)
            {
                System.Console.WriteLine(item);
            }

            //필요한 것만 정렬해서 출력
            foreach (var item in xmlQuery)
            {
                System.Console.Write(item.Element("hour").Value+ "\t");
                System.Console.Write(item.Element("day").Value+ "\t");
                System.Console.Write(item.Element("temp").Value+ "\t");
                System.Console.WriteLine();
            }


            var xmlQuery2 = from item in xxElement.Descendants("data")
                            select
                            new { 
                                    Hour = item.Element("hour").Value,
                                    Day = item.Element("day").Value,
                                    Temp = item.Element("temp").Value
                                }; //익명 객체

            //필요한 것만 정렬해서 출력
            foreach (var item in xmlQuery2)
            {
                System.Console.Write(item.Hour + "\t");
                System.Console.Write(item.Day + "\t");
                System.Console.Write(item.Temp + "\t");
                System.Console.WriteLine();
            }

            var xmlQuery3 = from item in xxElement.Descendants("data")
                            select
                            new Weather()
                            {
                                Hour = item.Element("hour").Value,
                                Day = item.Element("day").Value,
                                Temp = item.Element("temp").Value
                            };

            //필요한 것만 정렬해서 출력 xmlQuery2와 동일
            foreach (var item in xmlQuery3)
            {
                System.Console.Write(item.Hour + "\t");
                System.Console.Write(item.Day + "\t");
                System.Console.Write(item.Temp + "\t");
                System.Console.WriteLine();
            }
        }
    }
}
