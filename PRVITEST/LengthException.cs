using System;
using System.Collections.Generic;
using System.Text;

namespace PRVITEST
{
    class LengthException : Exception
    {
        public int Length { get; private set; }

        public LengthException(int length, string message) : base(message)
        {
            Length = length;
        }
    }
}
