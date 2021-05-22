using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class PageData
        {
            public string page_title { get; set; }
            public string page_id { get; set; }
            public string page_detail { get; set; }
            public string post_username { get; set; }
            public string page_date { get; set; }
            public string imageUrl { get; set; }
            public string imageUrl2 { get; set; }
            public string imageUrl3 { get; set; }
            public string user_id { get; set; }
            public string videoUrl { get; set; }
            public string fileUrl { get; set; }
            public string profile_photo { get; set; }
            public string files_url { get; set; }
            public string page_week { get; set; }
        }

        public class Root
        {
            public List<PageData> pageData { get; set; }
        }




        private void MainPage_Load(object sender, EventArgs e)
        {
            loadMainPages();
        }

        private void loadMainPages()
        {
            //Fetch Form Data
            string url = Program.host_url + "getPages";

            string result = Program.PostToServer(url, "", "GET");

            JavaScriptSerializer js = new JavaScriptSerializer();

            Root myDeserializedClass = js.Deserialize<Root>(result);


            //create topics panel
            for (int i = 0; i < myDeserializedClass.pageData.Count; i++)
            {
                //UserControl1 test = new UserControl1();
                MainPageItem test = new MainPageItem();
                test.profile_photo = myDeserializedClass.pageData[i].profile_photo;


                test.PageTitle = myDeserializedClass.pageData[i].page_title;
                test.getWeekNum = myDeserializedClass.pageData[i].page_week;
                test.pageDetails = Program.changeCharacterBack(myDeserializedClass.pageData[i].page_detail);
                test.date = myDeserializedClass.pageData[i].page_date;
                test.files_url = myDeserializedClass.pageData[i].files_url;
                this.flowLayoutPanel1.Controls.Add(test);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newTopic new_topic = new newTopic(0);
            new_topic.post_type = 1;
            new_topic.ShowDialog();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            loadMainPages();
        }
    }
}
