using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class TopicDetailsPage : Form
    {
        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();
        string[] files_url_split;

        public TopicDetailsPage()
        {
            InitializeComponent();
        }

        public string TopicAuthor
        {
            get { return author_name.Text; }
            set { author_name.Text = value; }

        }

        public string TopicTitle
        {
            get { return topic_title.Text; }
            set { topic_title.Text = value; }

        }

        public string TopicDetails
        {
            get { return topic_details1.Text; }
            set { topic_details1.Text = value; }

        }

        public string TopicDate
        {
            get { return topic_date.Text; }
            set { topic_date.Text = value; }

        }

        public Image AuthorImage
        {
            get { return author_image.Image; }
            set { author_image.Image = value; }

        }

        //change pictureBox picture
        public void ChangeAuthorImage(string url)
        {
            try
            {
                author_image.Load(url);
            }
            catch (Exception ex)
            {
                //显示本地默认图片
                author_image.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        // add file panel
        public void AddFilePanel(string files_url)
        {
            

            files_url_split = files_url.Split(';');

            

            // add fileIcon control in selectFilePanel
            for (int i = 0; i < files_url_split.Length-1; i++)
            {
                FileIcon fileIcon = new FileIcon();
                string test = Path.GetExtension(files_url_split[i]);
                fileIcon.ChangeFileIconImage(Path.GetExtension(files_url_split[i]));
                fileIcon.FileName = Path.GetFileName(files_url_split[i]);
                fileIcon.Scale(new SizeF(0.5f,0.5f));
                fileLayoutPanel.Controls.Add(fileIcon);

            }

        }

        private void topic_details1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // download botton
        private void button1_Click(object sender, EventArgs e)
        {
            // open file explorer, select file path to save
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            //1、description属性，可以在对话框提供说明、描述、提醒等信息
            openFolder.Description = "Please select folder to download files";

            //2、RootFolder属性，可以设置对话框启动时的根目录,主要为C盘里的文件夹
            //下面Desktop默认打开桌面
            openFolder.RootFolder = Environment.SpecialFolder.Desktop;

            //3、ShowNewFloderButton属性，是否在对话框中设置”新建文件夹“按钮
            openFolder.ShowNewFolderButton = true;

            //4、selectedPath属性，比较重要的属性，它是获取你选择的文件夹的路径，当然
            //我们也可以记住我们每次需要打开的路径，可以避免每次都从桌面开始便利

            //开始我们在btn_click()事件外定义一个空的字符串defaultfilePath

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                //空就默认从桌面出发,然后获取点击的路径
                string path = openFolder.SelectedPath;
                TransferUploadObjectModel m = new TransferUploadObjectModel();

                // download files under this path
                for (int i = 0; i < files_url_split.Length - 1; i++)
                {
                    bool test = m.downloadFile(files_url_split[i], path);

                    if (test == false)
                    {
                        MessageBox.Show("Files download error! Please retry later or contact administrator.");
                        return;
                    }

                }

                DialogResult dr = MessageBox.Show("Files download successfully! Click OK to open download folder.");
                if (dr == DialogResult.OK)
                {
                    //点确定的代码
                    //open file folder
                    System.Diagnostics.Process.Start("explorer.exe", path);
                }
                else
                {   //点取消的代码
                    //do nothing

                }
            }

        }
        

    }
}
