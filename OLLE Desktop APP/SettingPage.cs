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
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return username.Text; }
            set { username.Text = value; }

        }

        public Image Profile_photo
        {
            get { return profile_photo.Image; }
            set { profile_photo.Image = value; }

        }

        //change pictureBox picture
        public void ChangeProfileImage(string url)
        {
            try
            {
                profile_photo.Load(url);
            }
            catch (Exception ex)
            {
                //显示本地默认图片
                profile_photo.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePhoto changePhoto = new ChangePhoto();
            changePhoto.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
