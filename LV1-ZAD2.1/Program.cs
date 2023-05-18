using System;

namespace LV1_ZAD2._1
{
    class Program
    {
        public static void RunExercise1() 
        { 
 
              TrashCan can = new TrashCan(100);
              System.Console.WriteLine(can.GetTrashCapacity());
              System.Console.WriteLine(can.GetTrashAmount());
              can.Insert(95);
              System.Console.WriteLine(can.GetTrashAmount());
             
        }
    }
}
