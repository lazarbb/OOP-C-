using System;

namespace LV1_ZAD2
{
    class Program
    {
        public static void RunExercise2()
        {
            YambChecker aYambChecker = new YambChecker();
            Random aRandomGenerator = new Random();
            Die[] dice = new Die[5];
            dice[0] = new Die(aRandomGenerator);
            dice[1] = new Die(aRandomGenerator);
            dice[2] = new Die(aRandomGenerator);
            dice[3] = new Die(aRandomGenerator);
            dice[4] = new Die(aRandomGenerator);

            foreach(Die aDie in dice)
            {
                aDie.Toss();
            }
            
            Console.WriteLine(aYambChecker.IsYamb(dice));
        }

        static void Main(string[] args)
        {
            RunExercise2();
        }
    }
}
