using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class PostReply : Form
    {
        public int topic_id;
        public PostReply()
        {
            InitializeComponent();
        }

        private void post_reply_button_Click(object sender, EventArgs e)
        {
            string user_post = this.reply_content.Text;
            string parent_id = "0";

            string type = "postNewTopicReply";
            string url = Program.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"username\":\"" + Program.userData.username + "\"," +
                                "\"language\":\"" + Program.userData.language + "\"," +
                                "\"topic_id\":\"" + topic_id + "\"," +
                                "\"user_id\":\"" + Program.userData.user_id + "\"," +
                                "\"parent_id\":\"" + parent_id + "\"," +
                                "\"profile_photo\":\"" + Program.userData.profile_photo + "\"," +
                                "\"user_post\":\"" + user_post + "\"," +
                                  "\"token\":\"" + Program.userData.token + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Program.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Program.Reverse(errorMessage);

                //errorMessage.Remove()
                MessageBox.Show(errorMessage);
                return;
            }else
            {
                MessageBox.Show("Post Success!");
                return;
            }
        }
    }
}
