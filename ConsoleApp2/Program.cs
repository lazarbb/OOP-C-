using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Task()
        {
            string rijec = "ababababa";
            int counter = 0;
            for(int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] != 'a' && rijec[i] != 'b' && rijec[i] == 'c')
                    counter++;
            }

            Console.WriteLine($"{counter}");
        }

        static void Main(string[] args)
        {
            Task();
        }
    }
}
