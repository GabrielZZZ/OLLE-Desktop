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
    public partial class FileIcon : UserControl
    {
        public FileIcon()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return fileName.Text; }
            set { fileName.Text = value; }

        }

        public Image FileIconImage
        {
            get { return fileImage.Image; }
            set { fileImage.Image = value; }

        }

        public void ChangeFileIconImage(string fileType)
        {
            try
            {
                switch (fileType)
                {
                    case ".docx":
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.word;
                        break;
                    case ".xlsx":
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.excel;
                        break;
                    case ".pdf":
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.pdf;
                        break;
                    case ".mp4":
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.video;
                        break;
                    case ".pptx":
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.PPT;
                        break;
                    default:
                        fileImage.Image = global::OLLE_Desktop_APP.Properties.Resources.file;
                        break;
                    
                }

            }
            catch (Exception ex)
            {
                //显示本地默认图片
                fileImage.Load("https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/OLLE.png");
                //author_image1.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        private void FileIcon_Load(object sender, EventArgs e)
        {
            Program.LTooltip(fileName, 10);
        }

        private void FileName_Click(object sender, EventArgs e)
        {

        }
    }
}
