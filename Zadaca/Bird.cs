using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca
{
    abstract class Bird : Animal
    {
        int age;

        public Bird(int age, int numberOfLegs, string color):base(numberOfLegs,color)
        {
            this.age = age;
        }

        public int Age{ get; set; }

        public abstract bool Fly();
    }
}
