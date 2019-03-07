using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesSMSRegistration
{
    class Match
    {
        public string description = "";

        private String _R1="";
        private String _R2="";
        private String _R3="";
        private String _B1="";
        private String _B2="";
        private String _B3="";

        private DateTime originalTime = DateTime.Today;
        private int delayMinutes = 0;

        public Match()
        { }

        public Match(string description, string R1, string R2, string R3, string B1, string B2, string B3, string time)
        {
            this.description = description;
            this._R1 = R1;
            this._R2 = R2;
            this._R3 = R3;
            this._B1 = B1;
            this._B2 = B2;
            this._B3 = B3;
            this.OriginalTime = time;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string R1
        {
            get { return _R1; }
            set { _R1 = value; }
        }

        public string R2
        {
            get { return _R2; }
            set { _R2 = value; }
        }

        public string R3
        {
            get { return _R3; }
            set { _R3 = value; }
        }

        public string B1
        {
            get { return _B1; }
            set { _B1 = value; }
        }

        public string B2
        {
            get { return _B2; }
            set { _B2 = value; }
        }

        public string B3
        {
            get { return _B3; }
            set { _B3 = value; }
        }

        public DateTime OriginalTimeAsDateTime
        {
            get { return this.originalTime; }
        }

        public DateTime CorectedTimeAsDateTime
        {
            get { return this.originalTime.AddMinutes(delayMinutes); }
        }

        private static DateTimeFormatInfo HHMMFormat = new DateTimeFormatInfo();
        private static DateTimeFormatInfo WeekdayHHMMFormat = new DateTimeFormatInfo();
        static Match()
        {
            HHMMFormat.ShortTimePattern = "HH':'mm";
            WeekdayHHMMFormat.ShortTimePattern = "ddd HH':'mm";
        }

        public string OriginalTime
        {
            get { return this.originalTime.ToString("HH:mm"); }
            set
            {
                int? hourStart = null;
                int? hourLen = null;
                int? minuteStart = null;
                int? minutesLen = null;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!hourStart.HasValue && value[i] >= '0' && value[i] <= '9')
                    {
                        hourStart = i;
                    }
                    else if (hourStart.HasValue && !hourLen.HasValue && value[i] == ':')
                    {
                        hourLen = i - hourStart;
                        minuteStart = i + 1;
                    }
                    else if (minuteStart.HasValue && !minutesLen.HasValue &&
                                (value[i] < '0' || value[i] > '9'))
                    {
                        minutesLen = i - minuteStart;
                    }
                }
                if (!minutesLen.HasValue)
                    minutesLen = value.Length - minuteStart;

                int intHours = int.Parse(value.Substring(hourStart.Value, hourLen.Value));
                int intMinutes = int.Parse(value.Substring(minuteStart.Value, minutesLen.Value));

                // afternoon hours are sometimes written as 3:54 instead of 15:54
                // we assume there are no matches earlier than 08:00 AM or later than 19:59 PM, 
                // therefore any hours number <= 7 must be afternoon
                if (intHours <= 7)
                    intHours += 12;

                this.originalTime = DateTime.Today.AddHours(intHours)
                                                  .AddMinutes(intMinutes);
            }
        }

        public string MinutesDelay
        {
            get { return this.delayMinutes.ToString(); }
            set { this.delayMinutes = int.Parse(value); }
        }

        public string CorrectedTime
        {
            get { return this.originalTime.AddMinutes(delayMinutes).ToString("HH:mm"); }
        }

        private bool _autoSend = false;
        public bool AutoSend
        {
            get { return _autoSend; }
            set { _autoSend = value; }
        }

        private bool _smsSent = false;
        public bool SMSSent
        {
            get { return _smsSent; }
            set { _smsSent = value; }
        }

        public void setR1(string team)
        { this._R1 = team; }
        public void SetR2(string team)
        { this._R2 = team; }
        public void SetR3(string team)
        { this._R3 = team; }
        public void SetB1(string team)
        { this._B1 = team; }
        public void SetB2(string team)
        { this._B2 = team; }
        public void SetB3(string team)
        { this._B3 = team; }
        public void SetTime(int time)
        { this.originalTime = DateTime.Today.AddHours(time / 100).AddMinutes(time % 100); }

        public string Red1(/*int R2, int R3, int B1, int B2, int B3, int time*/)
        {
            return "Team " + _R1 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _R2 + "," + _R3 + " in RED."+" against " + _B1 + "," + _B2 + "," + _B3;
        }
        public string Red2(/*int R1, int R3, int B1, int B2, int B3, int time*/)
        {
            return "Team " + _R2 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _R1 + "," + _R3 + " in RED." + " against " + _B1 + "," + _B2 + "," + _B3;
        }
        public string Red3(/*int R1, int R2, int B1, int B2, int B3, int time*/)
        {
            return "Team " + _R3 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _R1 + "," + _R2+ " in RED." + " against " + _B1 + "," + _B2 + "," + _B3;
        }
        public string Blue1(/*int B2, int B3, int R1, int R2, int R3, int time*/)
        {
            return "Team " + _B1 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _B2 + "," + _B3 + " in BLUE." + " against " + _R1 + "," + _R2 + "," + _R3;
        }
        public string Blue2(/*int B1, int B3, int R1, int R2, int R3, int time*/)
        {
            return "Team " + _B2 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _B1 + "," + _B3 + " in BLUE." + " against " + _R1 + "," + _R2 + "," + _R3;
        }
        public string Blue3(/*int B1, int B2, int R1, int R2, int R3, int time*/)
        {
            return "Team " + _B3 + " your match " + Description + " is at " + CorrectedTime + " with teams " + _B1 + "," + _B2 + " in BLUE." + " against " + _R1 + "," + _R2 + "," + _R3;
        }
    }
}
