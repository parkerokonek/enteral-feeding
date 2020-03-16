using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace enteral
{
    enum FeedType {
        NG,
        NJ,
        PEG,
        J
    }

    class PatientInfo
    {
        String PatientID;
        FeedType feedingType;
        double totalVolume;
        double maxFeedRate;
        List<Tuple<DateTime,DateTime>> times;

        public PatientInfo(String id, FeedType feed, double totalVol, double maxRate) {
            this.PatientID = id;
            this.feedingType = feed;
            this.totalVolume = totalVol;
            this.maxFeedRate = maxRate;
            this.times = new List<Tuple<DateTime,DateTime>>();
        }

        // Used to add a missing time slot to the timeline, earlier time goes first
        public void addMissing(DateTime start, DateTime stop) {
            //TO DO: make sure stop happens after start
            Tuple<DateTime, DateTime> new_val = new Tuple<DateTime,DateTime>(start,stop);
            this.times.Add(new_val);
            return;

            // Later we need to make sure things aren't actually here
            for (int i = 0; i < times.Count; i++) {
                var (dStart,dStop) = times[i];
                //If this time

                // If the added time starts before and intersects a valid time, enbiggen the time
                if (DateTime.Compare(start, dStop) < 0 && DateTime.Compare(stop, dStart) > 0) {
                    // Tuples are broken somehow
                    //times[i] = (start,dStop);
                }
            }
        }

        // Trims times outside of the current time slot, timeDateReset is the earliest time to keep
        public void trimMissing(DateTime timeDateReset) {
            List<Tuple<DateTime, DateTime>> new_list = new List<Tuple<DateTime, DateTime>>();
            foreach (var time in this.times) {
                if (DateTime.Compare(time.Item1, timeDateReset) > -1)
                {
                    new_list.Add(time);
                }
                else if (DateTime.Compare(time.Item1, timeDateReset) < 0 && DateTime.Compare(time.Item2, timeDateReset) > 0) {
                    var new_time = new Tuple<DateTime, DateTime>(timeDateReset,time.Item2);
                    new_list.Add(new_time);
                }
            }

            this.times = new_list;
        }

        // The time passed in should be the time of day of reset + current time
        public PatientInfo(String fileContents, DateTime timeDateReset) {
            // Windows line endings are \r\n, but the \r doesn't matter
            string[] lines = fileContents.Replace("\r","").Split('\n');
            // 4 lines is the absolute minimum data for a patient if no miss times specified
            if (lines.Length < 4) { return;  }

            // Instantiate all the variables we will need to instantiate the patient class
            // All but the patient ID could fail in parsing, so they aren't assigned yet
            string patientID = lines[0];
            FeedType feed;
            double totalVol;
            double maxRate;

            // This will read the line and check if it has any of our valid feed types
            // The cases can be changed as needed to match any text
            // we only have a finite amount of feed types, this switch statement *just works*
            switch (lines[1]) {
                case "NG":
                    feed = FeedType.NG;
                    break;
                case "NJ":
                    feed = FeedType.NJ;
                    break;
                case "PEG":
                    feed = FeedType.PEG;
                    break;
                case "J":
                    feed = FeedType.J;
                    break;
                default:
                    return;
            }

            // Total Volume is either parsed, or we give up
            if (!double.TryParse(lines[2], out totalVol)) {
                return;
            }
            // Same with our maxrate
            if (!double.TryParse(lines[3], out maxRate)) {
                return;
            }
            // We have now *hopefully* parsed all of the information we need to create the patient info
            // So let's instantiate it
            this.PatientID = patientID;
            this.feedingType = feed;
            this.totalVolume = totalVol;
            this.maxFeedRate = maxRate;
            this.times = new List<Tuple<DateTime, DateTime>>();


            // Now we can try reading the list of stuff and toss if we have to
            // Currently we also kill the file read if any time slot is invalid
            // This is for patient safety purposes
            for (int i = 4; i < lines.Length; i++) {
                string[] timeSlots = lines[i].Split(' ');
                if (timeSlots.Length != 10) {
                    return;
                }
                // Use the spacer data to make sure that 
                if (timeSlots[0] != "Start:" || timeSlots[4] != "Stop:") {
                    return;
                }

                // Let's try to parse some stuff
                // Converting a string to an array, then collecting it back to a string isn't super effecient, but it works for now
                string start = string.Join(" ",timeSlots.Skip(1).Take(4).ToArray());
                string stop = string.Join(" ", timeSlots.Skip(5).Take(4).ToArray());
                Console.WriteLine("Start Time: {0}", start);
                Console.WriteLine("Stop Time: {0}", stop);
                DateTime dStart, dStop;
                string dateFormat = "yyyy MM dd HH";
                if (!DateTime.TryParseExact(start, dateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out dStart) || !DateTime.TryParseExact(stop, dateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out dStop)) {
                    return;
                }

                this.addMissing(dStart,dStop);

            }

            // This does leave times that are not in our window, but this gets resolved
            this.trimMissing(timeDateReset);
        }

        public String to_string() {
            string vals = "";
            string dateFormat = "yyyy MM dd HH";
            vals += this.PatientID + "\r\n";
            string feed = "";
            switch (this.feedingType) {
                case FeedType.J:
                    feed = "J";
                    break;
                case FeedType.NJ:
                    feed = "NJ";
                    break;
                case FeedType.PEG:
                    feed = "PEG";
                    break;
                case FeedType.NG:
                    feed = "NG";
                    break;
            }
            vals += feed + "\r\n";
            vals += this.totalVolume + "\r\n";
            vals += this.maxFeedRate + "\r\n";

            for (var i = 0; i < this.times.Count; i++) {
                var (start,stop) = this.times[i];
                vals += "Start: " + start.ToString(dateFormat) + " Stop: " + stop.ToString(dateFormat) + "\r\n";
            }


            return vals;
        }

        public void set_feed(FeedType feed) {
            this.feedingType = feed;
        }

        //Sets the patient's ID to a given string
        public void set_id(String id) {
            this.PatientID = id;
        }

        // Set the total daily volume
        public void set_volume(double vol) {
            this.totalVolume = vol;
        }

        // Set the maximum allowable rate
        public void set_max_rate(double maxRate) {
            this.maxFeedRate = maxRate;
        }

        //Return the entire timeline as tuples of missed times
        public List<Tuple<DateTime, DateTime>> get_timeline() {
            return this.times;
        }
    }
}
