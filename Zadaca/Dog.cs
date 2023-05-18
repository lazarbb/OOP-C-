using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    class Dog : Mammal
    {
        int age;

        public Dog(int age, string species, int numberOfLegs, string color):base(species, numberOfLegs, color)
        {
            this.age = age;
        }

        public int Age { get; set; }

        public override string MakeSound()
        {
            return "vau vau"; 
        }
    }
}
