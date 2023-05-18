using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    class Pigeon : Bird
    {
        int numberOfShitInKG;
        int weightInKG;

        public Pigeon(int numberOfShitInKG, int weightInKG, int age, int numberOfLegs, string color):base(age,numberOfLegs,color)
        {
            this.numberOfShitInKG = numberOfShitInKG;
            this.WeightInKG = weightInKG;
        }

        public int NumberOfShitInKG { get; set; }
        public int WeightInKG { get; set; }

        public override string MakeSound()
        {
            return "pi pi";
        }

        public override bool Fly()
        {
            return true;
        }
    }
}
