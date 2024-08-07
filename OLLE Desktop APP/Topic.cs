﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class Topic : UserControl
    {

        public string files_url = "";
        public int topic_id;
        public int topic_type;
        public string rtf_file_url = "";

        public Topic()
        {
            InitializeComponent();
        }

        private void author_image_Click(object sender, EventArgs e)
        {

        }

        private void topic_title_Click(object sender, EventArgs e)
        {

        }

        private void topic_details_Click(object sender, EventArgs e)
        {

        }

        public string TopicAuthor
        {
            get { return author_name1.Text; }
            set { author_name1.Text = value; }

        }

        public string TopicTitle
        {
            get { return topic_title1.Text; }
            set { topic_title1.Text = value; }

        }

        public string TopicDetails
        {
            get { return topic_details.Text; }
            set { topic_details.Text = value; }

        }

        public string TopicDate
        {
            get { return topic_date1.Text; }
            set { topic_date1.Text = value; }

        }

        public Image AuthorImage
        {
            get { return author_image1.Image; }
            set { author_image1.Image = value; }

        }
        

        //change pictureBox picture
        public void ChangeAuthorImage(string url)
        {
            try
            {
                author_image1.Load(url);
            }
            catch (Exception ex)
            {
                //显示本地默认图片
                author_image1.Load("https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/OLLE.png");
                //author_image1.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        
        private void view_details_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Ouch!");
            TopicDetailsPage Detail_page = new TopicDetailsPage();

            //pass image to TopicDetailPage
            Detail_page.AuthorImage = author_image1.Image;

            //pass author name to TopicDetailPage
            Detail_page.TopicAuthor = author_name1.Text;

            //pass topic title to TopicDetailPage
            Detail_page.TopicTitle = topic_title1.Text;

            //pass topic details to TopicDetailPage
            Detail_page.TopicDetails = Program.changeCharacterBack(topic_details.Text);

            //pass topic date to TopicDetailPage
            Detail_page.TopicDate = topic_date1.Text;

            //pass topic id
            Detail_page.topic_id = topic_id;

            //add file panel
            Detail_page.AddFilePanel(files_url);

            //pass rtf_file_name
            Detail_page.rtf_file_url = rtf_file_url;

            /**
            if (files_url != "")
            {
                Detail_page.AddFilePanel(files_url);
            }
            else
            {
                // not show file layout panel and download button if there are no files to download
                Detail_page.fileLayoutPanel.Visible = false;
                Detail_page.download_button.Visible = false;
                Detail_page.label1.Visible = false;
            }
            **/

            //show TopicDetailPage
            Detail_page.ShowDialog();
        }
    }

}
