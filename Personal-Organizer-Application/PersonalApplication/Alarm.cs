using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Alarm
    {
        public static List<Alarm> alarmList = new List<Alarm>();
        private string user;
        private string type;
        private string day;
        private string time;
        private string summary;
        private string description;
        public static string path = "alarm.csv";
        public Alarm(string user, string type, string day, string time, string summary, string description)
        {
            this.user = user;
            this.type = type;
            this.Day = day;
            this.Time = time;
            this.summary = summary;
            this.description = description;
        }
        public string User { get => user; set => user = value; }
        public string Type { get => type; set => type = value; }
        public string Day { get => day; set => day = value; }
        public string Time { get => time; set => time = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Description { get => description; set => description = value; }
        public string toString()
        {
            return User + "," + Type + "," + Day + "," + Time + "," + Summary + "," + Description;
        }
    }
}
