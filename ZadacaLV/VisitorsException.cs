using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    class VisitorsException : Exception
    {
        int numberOfVisitors;

        public VisitorsException(int numberOfVisitors,string message) : base(message)
        {
            this.numberOfVisitors = numberOfVisitors;
        }
    }
}
