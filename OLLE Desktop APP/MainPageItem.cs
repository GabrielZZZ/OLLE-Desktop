using System;
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
    public partial class MainPageItem : UserControl
    {

        public string files_url = "";

        public string pageDetails = "";
        public string date = "";

        public string profile_photo = "";

        public MainPageItem()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get { return mainPageTitle.Text; }
            set { mainPageTitle.Text = value; }
        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ouch!");
            TopicDetailsPage Detail_page = new TopicDetailsPage();

            //pass image to TopicDetailPage
            Detail_page.ChangeAuthorImage(profile_photo);

            //pass author name to TopicDetailPage
            Detail_page.TopicAuthor = "Admin";

            //pass topic title to TopicDetailPage
            Detail_page.TopicTitle = mainPageTitle.Text;

            //pass topic details to TopicDetailPage
            Detail_page.TopicDetails = pageDetails;

            //pass topic date to TopicDetailPage
            Detail_page.TopicDate = date;

            //add file panel
            Detail_page.AddFilePanel(files_url);

            /**
            if (files_url != "")
            {
                Detail_page.AddFilePanel(files_url);
            } else
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
