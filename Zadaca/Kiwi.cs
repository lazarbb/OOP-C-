using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    class Kiwi : Bird
    {
        int weightInKG;

        public Kiwi(int weightInKG, int age, int numberOfLegs, string color) : base(age,numberOfLegs,color)
        {
            this.weightInKG=weightInKG;
        }

        public int WeightInKG { get; set; }

        public override string MakeSound()
        {
            return "kiwi kiwi";
        }

        public override bool Fly()
        {
            return false;
        }
    }
}
