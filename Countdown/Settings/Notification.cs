using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown.Settings
{
    [Serializable]
    public class Notification
    {
        private string title = "%n has occurred.";
        private string[] body = { "Event name: %n", "Event category: %c", "Event date: %ds", "Event time: %ts" };
        private NotificationMethod method = NotificationMethod.Conditional;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string[] Body
        {
            get { return body; }
            set { body = value; }
        }

        public NotificationMethod Method
        {
            get { return method; }
            set { method = value; }
        }
    }
}