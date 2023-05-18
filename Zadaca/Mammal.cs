using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    abstract class Mammal : Animal
    {
        string species;

        protected Mammal(string species, int numberOfLegs, string color):base(numberOfLegs,color)
        {
            this.species = species;
        }

        public string Species { get; set; }
    }
}