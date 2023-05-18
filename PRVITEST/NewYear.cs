using System;
using System.Collections.Generic;
using System.Text;

namespace PRVITEST
{
    abstract class NewYear
    { 

        public NewYear(DateTime startTime, int invitedPeople, List<Music> music)
        {
            StartTime = startTime;
            InvitedPeople = invitedPeople;
            Music = music;
        }

        public DateTime StartTime { get; set; }
        public int InvitedPeople { get; set; }
        internal List<Music> Music { get; set; }

        public abstract string Celebrate();
    }
}
