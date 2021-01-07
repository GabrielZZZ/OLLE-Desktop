﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    static class Program
    {
        //global variables
        public static string host_url = "https://www.olle-nottingham.xyz/theAppDB/api/";

        public class UserData
        {
            //store the information that the server returns after successful login

            public int user_id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string username { get; set; }
            public string language { get; set; }
            public string user_account_status { get; set; }
            public string profile_photo { get; set; }
            public string token { get; set; }

        };

        public class WrapperClass
        {
            public UserData userData { get; set; }
        }

        public static UserData TransferJson(string jsonMessage)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();   //实例化一个能够序列化数据的类

            WrapperClass wrapperclass = js.Deserialize<WrapperClass>(jsonMessage);    //将json数据转化为对象类型并赋值给list

            UserData userDataDetails = new UserData();

            userDataDetails.user_id = wrapperclass.userData.user_id;
            userDataDetails.name = wrapperclass.userData.name;
            userDataDetails.surname = wrapperclass.userData.surname;
            userDataDetails.email = wrapperclass.userData.email;
            userDataDetails.username = wrapperclass.userData.username;
            userDataDetails.language = wrapperclass.userData.language;
            userDataDetails.profile_photo = wrapperclass.userData.profile_photo;
            userDataDetails.token = wrapperclass.userData.token;


            return userDataDetails;

        }

        public static string PostToServer(string url, string paramStr, string Method)//method for posting data to server
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

          

            req.Method = Method;

            req.Timeout = 800;//设置请求超时时间，单位为毫秒

            req.ContentType = "application/json";

            byte[] data = Encoding.UTF8.GetBytes(paramStr);

            req.ContentLength = data.Length;

            if (Method.Equals("POST"))
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);

                    reqStream.Close();
                }
            }

            

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Stream stream = resp.GetResponseStream();


            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string result = reader.ReadToEnd();
                return result;
            }

            
        }

        public static UserData userData;//global user data

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Forum());

        }
    }
}