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
    public partial class Verification : Form
    {
        public string email = "";

        public Verification()
        {
            InitializeComponent();
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            string verify_code = this.textBox1.Text;

            string type = "verifyAccount";
            string url = Program.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"valCode\":\"" + verify_code + "\"," +
                                  "\"email\":\"" + email + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Equals("{\"error\":{\"text\":\"Bad request wrong username and password \"}}"))
            {

            }
            else
            {
                // sign up successfully, the verification email has sent
                MessageBox.Show("Verification Success!");
                


            }
        }
    }
}
