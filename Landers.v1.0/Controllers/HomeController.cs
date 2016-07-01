using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Landers.Domain;
using Newtonsoft.Json.Linq;

namespace Landers.v1.Controllers
{
    public class HomeController : Controller
    {
        public String ReturnView(String viewNumber, String view, String client, TestManager testdata, String deviceType)
        {
            string viewType = "base";
            string partialView = String.Format("{0}{1}", viewNumber, view);

            foreach (var item in testdata.replacementList)
            {
                if (item.Find.ToLower() == view.ToLower())
                {
                    viewType = "replacements";
                    partialView = item.Replace;
                }
            }

            string returnView = String.Format("{0}/{1}/{2}", deviceType.ToLower(), viewType, partialView);

            return returnView;
        }

        public Int32 GetDevice(HttpRequest landerRequest, Boolean deviceType)
        {

            string useragent = landerRequest.UserAgent;

            if (!deviceType)
                useragent = "Mozilla/5.0 (Linux; <Android Version>; <Build Tag etc.>) AppleWebKit/<WebKit Rev>(KHTML, like Gecko) Chrome/<Chrome Rev> Safari/<WebKit Rev>";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(String.Format("https://useragentapi.com/api/v3/json/658363d1/{0}", HttpUtility.UrlEncode(useragent)));
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

            //-- Get / Read Stream from the response. ---
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream);
            String responseString = readStream.ReadToEnd();

            //-- Parse response into a Json object and get platform type. ---
            JObject responseJObject = JObject.Parse(responseString);
            readStream.Close();

            //-- Needs to be changed to make database call for device id JL 4/7/16 or does it?-----
            Int32 returnTypeId = responseJObject["data"]["platform_type"].ToString() == "mobile" ? 2 : 1;

            return returnTypeId; //responseJObject["data"]["platform_type"].ToString();

        }

        public ActionResult Index()
        {
            //--- get domain from url ---//
            string domain = Request.Url.Authority.ToLower();
            string viewType = "base";

            //-- Check for test. Moved to here till render enguine can be corrected. JL 7/25/12 ----
            String testview = "Index";

            //-- Check the device type for desktop or mobile -----
            int deviceType = GetDevice(System.Web.HttpContext.Current.Request, false); //-- for testing true (desktop), false (mobile)

            //-- Step 1 get test information based off of the url
            TestManager testData = new TestManager(System.Web.HttpContext.Current.Request, deviceType);


            if (!testData.variationsData.Base)
                viewType = "replacements";

            //ViewData["DeviceType"] = getDevice(Request);
            ViewData["DeviceType"] = "desktop";



            //-- Set default Master View (_Layout) --
            ViewData["LayoutPage"] = testData.variationsData.TemplateName;
            ViewData["Client"] = "trugreen";
            ViewData["ViewType"] = viewType;
            ViewData["ViewName"] = testData.variationsData.ViewName;
            ViewData["ViewNumber"] = testData.variationsData.ViewName.Substring(2);
            testview = testData.variationsData.ViewName;



            return View(testview.ToLower(), testData);
        }
    }
}