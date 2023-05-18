using System;
using System.Collections.Generic;
using System.Text;

namespace PisiBrisi
{
    class Cat : Animal
    {
        string name;
        int purrVolume;

        public Cat(string name, int purrVolume, string species, int age):base(species, age)
        {
            this.name = name;
            this.purrVolume = purrVolume;
        }

        public override string MakeSound()
        {
            return "Mrnjau";
        }
    }
}
