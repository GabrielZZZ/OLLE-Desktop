using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace OLLE_Desktop_APP
{
    public partial class Login : Form
    {
        //public string host_url = "https://www.olle-nottingham.xyz/theAppDB/api/";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            //just for developing!!!!//////////////////
            //username = "admin";
           // password = "admin123";
            ///////////////////////////////////////////


            if ((username != "") && (password != ""))
            {
                string login_result = login_user_info_new(username, password);//post login data

                if (login_result.Equals("Wrong Password"))
                {
                    MessageBox.Show("Wrong username or password. Please try again.", "Login Result");
                }else
                {
                    this.Hide();
                    //Forum forum = new Forum();
                    //forum.ShowDialog();

                    MenuPage menuPage = new MenuPage();
                    menuPage.ShowDialog();

                    //forum.Show();
                    this.Close();
                }
                

                
            }
            else
            {
                MessageBox.Show("Pleaswe fill the information!", "Login Result");
            }
            
        }

        //string data = JsonSerializer.Serialize(user);
        //var response = webClient.UploadString(post_type, data);
       // var result = JsonSerializer.Deserialize<object>(response);

        private string login_user_info_new(string username, string password)
        {
            string type = "login";
            string url = Program.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"username\":\""+ username + "\"," +
                                  "\"password\":\""+ password+ "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Program.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Program.Reverse(errorMessage);

                //errorMessage.Remove()
                //MessageBox.Show(errorMessage);
                return "Wrong Password";
            }
            {
                Program.userData = Program.TransferJson(result);

                return result;
            }

            

            //need to workout how to transform the data into the corresponding structs 
            //see here: https://www.jb51.net/article/48027.htm


        }

        private void Login_Load(object sender, EventArgs e)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string name = "OLLE";
            foreach (string d in Directory.GetFileSystemEntries(dirPath))
            {
                if (File.Exists(dirPath + @"\" + name))
                {
                    MessageBox.Show("创建文件夹 " + name + " 失败,文件夹已经存在");
                    
                }
            }//end of for
            DirectoryInfo info = new DirectoryInfo(dirPath);
            info.CreateSubdirectory(name);
            //info.Parent.CreateSubdirectory(name);//可以在父目录生成文件夹，很方便

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPasswordPage = new ForgetPassword();
            forgetPasswordPage.ShowDialog();
        }

        /**
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
    **/

    }

}
