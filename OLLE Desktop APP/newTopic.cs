using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace OLLE_Desktop_APP
{
    public partial class newTopic : Form
    {
        public newTopic()
        {
            InitializeComponent();
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class TopicData
        {
            public string topic_id { get; set; }
            public string topic_title { get; set; }
            public string topic_detail { get; set; }
            public string topic_week { get; set; }
            public string topic_date { get; set; }
            public string post_username { get; set; }
            public string user_id { get; set; }
            public string imageUrl { get; set; }
            public string videoUrl { get; set; }
            public string fileUrl { get; set; }
            public string topic_tag { get; set; }
        }

        public class Root
        {
            public TopicData topicData { get; set; }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitTopic_Click(object sender, EventArgs e)
        {
            string title = this.titleBox.Text;
            string content = this.contentBox.Text;

            if ((title != "") && (content != ""))
            {
                string post_result = post_user_info_new(title, content);//post login data

                if (post_result.Equals("Wrong Password"))
                {
                    MessageBox.Show("Wrong username or password. Please try again.", "Post Result");
                }
                else
                {
                    MessageBox.Show("Post Success!", "Post Result");
                    this.Close();
                }
                
                

            }
            else
            {
                MessageBox.Show("Pleaswe fill the information!", "Post Result");
            }
        }

        private string post_user_info_new(string title, string content)
        {
            string type = "postNewTopic";
            string url = Program.host_url + type;//地址
            string topic_id = "";
            string topic_week = "0";
            string topic_date = DateTime.Now.ToShortDateString().ToString();//get current time
            int user_id = Program.userData.user_id;
            string post_username = Program.userData.username;
            string imageUrl = "";
            string imageUrl2 = "";
            string imageUrl3 = "";
            string videoUrl = "";
            string fileUrl = "";
            string topic_tag = "1";
            string language = "English";
            string token = Program.userData.token;

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"topic_title\":\"" + title + "\"," + 
                "\"topic_id\":\"" + topic_id + "\"," +
                "\"token\":\"" + token + "\"," +
                "\"topic_week\":\"" + topic_week + "\"," + 
                "\"topic_date\":\"" + topic_date + "\"," + 
                "\"user_id\":\"" + user_id + "\"," +
                "\"post_username\":\"" + post_username + "\"," +
                "\"imageUrl\":\"" + imageUrl + "\"," +
                "\"imageUrl2\":\"" + imageUrl2 + "\"," +
                "\"imageUrl3\":\"" + imageUrl3 + "\"," +
                "\"videoUrl\":\"" + videoUrl + "\"," +
                "\"fileUrl\":\"" + fileUrl + "\"," +
                "\"topic_tag\":\"" + topic_tag + "\"," +
                "\"language\":\"" + language + "\"," +
                "\"topic_detail\":\"" + content + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Equals("{\"error\":{\"text\":\"Bad request wrong username and password \"}}"))
            {
                return "Wrong Password";
            }
            else
            {
                Program.userData = Program.TransferJson(result);

                return result;
            }

            
     
              
            //need to workout how to transform the data into the corresponding structs 
            //see here: https://www.jb51.net/article/48027.htm


        }

        private TopicData TransferJson(string jsonMessage)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();   //实例化一个能够序列化数据的类

            Root rootClass = js.Deserialize<Root>(jsonMessage);     //将json数据转化为对象类型并赋值给list

            TopicData topicDataDetails = new TopicData();

            topicDataDetails.user_id = rootClass.topicData.user_id;


            return topicDataDetails;

        }
    }
}
