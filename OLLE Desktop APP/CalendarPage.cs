using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace OLLE_Desktop_APP
{
    public partial class CalendarPage : Form
    {
        Root myDeserializedClass;

        public CalendarPage()
        {
            InitializeComponent();
        }

        private void CalendarPage_Load(object sender, EventArgs e)
        {
            loadCalendarEvents();

            // clear the panel first
            this.eventPanel.Controls.Clear();
            // get the current date
            DateTime selected_time = monthCalendar1.SelectionStart.Date;

            getCalendarEvents(selected_time);
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class FData
        {
            public string event_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string startTime { get; set; }
            public string endTime { get; set; }
        }

        public class Root
        {
            public List<FData> fData { get; set; }
        }


        private void loadCalendarEvents()
        {
            //Fetch Form Data
            string url = Program.host_url + "getCalendarEvents";

            string result = Program.PostToServer(url, "", "POST");

            JavaScriptSerializer js = new JavaScriptSerializer();

            
            myDeserializedClass = js.Deserialize<Root>(result);

            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // clear the panel first
            this.eventPanel.Controls.Clear();
            // get the current date
            DateTime selected_time = monthCalendar1.SelectionStart.Date;

            getCalendarEvents(selected_time);

        }

        private void getCalendarEvents(DateTime selected_time)
        {
            

            //create topics panel
            for (int i = 0; i < myDeserializedClass.fData.Count; i++)
            {
                //UserControl1 test = new UserControl1();
                CalendarEvent test = new CalendarEvent();
                //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);


                test.EventTitle = myDeserializedClass.fData[i].title;

                DateTime dt_start, dt_end;

                

                DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();

                dtFormat.ShortDatePattern = "yyyy/MM/dd hh:mm:ss";

                string test1 = myDeserializedClass.fData[i].startTime;



                dt_start = Convert.ToDateTime(myDeserializedClass.fData[i].startTime, dtFormat);
                //dt_start = DateTime.ParseExact(test1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                dt_end = Convert.ToDateTime(myDeserializedClass.fData[i].endTime, dtFormat);

                TimeSpan time_remaining = dt_end - dt_start;
                double total_hours = time_remaining.TotalHours;

                test.EventStartTime = dt_start.ToLongDateString() + " " + dt_start.ToShortTimeString();
                test.EventEndTime = dt_end.ToLongDateString() + " " + dt_end.ToShortTimeString();

                test.EventTime = total_hours.ToString() + " hours";

                if (dt_end > selected_time && dt_start.Date <= selected_time)
                {
                    this.eventPanel.Controls.Add(test);
                }

            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            loadCalendarEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalendarCreate createEvent = new CalendarCreate();
            createEvent.ShowDialog();
        }
    }
}
