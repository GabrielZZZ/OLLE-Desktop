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
            Detail_page.AuthorImage = global::OLLE_Desktop_APP.Properties.Resources.excel;

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

            //show TopicDetailPage
            Detail_page.ShowDialog();
        }
    }
}
