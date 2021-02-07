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
    public partial class TopicDetailsPage : Form
    {
        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();

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
            string[] files_url_split = files_url.Split(';');
        }

        private void topic_details1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
