using System;

namespace PisiBrisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog zuco = new Dog(45, 4, "dzukela", 12);
            Dog floki = new Dog(41, 4, "dalmatiner", 15);
            Cat cat = new Cat("cica maca", 178, "egipatska", 198);
            Animal[] animals = new Animal[3];
            animals[0] = zuco;
            animals[1] = floki;
            animals[2] = cat;

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}
