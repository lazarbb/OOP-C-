using System;
using System.Collections.Generic;

namespace generalnaProba
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            River r = new River("Drava", generator);
            Console.WriteLine(r.Level);


            //List<TV> TVs = new List<TV>();
            ////TV t1 = new TV();
            ////TVs.Add(new TV());
            ////TV.Insert(1, new TV("sony", "aa"));    
            ////TVs[2] = new TV("Sony", "teverikson");

            //TVs.Add(new TV());
            //TVs.Add(new TV("prvi", "gdvh"));
            //TVs.Add(new TV("lolol", "hbun"));
            //TVs.Add(new TV("ewrw", "uhvu"));
            //TVs.Add(new TV("sadad", "poitro"));
            //string.userInput = Console.ReadLine();
            //Console.WriteLine(TVs[0]);
            //for (int i = 0; i < TVs.Count; i++)
            //{
            //    if (TVs[i].Brand == userInput)
            //    {
            //        TVs.RemoveAt(i);
            //    }
            //}
            //Console.WriteLine(TVs[0]);

            ////for(int i=0; i < TVs.Count;i++)
            ////{
            ////    Console.WriteLine(TVs[i]);
            ////}


            //////[t1,t2,t3,t4,t5]
            ////TVs.RemoveAt(2);
            //////[t1, t2, t4, t5]obrise se i mjesto

            ////foreach(var tv in TVs)
            ////{
            ////    Console.WriteLine(tv);//ispisuje sve iz liste
            ////}



            //Console.WriteLine(TVs[0]);

        }
    }
}