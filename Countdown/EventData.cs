using System;
using System.Xml.Serialization;

namespace Countdown
{
    [Serializable]
    public class EventData
    {
        public string Name;
        public string Category;
        public DateTime Created;
        public DateTime Time;

        public static EventData Empty
        {
            get { return new EventData("", DateTime.Now, ""); }
        }

        public EventData() : this("New Event", DateTime.Now, "Events") { }

        public EventData(string name) : this(name, DateTime.Now, "Events") { }

        public EventData(string name, DateTime time) : this(name, time, "Events") { }

        public EventData(string name, DateTime time, string category)
        {
            this.Name = name;
            this.Category = category;
            this.Time = time;
            this.Created = DateTime.Now;
        }
    }
}