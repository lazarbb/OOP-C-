using System;
using System.Collections.Generic;
using System.Text;

namespace PisiBrisi
{
    class Dog : Animal
    {
        public Dog(int pawSize, int legNumber, string species, int age) : base(species, age)
        {
            PawSize = pawSize;
            LegNumber = legNumber;
        }

        public int PawSize { get; set; }
        public int LegNumber { get; set; }

        public override string MakeSound()
        {
            return "vau vau";
        }
    }
}
