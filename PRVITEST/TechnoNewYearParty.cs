using System;
using System.Collections.Generic;
using System.Text;

namespace PRVITEST
{
    class TechnoNewYearParty : NewYear
    {
        Random generator;

        public TechnoNewYearParty(DateTime startTime, int invitedPeople, List<Music> music, Random generator) : base(startTime,invitedPeople,music)
        {
            this.generator = generator;
        }

        public override string Celebrate()
        {
            int radnomIndex = generator.Next(0, Music.Count);
            return $"Im celebrating with this song:{Music[radnomIndex].Title}";
        }
    }
}
