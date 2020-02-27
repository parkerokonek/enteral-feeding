using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<TimeSpan> times;

        public PatientInfo(String id, FeedType feed, double totalVol, double maxRate) {
            this.PatientID = id;
            this.feedingType = feed;
            this.totalVolume = totalVol;
            this.maxFeedRate = maxRate;
            this.times = new List<TimeSpan>();
        }
    }
}
