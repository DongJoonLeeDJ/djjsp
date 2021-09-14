using Book_re.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Book_re
{
    public class KaKaoAPI
    {



        public static List<MyLocale> Search(string qstr)

        {

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";

            string query = string.Format("{0}?query={1}", site, qstr);





            string rkey = "7c8f707824137ab3e4a20995632bf4e4";

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
}
