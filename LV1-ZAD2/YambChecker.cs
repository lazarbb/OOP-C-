using System;
using System.Collections.Generic;
using System.Text;

namespace LV1_ZAD2
{
    class YambChecker
    {
        public bool IsYamb(Die[] dice)
        {
            int sumOfResults = 0;
            Die firstDie = dice[0];
            foreach(Die aDie in dice)
            {
                    sumOfResults += aDie.GetThrowResult();
            }
            if (firstDie.GetThrowResult() * dice.Length == sumOfResults)
            {
                return true;
            }
            else return false;
        }
    }
}
