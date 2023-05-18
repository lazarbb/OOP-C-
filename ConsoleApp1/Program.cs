using System;

namespace ConsoleApp1
{
    class Program
    {
        static double divideTwoPositiveNumbers(double a, double b)
        {
            if (a < 0 || b < 0) throw new Exception("neko je manji od nule");
            if (b == 0) throw new DivideByZeroException("nemos dijelit s nulom idiote");
            return a / b;
        }
        //kljucne rijeci try catch finally throw
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(divideTwoPositiveNumbers(-5, 0));
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
