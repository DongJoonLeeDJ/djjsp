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
using System.Xml.Linq;

namespace UI
{
    public partial class Main : Form
    {
        XElement api;
        string id = "";
        public Main(string id, string log)
        {
            InitializeComponent();
            this.id = id;
            UserID.Text = id + "님 환영합니다.";
            if (log != "")
            {
                ID_Log.Text = "최근 로그인 기록 " + log;
            }
            else if (log == "")
            {
                ID_Log.Text = "";
            }
        }



        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int resecd = 0;
            if (ListCombo.Text == "분양")     //콤보박스의 텍스트에따라 다른 값을 가져감
                resecd = 0;
            else
                resecd = 1;

            string url = "http://openapi.reb.or.kr/OpenAPI_ToolInstallPackage/service/rest/ApplyhomeInfoSvc/getLttotPblancList"; // URL
            url += "?ServiceKey=" + "ZmJyMxFZQDFPzAmik%2BXLwqjUUXhtJZaY4PpaYdAjzDFJUVTZSvdUxAuSIemiVzAG7P87RiVVA7Tz%2F3pVeWuiyw%3D%3D"; // Service Key
            url += "&startmonth=" + DateTime.Now.ToString("yyyy") + "01";
            url += "&endmonth=" + DateTime.Now.ToString("yyyy") + "12";
            url += "&sido=" + Addr_Combo.Text;
            url += "&rentSecd=" + resecd;

            Console.WriteLine(url);

            api = XElement.Load(url);
            List<Data> data = new List<Data>();

            foreach (var item in api.Descendants("item"))
            {
                if (int.Parse(DateTime.Now.ToString("yyyyMMdd").Replace("-", "")) < int.Parse(item.Element("rceptEndde").Value.Replace("-", "")))
                {   //이미 끝난 분양을 제거하기 위해 IF문을 사용하여 제거해줌 , 분양 시작날자와 종료날자가 월로 들어가고 일을 들어가지 않기때문에 발생함
                    string sido = item.Element("sido").Value;
                    string rentSecdNm = item.Element("rentSecdNm").Value;
                    string houseName = item.Element("housename").Value;
                    string rceptBgnde = item.Element("rceptBgnde").Value;
                    string rceptEndde = item.Element("rceptEndde").Value;
                    string przwnerPresnatnDe = item.Element("przwnerPresnatnDe").Value;
                    data.Add(new Data(sido, rentSecdNm, houseName, rceptBgnde, rceptEndde, przwnerPresnatnDe));
                }
            }
            View_data.DataSource = data;

            if (data.Count == 0)
            {
                MessageBox.Show(ListCombo.Text + " 정보가 없습니다.");        //분양 정보가 없을 때에는   
            }
            else
            {
                View_data.Rows[0].Cells[0].Selected = false;
            }
        }

        private void View_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string houseName_temp = View_data.SelectedCells[2].Value.ToString();
            try      //try catch문을 이용하여 datagridview 헤더부분 클릭시 오류를 방지함
            {
                string houseManageNo = "";
                string pblancNo = "";
                foreach (var item in api.Descendants("item"))
                {
                    if (item.Element("housename").Value == houseName_temp)
                    {
                        houseManageNo = item.Element("houseManageNo").Value;
                        pblancNo = item.Element("pblancNo").Value;
                    }
                }

                //주택 도로명주소 받아오는 api
                string url2 = "http://openapi.reb.or.kr/OpenAPI_ToolInstallPackage/service/rest/ApplyhomeInfoSvc/getAPTLttotPblancDetail"; // URL
                url2 += "?ServiceKey=" + "ZmJyMxFZQDFPzAmik%2BXLwqjUUXhtJZaY4PpaYdAjzDFJUVTZSvdUxAuSIemiVzAG7P87RiVVA7Tz%2F3pVeWuiyw%3D%3D"; // Service Key
                url2 += "&houseManageNo=" + houseManageNo;
                url2 += "&pblancNo=" + pblancNo;
                Console.WriteLine(url2);
                XElement api2 = XElement.Load(url2);
                string hssplyadres = "";
                string housenm = "";
                string hmpgadres = "";
                foreach (var item in api2.Descendants("item"))
                {
                    hssplyadres = item.Element("hssplyadres").Value;
                    housenm = item.Element("housenm").Value;
                    hmpgadres = item.Element("hmpgadres").Value;
                }

                //주택가격 , 공급평수 받아오는 api
                string url3 = "http://openapi.reb.or.kr/OpenAPI_ToolInstallPackage/service/rest/ApplyhomeInfoSvc/getAPTLttotPblancMdl";
                url3 += "?ServiceKey=" + "ZmJyMxFZQDFPzAmik%2BXLwqjUUXhtJZaY4PpaYdAjzDFJUVTZSvdUxAuSIemiVzAG7P87RiVVA7Tz%2F3pVeWuiyw%3D%3D";
                url3 += "&houseManageNo=" + houseManageNo;
                url3 += "&pblancNo=" + pblancNo;
                XElement api3 = XElement.Load(url3);
                List<mount> mountdata = new List<mount>();

                foreach (var item in api3.Descendants("item"))
                {
                    string lttottopamount = item.Element("lttottopamount").Value;
                    string housety = item.Element("housety").Value;
                    mountdata.Add(new mount(lttottopamount, housety));
                }
                new Form1(hssplyadres, housenm, hmpgadres, mountdata).Show();
            }
            catch (Exception)
            {

            }
        }

        private void guna2Button_logout_Click(object sender, EventArgs e)
        {
            Dispose();
            new Login().Show();

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Helper.ReleaseCapture();
                Helper.SendMessage(Handle, Helper.WM_NCLBUTTONDOWN, Helper.HT_CAPTION, 0);
            }
        }
    }
    
}
