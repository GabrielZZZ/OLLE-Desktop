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
    public partial class Topic : UserControl
    {
        public Topic()
        {
            InitializeComponent();
        }

        public string TopicTitle
        {
            get { return topic_title.Text; }
            set { topic_title.Text = value; }

        }

        public string TopicDetails
        {
            get { return topic_details.Text; }
            set { topic_details.Text = value; }

        }

        public Image AuthorImage
        {
            get { return author_image.Image; }
            set { author_image.Image = value; }

        }

    }

}
