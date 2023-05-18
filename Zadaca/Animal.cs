using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    abstract class Animal
    {
        int numberOfLegs;
        string color;

        protected Animal(int numberOfLegs, string color)
        {
            this.numberOfLegs = numberOfLegs;
            this.color = color;
        }

        public int NumberOfLegs { get; set; }
        public string Color { get; set; }

        public abstract string MakeSound();
    }
}
