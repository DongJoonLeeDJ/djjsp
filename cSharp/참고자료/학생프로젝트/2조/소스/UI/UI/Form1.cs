using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class Form1 : Form
    {
        string hssplyadres = "";        //건물 주소
        string housenm = "";            //건물 이름
        string hmpgAdres = "";            //건물 이름
        List<mount> mountdata;
        List<Tuple<string, double, double>> tuples = new List<Tuple<string, double, double>>();
        public Form1(string hssplyadres, string housenm, string hmpgAdres, List<mount> temp)
        {
            InitializeComponent();
            this.hssplyadres = hssplyadres;         //건물 주소
            this.housenm = housenm;                 //건물 이름
            this.hmpgAdres = hmpgAdres;
            this.mountdata = temp;                  //List<mount>형태의 리스트 데이터를 저장해 차트에 표현하기 위해 정보를 받아옴
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // WebBrowser 컨트롤에 "googleMap.html" 을 표시한다. 
            Version ver = Map_View.Version;
            string name = Map_View.ProductName;
            string str = Map_View.ProductVersion;
            string html = "googleMap.html";
            string dir = System.IO.Directory.GetCurrentDirectory(); //기본 실행경로, Debug파일에서 실행됨(C:\Users\(USERNAME명)\Desktop\C#\Map\bin\Debug)
            string path = System.IO.Path.Combine(dir, html);
            Map_View.Navigate(path); // html파일 경로와 html파일 명을 path로 조립 해 WebBrowser.Navigate에 넣어줌
        }


        private void ShowMap() // 받은 정보를 지도에 표시
        {
            if (hssplyadres.Substring(0, 2) == "경기" && hssplyadres.Contains("(")) //경기도 주소를 받아올때 쓸모없는 정보가 많아서 오류가 뜨기 때문에 예외처리함,
            {                                                                  // 주소가 경기로 시작하고 주소에 괄호가 존재할시에(Contains("(")) 예외처리
                int Index = hssplyadres.LastIndexOf('(');                      //주소의 마지막 '('부분의 인덱스를 찾아서 마지막인덱스까지의 문자를 가져옴
                hssplyadres = hssplyadres.Substring(Index);
            }
            object[] addr = new object[] { hssplyadres, housenm, hmpgAdres };             // 건물 주소 , 건물 이름
            HtmlDocument doc = Map_View.Document;                              //HtmlDocument 객체를 이용하여 WebBrowser에 화면을 표현함

            if (doc != null)
            {
                doc.InvokeScript("codeAddress", addr);                        //HTML파일안의 JAVASCRIPT의 객체인 codeAddress를 찾아서 addr배열을 넘겨줌
            }
        }

        //차트 그리기
        const string COL00 = "전용면적(m²)";
        private void Map_View_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)//실행 될 때의 오류를 예방하기 위해 WebBrowser가 완전히 실행된 후 아래의 메서드 실행
        {
            ShowMap();
            showChart();
        }

        private void showChart()
        {
            chart1.Series.Clear();

            chart1.Series.Add(COL00);

            foreach (mount temp in mountdata)
            {
                string firststr = temp.housety.Substring(0, 3);        //필요없는 문자열 잘라줌
                string laststr = temp.housety.Substring(8, 1);
                string resultstr = (laststr != null) ? firststr + laststr : firststr;
                chart1.Series[COL00].Points.AddXY((resultstr), temp.lttottopamount);
                chart1.Series[COL00].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }


        Point? prevPosition = null;     //툴팁 객체를 이용하기 위해 사용
        ToolTip tooltip = new ToolTip();
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();//마우스커서가 멀어질시 툴팁 제거
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);
                        chart1.Series[COL00].ToolTip = "#VALY"; //특정 막대바에 마우스가 올라갈시 그 값을 표시

                    }
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void guna2Button_logout_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Helper.ReleaseCapture();
                Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
            }
        }
    }
}
