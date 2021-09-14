using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXML
{
    class Program
    {
        class Weather
        {
            public string Hour { get; set; }
            public string Day { get; set; }
            public string Wf { get; set; }
            public string Temp { get; set; }
            public string WdKor { get; set; }
            public string WfKor { get; set; }
            public string Tmn { get; set; }
            public string Tmx { get; set; }
        }

        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            //string url = @"D:\test\Books.xml";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("book")
                           select new Weather()
                           {
                               Hour = item.Element("isbn").Value,
                               Day = item.Element("name").Value,
                               Temp = item.Element("publisher").Value,
                               WdKor = item.Element("page").Value,
                               WfKor = item.Element("borrowedAt").Value,
                               Tmn = item.Element("isBorrowed").Value,
                               Tmx = item.Element("userId").Value
                           };

            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.Write(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
