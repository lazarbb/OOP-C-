using System;
using System.Collections.Generic;
using System.Text;

namespace testzoric
{
    class FactorException : Exception
    {
        public double NewEfficiency { get; private set; }

        public FactorException(double newEfficiency, string message) : base(message)
        {
            NewEfficiency = newEfficiency;
        }
    }
}
