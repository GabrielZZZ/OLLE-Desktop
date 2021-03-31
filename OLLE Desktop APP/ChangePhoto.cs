using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class ChangePhoto : Form
    {
        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();
        string profile_photo = "";

        public ChangePhoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //初始化一个OpenFileDialog类
            OpenFileDialog fileDialog = new OpenFileDialog();
            // enable multi-select
            fileDialog.Multiselect = true;
            fileDialog.Filter = "supported type|*.png;*.jpg";

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // IMPORTANT: users shall make no space among filenames and use all the English characters

                string[] srcPaths = new string[fileDialog.FileNames.Length];
                string[] fileNames = new string[fileDialog.FileNames.Length];

                for (int i = 0; i < fileDialog.FileNames.Length; i++)
                {
                    srcPaths[i] = Path.GetFullPath(fileDialog.FileNames[i]);//绝对路径
                    fileNames[i] = "profile/" + Path.GetFileName(fileDialog.FileNames[i]);

                    // add to golbal variables
                    src_path_total.Add(srcPaths[i]);
                    file_path_total.Add(fileNames[i]);
                }


                // add fileIcon control in selectFilePanel
                for (int i = 0; i < fileDialog.FileNames.Length; i++)
                {

                    profile_photo_box.ImageLocation = srcPaths[i];

                }

                //MessageBox.Show(file_Name);
                //m.TransferBatchUploadObjects(fileNames, srcPaths);

                // handle the filenames to store them into the database
                for (int i = 0; i < srcPaths.Length; i++)
                {
                    // get the http address of each file uploaded to the bucket
                    profile_photo = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/" + fileNames[i] + ";"; // ";" is used to split

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string type = "updatePhoto";
            string url = Program.host_url + type;//地址

            string paramStr = "{\"photo\":\"" + profile_photo + "\"," +
                                  "\"user_id\":\"" + Program.userData.user_id + "\"}";



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
            }
            else
            {
                // sign up successfully, the verification email has sent
                MessageBox.Show("Change Success!");
                Program.userData.profile_photo = profile_photo;


            }
        }
    }
}
