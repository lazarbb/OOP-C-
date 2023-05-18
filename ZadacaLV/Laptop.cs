using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    class Laptop : IPortable
    {
        public Laptop(double speedCPU, int memory, int memoryRAM, int portability, string brand, double dustFactor)
        {
            SpeedCPU = speedCPU;
            Memory = memory;
            MemoryRAM = memoryRAM;
            Portability = portability;
            Brand = brand;
            DustFactor = dustFactor;
        }

        public double SpeedCPU { get; private set; }
        public int Memory { get; private set; }
        public int MemoryRAM { get; private set; }
        public int Portability { get; private set; }
        public string Brand { get; private set; }
        public double DustFactor { get; private set; }

        public Laptop() : this(4.2, 2, 16,5,"Apple", 10) { }

        public virtual double Quality()
        {
            return ((SpeedCPU + Memory + MemoryRAM) / 1000)*DustFactor;
        }

        public bool showPortability()
        {
            return true;
        }
    }
}
