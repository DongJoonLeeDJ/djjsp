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


            //응답된 걸 읽어들이는 작업(카카오에서 보내온 응답을 읽는 과정)
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            //UTF8형태로 읽음(인코딩 잘못하면 한글이 깨지니까
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();


            //공통점
            //셋다 임시변수

            //var는 선언이 되면서 값이랑 타입이 바로 정해짐
            var test1 = 1; //int 타입 
            var test2 = "2"; //string 타입

            int length2= test2.Length;// 따라서 변수 선언하자마자
            //해당타입의 변수처럼 쓸 수 있음
            //인텔리센스를 호출할 수 있음(=인텔리센스 = 점 찍으면 나오는 자동완성기능)


            //프로그램이 실행이 되어야지만 그 때 타입이 결정됨
            dynamic test3 = 1;  
            dynamic test4 = "2";
            //인텔리센스 못 씀

            //var랑 유사한데...
            //선언하고나서도, 해당 타입의 인텔리센스 쓰고 싶다면
            //아래와 같이 형변환해줘야 함
            object test5 = 1;
            object test6 = "2";
            int mylength = (test6 as string).Length;
            //as를 쓰게 되면, 형변환 실패시 해당 변수를 null값으로 바꿈
            //is 키워드도 공부해두세요.
            int mylength2 = ((string)test6).Length;

            

            //이렇게 객체형태로 받아들이는 이유는
            //json이 객체라서... 임의의 객체 변수로 값을 받아오는 것임
            //js라는 string변수에 있는 json모양의 데이터를 
            //하나의 객체로 만들어서 dob에 넣은 거임...


            //var를 써도 되지만
            //dynamic을 쓰는 이유는
            //var는 오른쪽에 있는 변수가 일단은 타입이 있어야 함
            //근데 이 json에서 읽어오는 자바스크립트객체는 어떤 "타입"이 정해져 있지 않아

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

            //장소이름, 위도, 경도
            for (int i = 0; i < length; i++)
            {
                string local_name = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(local_name, y, x));
            }

            return mls;
        }
    }
}
