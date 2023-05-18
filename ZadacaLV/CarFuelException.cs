using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    public class CarFuelException : Exception
    {
        double fuelLevel;

        public CarFuelException(double fuelLevel, string message) : base(message)
        {
            this.fuelLevel = fuelLevel;
        }
    }
}
