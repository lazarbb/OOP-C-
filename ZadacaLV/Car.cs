using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    public class Car
    {
        double fuelLevel;
        double fuelCapacity;

        public Car(double fuelLevel, double fuelCapacity)
        {
            if (fuelLevel > fuelCapacity || fuelLevel<0 || fuelCapacity<=0) throw new CarFuelException(fuelLevel, $"A car cannot have this much fuel:{fuelLevel}");
            this.fuelLevel = fuelLevel;
            this.fuelCapacity = fuelCapacity;
        }

        public double FuelLevel
        {
            get { return fuelLevel; }
            set
            {
                if (value > fuelCapacity || value < 0) throw new CarFuelException(value, $"A car cannot have this much fuel:{value}");
                fuelLevel = value;
            }
        }
    }
}
