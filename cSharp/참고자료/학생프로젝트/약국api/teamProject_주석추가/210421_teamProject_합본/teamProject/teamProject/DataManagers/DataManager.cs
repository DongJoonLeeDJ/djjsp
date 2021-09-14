using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace teamProject
{
    class DataManager
    {
        public static List<Drug> drugs = new List<Drug>();
       
        static Random r = new Random();
        
        static DataManager()
        {
            Load();
        }
        
        public static void Load()
        {
            drugs.Clear();
            try
            {
                string compOutput = File.ReadAllText(@"./drugInfo.xml");
                XElement compElement = XElement.Parse(compOutput);
                // XElement <속성명>데이터1</속성명>
                foreach (var item in compElement.Descendants("drug"))
                {
                    string tempmedName = item.Element("medName").Value;
                    string tempmedComp = item.Element("medComp").Value;
                    string tempmedId = item.Element("medId").Value;
                    string tempchart = item.Element("chart").Value;
                    string tempclassName = item.Element("className").Value;
                    string tempformName = item.Element("formName").Value;
                    string tempmainIngr = item.Element("mainIngr").Value;
                    string tempstock = item.Element("stock").Value;

                    drugs.Add(new Drug(tempmedName,tempmedId,tempmedComp,tempchart,tempformName,tempclassName,tempmainIngr,int.Parse(tempstock)));
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
            string fileName = @"./drugInfo.xml";
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
            string compOutput = ""; // 비워주고
            compOutput += "<drugs>\n";

            if (drugs.Count > 0)
            {
                // xml 파일에 붙여넣기
                foreach (var item in drugs)
                {
                    compOutput += "<drug>\n";
                    compOutput += $"   <medName>{item.MedName}</medName>";
                    compOutput += $"   <medComp>{item.MedComp}</medComp>";
                    compOutput += $"   <medId>{item.MedId}</medId>";
                    compOutput += $"   <chart>{item.Chart}</chart>";
                    compOutput += $"   <formName>{item.FormName}</formName>";
                    compOutput += $"   <className>{item.ClassName}</className>";
                    compOutput += $"   <mainIngr>{item.MainIngr}</mainIngr>";
                    compOutput += $"   <stock>{item.Stock}</stock>";
                    compOutput += "</drug>\n";
                }
            }

            else // xml파일에 아무것도 없는 경우
            {
                XElement element = getElement(); // api 새로 땡겨오고
                foreach(var item in element.Descendants("item"))
                {
                    compOutput += "<drug>\n";
                    compOutput += $"   <medName>{item.Element("ITEM_NAME").Value}</medName>";
                    compOutput += $"   <medComp>{item.Element("ENTP_NAME").Value}</medComp>";
                    compOutput += $"   <medId>{item.Element("ITEM_SEQ").Value}</medId>";
                    compOutput += $"   <chart>{item.Element("CHART").Value}</chart>";
                    compOutput += $"   <formName>{item.Element("FORM_NAME").Value}</formName>";
                    compOutput += $"   <className>{item.Element("CLASS_NAME").Value}</className>";
                    compOutput += $"   <mainIngr>{item.Element("MAIN_INGR").Value}</mainIngr>";
                    compOutput += $"   <stock>{r.Next(1000)}</stock>";

                    compOutput += "</drug>\n";
                }
            }
            compOutput += "</drugs>";
            File.WriteAllText(@"./drugInfo.xml", compOutput);
        }

        public static void printLog(string contents, string name = "drug")
        {
            DirectoryInfo di = new DirectoryInfo("drug");
            if (!di.Exists)
            {
                di.Create();
            }
            
            using (StreamWriter writer = new StreamWriter(@"drug\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
