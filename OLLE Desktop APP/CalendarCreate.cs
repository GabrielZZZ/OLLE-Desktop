using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class CalendarCreate : Form
    {
        public CalendarCreate()
        {
            InitializeComponent();
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void publish_button_Click(object sender, EventArgs e)
        {
            string title = title_box.Text;
            string description = description_box.Text;

            DateTime startDate = startTimePicker_date.Value;
            DateTime startDate_time = startTimePicker_time.Value;

            DateTime endDate = endTimePicker_date.Value;
            DateTime endDate_time = endTimePicker_time.Value;

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            string startTime = startDate.ToString("yyyy-MM-dd") + " " + startDate_time.ToLongTimeString();
            string endTime = endDate.ToString("yyyy-MM-dd") + " " + endDate_time.ToLongTimeString();

           
           

            string type = "storeCalendarEvent";
            string url = Program.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"title\":\"" + title + "\"," +
                                "\"startTime\":\"" + startTime + "\"," +
                                "\"endTime\":\"" + endTime + "\"," +
                                  "\"description\":\"" + description + "\"}";

            string result = Program.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Program.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Program.Reverse(errorMessage);

                //errorMessage.Remove()
                //MessageBox.Show(errorMessage);
                return;
            }
            {
                //Program.userData = Program.TransferJson(result);

                MessageBox.Show("Create Success!");

                return;
            }

        }

        
    }
}
