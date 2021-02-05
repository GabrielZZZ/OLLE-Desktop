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
using System.IO;
using System.Collections;

namespace OLLE_Desktop_APP
{
    public partial class newTopic : Form
    {

        string file_names_total=""; // store all file names upload to the Database

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
                "\"files_url\":\"" + file_names_total + "\"," +
                "\"topic_detail\":\"" + content + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("{\"error\""))
            {
                MessageBox.Show("Post Error!");
                return "Post Error!";
            }
            else
            {
                //Program.userData = Program.TransferJson(result);
                //no need to transfer json
    
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

        private void uploadFile_Click(object sender, EventArgs e)
        {
            TransferUploadObjectModel m = new TransferUploadObjectModel();
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();

            // enable multi-select
            fileDialog.Multiselect = true;

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // IMPORTANT: users shall make no space among filenames and use all the English characters

                string[] srcPaths = new string[fileDialog.FileNames.Length];
                string[] fileNames = new string[fileDialog.FileNames.Length];

                for (int i = 0; i < fileDialog.FileNames.Length; i++)
                {
                    srcPaths[i] = Path.GetFullPath(fileDialog.FileNames[i]);//绝对路径
                    fileNames[i] = "test/" + Path.GetFileName(fileDialog.FileNames[i]);
                }
                
                //string srcPath = System.IO.Path.GetFullPath(fileDialog.FileName); //绝对路径
                //string file_Name = "topics/"+ System.IO.Path.GetFileName(fileDialog.FileName);
                //MessageBox.Show(file_Name);
                m.TransferBatchUploadObjects(fileNames, srcPaths);

                // handle the filenames to store them into the database
                for (int i = 0; i < srcPaths.Length; i++)
                {
                    // get the http address of each file uploaded to the bucket
                    string file_address = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/" + fileNames[i] + ";"; // ";" is used to split
                    file_names_total += file_address; 
                }

            }

        }
    }
}
