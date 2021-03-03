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
    public partial class CalendarEvent : UserControl
    {
        public CalendarEvent()
        {
            InitializeComponent();
        }

        public string EventTitle
        {
            get { return event_name.Text; }
            set { event_name.Text = value; }

        }

        public string EventTime
        {
            get { return remaining_time.Text; }
            set { remaining_time.Text = value; }

        }

        public string EventStartTime
        {
            get { return start_time.Text; }
            set { start_time.Text = value; }

        }

        public string EventEndTime
        {
            get { return end_time.Text; }
            set { end_time.Text = value; }

        }

    }
}
