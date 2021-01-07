﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ForumTopics;

namespace OLLE_Desktop_APP
{
    public partial class Forum : Form
    {
        public Forum()
        {
            InitializeComponent();
            //MessageBox.Show("Wrong username or password. Please try again.", "Login Result");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Forum_Load(object sender, EventArgs e)
        {
            //add list view items
           

            //lv_person.Items.Add(lv1);
 

            //Fetch Form Data
            string url = Program.host_url + "getTopics";

            string result = Program.PostToServer(url,"","GET");

            //MessageBox.Show(result, "Result");

            //transfer json data to object
            //Very Useful Website!!!: https://json2csharp.com/
            JavaScriptSerializer js = new JavaScriptSerializer();

            Root myDeserializedClass = js.Deserialize<Root>(result);

            
            //create topics panel
            for (int i = 0; i < myDeserializedClass.TopicsData.Count; i++)
            {
                //UserControl1 test = new UserControl1();
                Topic test = new Topic();
                //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);
                test.ChangeAuthorImage(myDeserializedClass.TopicsData[i].imageUrl);
                test.TopicAuthor = myDeserializedClass.TopicsData[i].post_username;
                test.TopicTitle = myDeserializedClass.TopicsData[i].topic_title;
                test.TopicDetails = myDeserializedClass.TopicsData[i].topic_detail;
                test.TopicDate = myDeserializedClass.TopicsData[i].topic_date;

                this.flowLayoutPanel1.Controls.Add(test);
            }

        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        

        public class Root
        {
            public List<TopicsData> TopicsData { get; set; }
        }


        
        public class TopicsData
        {
            //store the information that the server returns after successful login

            public int topic_id { get; set; }
            public string topic_title { get; set; }
            public string topic_detail { get; set; }
            public int topic_week { get; set; }
            public string topic_date { get; set; }
            public string post_username { get; set; }
            public int user_id { get; set; }
            public string imageUrl { get; set; }
            public string videoUrl { get; set; }
            public string fileUrl { get; set; }
            public int topic_tag { get; set; }



        };

        /**
        public class WrapperTopicClass
        {
            public TopicsData userData { get; set; }
        }

        public static TopicsData TransferJson(string jsonMessage)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();   //实例化一个能够序列化数据的类

            WrapperTopicClass wrapperclass = js.Deserialize<WrapperTopicClass>(jsonMessage);    //将json数据转化为对象类型并赋值给list

            TopicsData topicsDataDetails = new TopicsData();

            topicsDataDetails.topic_id = wrapperclass.userData.topic_id;
            topicsDataDetails.topic_title = wrapperclass.userData.topic_title;
            topicsDataDetails.topic_detail = wrapperclass.userData.topic_detail;
            topicsDataDetails.topic_week = wrapperclass.userData.topic_week;
            topicsDataDetails.topic_date = wrapperclass.userData.topic_date;
            topicsDataDetails.post_username = wrapperclass.userData.post_username;
            topicsDataDetails.user_id = wrapperclass.userData.user_id;
            topicsDataDetails.imageUrl = wrapperclass.userData.imageUrl;
            topicsDataDetails.videoUrl = wrapperclass.userData.videoUrl;
            topicsDataDetails.fileUrl = wrapperclass.userData.fileUrl;
            topicsDataDetails.topic_tag = wrapperclass.userData.topic_tag;



            return topicsDataDetails;

        }


       **/

    }
}
