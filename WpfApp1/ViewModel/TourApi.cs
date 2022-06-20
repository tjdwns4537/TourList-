using System;
using System.Net.Http;
using System.Threading.Tasks;
using TourApp.Classes;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace TourApp.ViewModel
{
    public class TourApi
    {

        
        public const string API_KEY = "iwvxroj7TqxXVWZ1VwGl%2BGQOiDq589vMXzQHiESJ6FpXpq%2FHDOl6x9jndCdszAzIU%2FlefJ3yZ21MMU582N5NKQ%3D%3D";

        //public const string baseurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey={0}&contentTypeId={1}&areaCode={2}&sigunguCode={3}&MobileOS=ETC&MobileApp=TestApp&arrange=A&numOfRows=12&pageNo=1&_type=json";
        public const string baseurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey={0}&contentTypeId=12&areaCode={1}&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TestApp&arrange=A&numOfRows=30&pageNo=1";

        /*
        
        public static TourData GetTourData(string area)
        {
            TourData result = new TourData();
            string url= url = string.Format(baseurl, API_KEY, 1);

            if (area == "부산") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "서울") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "울산") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "경기도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "강원도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "경상남도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "경상북도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "인천") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "광주") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "대전") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "대구") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "세종특별자치시") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "충청남도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "충청북도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "전라남도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "전라북도") { url = string.Format(baseurl, API_KEY, 6); }
            if (area == "제주도") { url = string.Format(baseurl, API_KEY, 6); }

            HttpClient client = new HttpClient();

            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;
            client.Dispose();

            result = JsonConvert.DeserializeObject<TourData>(resultString);


            return result;
        }
        
        */
        public string GetTourData_xml(int area)
        {
            //TourData result = new TourData();
            string url = string.Format(baseurl, API_KEY, 6);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;

            client.Dispose();

            return url;
        }

        


        /*
        //public const string baseurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey={0}&contentTypeId={1}&areaCode={2}&sigunguCode={3}&cat1={4}&cat2={5}&cat3={6}&listYN=Y&MobileOS=ETC&MobileApp=TestApp&arrange=A&numOfRows=12&pageNo=1&_type=json";
        //public const string BASEURL = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey=" + API_KEY + "&numOfRows=10&pageNo=1&MobileOS=ETC&MobileApp=TestApp&_type=json";
        //public const string baseurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey={0}&contentTypeId={1}&areaCode={2}&sigunguCode={3}&MobileOS=ETC&MobileApp=TestApp&arrange=A&numOfRows=12&pageNo=1&_type=json";
        //public const string baseurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey={0}&contentTypeId={1}&areaCode={2}&sigunguCode=&cat1=&cat2=&cat3=&MobileOS=ETC&MobileApp=TestApp&arrange=A&numOfRows=12&pageNo=1";
        */
        /*public TourData GetTourData(int contentTypeId,int areaCode, int sigunguCode, string cat1, string cat2, string cat3)
        public TourData GetTourData(int contentTypeId,int areaCode, int sigunguCode)
        {
            TourData result = new TourData();
            string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode);
            //string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode, cat1, cat2, cat3);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;

            client.Dispose();
            
            return result;
        }

        public string GetTourStringData(int contentTypeId, int areaCode, int sigunguCode)
        {
            TourData result = new TourData();
            //string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode);
            string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode);
            //string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode, cat1, cat2, cat3);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;

            client.Dispose();

            return resultString;
        }

        public string GetTourURLData(int contentTypeId, int areaCode, int sigunguCode)
        {
            TourData result = new TourData();
            string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode);
            //string url = string.Format(baseurl, API_KEY, contentTypeId, areaCode, sigunguCode, cat1, cat2, cat3);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;

            client.Dispose();

            return url;
        }
        */

    }
}
