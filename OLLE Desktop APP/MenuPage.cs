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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum();
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
    }
}
