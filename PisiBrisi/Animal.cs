using System;
using System.Collections.Generic;
using System.Text;

namespace PisiBrisi
{
    abstract class Animal
    {
        public Animal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        protected string Species { get; private set; }
        public int Age { get; private set; }


        public abstract string MakeSound();
    }
}
