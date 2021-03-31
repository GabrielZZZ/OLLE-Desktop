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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        // 0 represents forum (open learning log)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(0, "Open Learning Log");
            forum.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CalendarPage calendarPage = new CalendarPage();
            calendarPage.ShowDialog();

        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            username.Text = Program.userData.username;
        }

        // 1 represents announcements
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(1, "Announcements");
            forum.ShowDialog();
        }

        // 2 represents troubleshoots
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(2, "Troubleshoots");
            forum.ShowDialog();
        }

        // 3 represents feedback
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(3, "Feedbacks");
            forum.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SettingPage settingPage = new SettingPage();
            settingPage.ChangeProfileImage(Program.userData.profile_photo);
            settingPage.Username = Program.userData.username;
            Program.LTooltip(settingPage.username, Program.userData.username.Length);
            settingPage.ShowDialog();
        }
    }
}
