using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
//참조에서 System.Web.Extensions를 반드시 추가해야 함

//저 주소에서 반환되는 json을 내가 쓰기 편하게 파싱 가능함
namespace KaKaoApiMapView
{
    public class KaKaoAPI
    {
        //ListBox에 있는 지명 클릭해서
        //그 지명을 검색해서
        //그 지명에 연관된 지역들을 반환하는 함수
        public static List<MyLocale> Search(string qstr)
        {
            List<MyLocale> mls = new List<MyLocale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={qstr}";
            
            //주어진 주소에 따라서 
            //자료들을 요청함
            WebRequest request = WebRequest.Create(query);

            string rkey = "1bc3f9ea139e4d9af613856012248107";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);


            //요청된 걸 읽어들이는 작업
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();


            //var => foreach문에서 쓰임
            //string 이나 int같은 그런 변수들에서 활용되고(foreach문)
            //임시변수? object와 매우 유사..
            //임시 객체라고 보면 됨...

            //이렇게 객체형태로 받아들이는 이유는
            //json이 객체라서... 임의의 객체 변수로 값을 받아오는 것임
            dynamic dob = js.Deserialize<dynamic>(json); //var랑 비슷한 거... 자료형

            //json객체에서 document 속성의 값들을 받아온다.
            dynamic docs = dob["documents"];

            object[] buf = docs;
            int length = buf.Length;

            //var 컴파일 시점(실행되기 전)에 타입 결정 됨
            //dynamic 런파일(본격적으로 실행될 때)에 타입 결정 됨\
            //object 모든 변수를 의미함(=객체포함) 단 원본 형식으로 사용할 땐 형변환 필요.
            //object a = new MyLocale();
            //(a as MyLocale).ToString();
            //출처 
            //https://velog.io/@hsj0511/%ED%8E%8CCType-C%EC%9D%98-%EB%8B%A4%EC%96%91%ED%95%9C-%ED%83%80%EC%9E%85type-%EC%84%A0%EC%96%B8-var-vs.-dynamic-vs.-object-

            for (int i = 0; i < length; i++)
            {
                string local_name = docs[i]["place_name"];

            }

            return mls;
        }
    }
}
