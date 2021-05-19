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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string type = "forgetPassword";
            string url = Program.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"email\":\"" + this.emailBox.Text + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("emailFailed"))
            {
                

                //errorMessage.Remove()
                MessageBox.Show("Wrong email! Please enter the email you typed when you registered.");
                return;
            }
            {
                Verification verification_page = new Verification();
                verification_page.email = this.emailBox.Text;
                verification_page.ShowDialog();
            }
        }
    }
}
