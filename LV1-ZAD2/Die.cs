using System;
using System.Collections.Generic;
using System.Text;

namespace LV1_ZAD2
{
    class Die
    {
        int throwResult;
        Random randomGenerator;

        public Die(Random randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        public int GetThrowResult()
        {
            return throwResult;
        }

        public void SetThrowResult(int throwResult)
        {
            this.throwResult = throwResult;
        }

        public void Toss()
        {
            throwResult = randomGenerator.Next(1, 7);
        }
    }
}
