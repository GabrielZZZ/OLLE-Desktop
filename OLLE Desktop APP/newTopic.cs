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
        public int post_type = 0; // this variable decides what kind of uploads should perform: new main page (1) or new forum topic (0)
        string file_names_total=""; // store all file names upload to the Database
        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();
        public int topic_type;
        public int topic_tag;

        public newTopic(int type)
        {
            topic_type = type;
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
                string post_result = "";
                if (post_type == 0)
                {
                    post_result = post_user_info_new_topic(title, content);//post login data
                }
                else
                {
                    post_result = post_user_info_new_page(title, content);//post login data
                }
                


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

        private string post_user_info_new_page(string title, string content)
        {
            string type = "createPage";


            string url = Program.host_url + type;//地址
            
            int page_week = Convert.ToInt32(week_select.SelectedItem.ToString());
            string page_date = DateTime.Now.ToString("yyyy-MM-dd");//get current time
            int user_id = Program.userData.user_id;
            string post_username = Program.userData.username;
            string profile_photo = Program.userData.profile_photo;
            string imageUrl = "";
            string imageUrl2 = "";
            string imageUrl3 = "";
            string videoUrl = "";
            string fileUrl = "";
            //string topic_tag = "1";
            //string language = "English";
            string token = Program.userData.token;

            //content = contentBox.Rtf;
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(content);
            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"page_title\":\"" + title + "\"," +
                "\"token\":\"" + token + "\"," +
                "\"page_week\":\"" + page_week + "\"," +
                "\"page_date\":\"" + page_date + "\"," +
                "\"user_id\":\"" + user_id + "\"," +
                "\"post_username\":\"" + post_username + "\"," +
                "\"imageUrl\":\"" + imageUrl + "\"," +
                "\"imageUrl2\":\"" + imageUrl2 + "\"," +
                "\"imageUrl3\":\"" + imageUrl3 + "\"," +
                "\"videoUrl\":\"" + videoUrl + "\"," +
                "\"files_url\":\"" + file_names_total + "\"," +
                "\"profile_photo\":\"" + profile_photo + "\"," +
                "\"page_detail\":\"" + content + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");
            TransferUploadObjectModel m = new TransferUploadObjectModel();
            m.TransferBatchUploadObjects(file_path_total, src_path_total);


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
        }

        private string post_user_info_new_topic(string title, string content)
        {
            string type = "postNewTopic";
            
            
            string url = Program.host_url + type;//地址
            string topic_id = "";
            string topic_week = "0";
            string profile_photo = Program.userData.profile_photo;
            string topic_date = DateTime.Now.ToString("yyyy-MM-dd");//get current time
            

            int user_id = Program.userData.user_id;
            string post_username = Program.userData.username;
            string imageUrl = "";
            string imageUrl2 = "";
            string imageUrl3 = "";
            string videoUrl = "";
            string fileUrl = "";
            string topic_tag = "0"; //1 represents NAA topics; 0 represents normal topics
            string language = Program.userData.language;
            string token = Program.userData.token;

            //content = contentBox.Rtf;
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(content);
            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"topic_title\":\"" + title + "\"," + 
                "\"topic_id\":\"" + topic_id + "\"," +
                "\"token\":\"" + token + "\"," +
                "\"topic_week\":\"" + topic_week + "\"," +
                "\"topic_type\":\"" + topic_type + "\"," +
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
                "\"profile_photo\":\"" + profile_photo + "\"," +
                "\"topic_detail\":\"" + content + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");
            TransferUploadObjectModel m = new TransferUploadObjectModel();
            m.TransferBatchUploadObjects(file_path_total, src_path_total);


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
            
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();

            // enable multi-select
            fileDialog.Multiselect = true;
            fileDialog.Filter = "supported type|*.docx;*.pptx;*.pdf;*.mp4";

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

                    // add to golbal variables
                    src_path_total.Add(srcPaths[i]);
                    file_path_total.Add(fileNames[i]);
                }
                
                
                // add fileIcon control in selectFilePanel
                for (int i = 0; i < fileDialog.FileNames.Length; i++)
                {
                    FileIcon fileIcon = new FileIcon();
                    string test = Path.GetExtension(fileDialog.FileNames[i]);
                    fileIcon.ChangeFileIconImage(Path.GetExtension(fileDialog.FileNames[i]));
                    fileIcon.FileName = Path.GetFileName(fileDialog.FileNames[i]);
                    this.selectFilePanel.Controls.Add(fileIcon);

                }

                //MessageBox.Show(file_Name);
                //m.TransferBatchUploadObjects(fileNames, srcPaths);

                // handle the filenames to store them into the database
                for (int i = 0; i < srcPaths.Length; i++)
                {
                    // get the http address of each file uploaded to the bucket
                    string file_address = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/" + fileNames[i] + ";"; // ";" is used to split
                    file_names_total += file_address; 
                }

            }

        }

        private void contentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bold_Click(object sender, EventArgs e)
        {
            // make selected font bold
            ChangeFontStyle(FontStyle.Bold);

        }

        private void ChangeFontStyle(FontStyle style)
        {
            if (style != FontStyle.Bold && style != FontStyle.Italic &&
                style != FontStyle.Underline)
                throw new System.InvalidProgramException("字体格式错误");
            RichTextBox tempRichTextBox = new RichTextBox();  //将要存放被选中文本的副本  
            int curRtbStart = contentBox.SelectionStart;
            int len = contentBox.SelectionLength;
            int tempRtbStart = 0;
            Font font = contentBox.SelectionFont;
            if (len <= 1 && font != null) //与上边的那段代码类似，功能相同  
            {
                if (style == FontStyle.Bold && font.Bold ||
                    style == FontStyle.Italic && font.Italic ||
                    style == FontStyle.Underline && font.Underline)
                {
                    contentBox.SelectionFont = new Font(font, font.Style ^ style);
                }
                else if (style == FontStyle.Bold && !font.Bold ||
                         style == FontStyle.Italic && !font.Italic ||
                         style == FontStyle.Underline && !font.Underline)
                {
                    contentBox.SelectionFont = new Font(font, font.Style | style);
                }
                return;
            }
            tempRichTextBox.Rtf = contentBox.SelectedRtf;
            tempRichTextBox.Select(len - 1, 1); //选中副本中的最后一个文字  
                                                //克隆被选中的文字Font，这个tempFont主要是用来判断  
                                                //最终被选中的文字是否要加粗、去粗、斜体、去斜、下划线、去下划线  
            Font tempFont = (Font)tempRichTextBox.SelectionFont.Clone();

            //清空2和3  
            for (int i = 0; i < len; i++)
            {
                tempRichTextBox.Select(tempRtbStart + i, 1);  //每次选中一个，逐个进行加粗或去粗  
                if (style == FontStyle.Bold && tempFont.Bold ||
                    style == FontStyle.Italic && tempFont.Italic ||
                    style == FontStyle.Underline && tempFont.Underline)
                {
                    tempRichTextBox.SelectionFont =
                        new Font(tempRichTextBox.SelectionFont,
                                 tempRichTextBox.SelectionFont.Style ^ style);
                }
                else if (style == FontStyle.Bold && !tempFont.Bold ||
                         style == FontStyle.Italic && !tempFont.Italic ||
                         style == FontStyle.Underline && !tempFont.Underline)
                {
                    tempRichTextBox.SelectionFont =
                        new Font(tempRichTextBox.SelectionFont,
                                 tempRichTextBox.SelectionFont.Style | style);
                }
            }
            tempRichTextBox.Select(tempRtbStart, len);
            contentBox.SelectedRtf = tempRichTextBox.SelectedRtf; //将设置格式后的副本拷贝给原型  
            contentBox.Select(curRtbStart, len);
        }

        private void italic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }

        private void underline_button_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }

        private void NewTopic_Load(object sender, EventArgs e)
        {
            if (post_type == 0)
            {
                week_label.Visible = false;
                week_select.Visible = false;
            }
        }
    }
}
