using System;

namespace ZadacaLV
{
    class Program
    {
        static void RunExercise1()
        {
            try
            {
                Car car = new Car(80, 70);
                car.FuelLevel = -75;
            }
            catch (CarFuelException c)
            {
                Console.WriteLine(c.Message);
            }
        }

        static void RunExercise2()
        {
            Computer[] computers = new Computer[5];
            computers[0] = new Computer(3.0,1,8);
            computers[1] = new Computer();
            computers[2] = new PC(3.9,1,4,3500,10);
            computers[3] = new PC();
            computers[4] = new PC();
        }

        static void Main(string[] args)
        {
            //RunExercise1();
            RunExercise2();
        }
    }
}
