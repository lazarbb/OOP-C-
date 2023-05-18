using System;

namespace Test
{
    class Program
    {
        public void run()
        {
            SolarPanel smallPanel = new SolarPanel();
            SolarPanel largePanel = new SolarPanel(2, 2, 0.6);
            Console.WriteLine(smallPanel.ToString() +  ","  + largePanel.ToString());
        }   

        static void Main(string[] args)
        {
            
        }
    }
}
