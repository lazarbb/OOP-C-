using System;

namespace Zadaca
{
    class Program
    {
        static void RunExercise1()
        {
            Dog floki = new Dog(10, "labrador", 4, "crna");
            Console.WriteLine(floki.MakeSound());
        }

        static void RunExercise2()
        {
            Bird[] birds = new Bird[5];
            birds[0] = new Pigeon(50, 2, 5, 2, "grey");
            birds[1] = new Kiwi(5, 10, 2, "brown");
            birds[2] = new Pigeon(32, 3, 4, 2, "white");
            birds[3] = new Kiwi(5, 7, 2, "black");
            birds[4] = new Pigeon(10, 1, 7, 2, "black");

            void CanItFly(Bird[] birds)
            {
                for(int i=0;i<5;i++)
                {
                    if (birds[i].Fly()==true)
                        birds[i].Fly();
                    else
                        Console.WriteLine("I can't fly");
                }
            }
        }

        static void Main(string[] args)
        {
            RunExercise1();
            RunExercise2();
        }
    }
}
