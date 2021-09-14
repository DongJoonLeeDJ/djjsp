using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace teamProject
{
    class DataManager_comp
    {
        public static List<Entp> Comps = new List<Entp>();
        
        static string[] address = { "대구시 동구 신암4동 ", "서울시 동구 신암4동","광주시 동구 신암4동",
                "인천시 동구 신암4동", "부산시 동구 신암4동"};
        static string[] email = { "hong@naver.com", "lee@gmail.com", "park@daum.net", "choi@hanmail.net", "kim@gmail.com" };
        static Random r = new Random();
        
        static DataManager_comp()
        {
            Load();
        }
        
        public static void Load()
        {
            Comps.Clear();
            try
            {
                string compOutput = File.ReadAllText(@"./drugCompInfo.xml");
                XElement compElement = XElement.Parse(compOutput);
                // XElement <속성명>데이터1</속성명>
                foreach (var item in compElement.Descendants("comp"))
                {
                    string tempEntpName = item.Element("entpName").Value;
                    string tempEntpTel = item.Element("entpTel").Value;
                    string tempEntpAddr = item.Element("entpAddr").Value;
                    string tempEntpEmail = item.Element("entpEmail").Value;

                    Entp tempEntp = new Entp()
                    {
                        entpName = tempEntpName,
                        entpTel = tempEntpTel,
                        entpAddr = tempEntpAddr,
                        entpEmail = tempEntpEmail
                    };
                    Comps.Add(tempEntp);
                }
            }
            catch (Exception ex)
            { 
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                CreateFile(); 
                Save(); 
                Load(); 
                // 단, Load 함수자체가 잘못됐다면 코드는 무한루프
            }
        }

        private static void CreateFile()
        {
            // drugCompInfo.xml파일 생성
            string fileName = @"./drugCompInfo.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose();
        }

        private static XElement getElement()
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList"; // URL
            url += "?ServiceKey=" + "Kbg5ok99gLL7L7nQwR3uRoSjPEYTXU2TceiGRQ59%2F6CO%2BzLEl%2F2GcGh4L8BYBXfhtxbTbuUZmGTjb0%2BabDPX6w%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            return element;
        }

        public static void Save()
        {
            string compOutput = "";
            compOutput += "<comps>\n";

            if (Comps.Count > 0)
            {
                foreach (var item in Comps)
                {
                    compOutput += "<comp>\n";
                    compOutput += $"   <entpName>{item.entpName}</entpName>";
                    compOutput += $"   <entpTel>{item.entpTel}</entpTel>";
                    compOutput += $"   <entpAddr>{item.entpAddr}</entpAddr>";
                    compOutput += $"   <entpEmail>{item.entpEmail}</entpEmail>";
                    compOutput += "</comp>\n";
                }
            }

            else // xml파일에 아무것도 없는 경우
            {
                XElement element = getElement();
                foreach(var item in element.Descendants("item"))
                {
                    compOutput += "<comp>\n";
                    compOutput += $"   <entpName>{item.Element("ENTP_NAME").Value}</entpName>";
                    compOutput += $"   <entpTel>010-{r.Next(1000,10000)}-{r.Next(1000, 10000)}</entpTel>";
                    compOutput += $"   <entpAddr>{address[r.Next(address.Length)]}</entpAddr>";
                    compOutput += $"   <entpEmail>{email[r.Next(email.Length)]}</entpEmail>";
                    compOutput += "</comp>\n";
                }
            }
            compOutput += "</comps>";
            File.WriteAllText(@"./drugCompInfo.xml", compOutput);
        }

        public static void printLog(string contents, string name = "drugComp")
        {
            DirectoryInfo di = new DirectoryInfo("drugComp");
            if (!di.Exists)
            {
                di.Create();
            }
            
            using (StreamWriter writer = new StreamWriter(@"drugComp\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
