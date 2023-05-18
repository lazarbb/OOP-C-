using System;

namespace testzoric
{
    class Program
    {
        public static void RunDemo()
        {
            SolarPanel smallPanel = new SolarPanel();
            SolarPanel largePanel = new SolarPanel(2, 2, 0.7);
            smallPanel.Efficiency = 0.9;//svojstvo prepoznajem po velikom slovu i tome sto nema zagrada, svojstvo ima i seter jer mu mjenjamo vrijednost:=0.9
            Console.WriteLine($"Panel size: {smallPanel.Width} {smallPanel.Height}");
            try
            {
                Console.WriteLine();
            }
            catch
            {

            }
        }

        static void Main(string[] args)
        {
            RunDemo();
        }
    }
}
