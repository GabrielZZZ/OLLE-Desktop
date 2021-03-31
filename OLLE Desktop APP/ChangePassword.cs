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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password0 = this.password0.Text;
            string password = this.password1.Text;
            string password1 = this.password2.Text;

            if(password != password1)
            {
                MessageBox.Show("Please type the same passwords in two boxes!");
                return;
            }

            string type = "updatePassword";
            string url = Program.host_url + type;//地址

            string paramStr = "{\"oldPass\":\"" + password0 + "\"," +
                                "\"newPass\":\"" + password1 + "\"," +
                                  "\"user_id\":\"" + Program.userData.user_id + "\"}";



            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Program.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Program.Reverse(errorMessage);

                //errorMessage.Remove()
                MessageBox.Show(errorMessage);
                return;
            }
            else
            {
                // sign up successfully, the verification email has sent
                MessageBox.Show("Change Success!");


            }
        }
    }
}
