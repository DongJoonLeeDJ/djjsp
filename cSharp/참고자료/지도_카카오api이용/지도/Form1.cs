using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;


namespace 지도
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyLocale

        {


            public string Name

            {

                get;

                private set;

            }

            public double Lat

            {

                get;

                private set;

            }



            public double Lng

            {

                get;

                private set;

            }



            public MyLocale(string name, double lat, double lng)

            {

                Name = name;

                Lat = lat;

                Lng = lng;

            }

            public override string ToString()

            {

                return Name;

            }

        }
        public class KaKaoAPI

        {



            public static List<MyLocale> Search(string qstr)

            {

                string site = "https://dapi.kakao.com/v2/local/search/keyword.json";

                string query = string.Format("{0}?query={1}", site, qstr);



      

                string rkey = "6c8825b9af60f0a4f8d0d34f86e89e2b";

                string header = "KakaoAK " + rkey;
                   WebRequest request = WebRequest.Create(query);

                request.Headers.Add("Authorization", header);
             



                WebResponse response = request.GetResponse();

                Stream stream = response.GetResponseStream();

                StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                String json = reader.ReadToEnd();



                JavaScriptSerializer js = new JavaScriptSerializer();

                dynamic dob = js.Deserialize<dynamic>(json);

                dynamic docs = dob["documents"];

                object[] buf = docs;

                int length = buf.Length;



                List<MyLocale> mls = new List<MyLocale>();

                for (int i = 0; i < length; i++)

                {

                    string lname = docs[i]["place_name"];

                    double x = double.Parse(docs[i]["x"]);

                    double y = double.Parse(docs[i]["y"]);

                    mls.Add(new MyLocale(lname, y, x));

                }

                return mls;

            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string qstr = textBox1.Text;

            List<MyLocale> mls = KaKaoAPI.Search(qstr);

            Listbox.Items.Clear();
            foreach(MyLocale locale in mls)
            {
                Listbox.Items.Add(locale);
            }
        }

        private void Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Listbox.SelectedIndex == -1)
            {
                return;
            }
            MyLocale ml = Listbox.SelectedItem as MyLocale;
            object[] ps = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", ps);


        }
    }


   


}
