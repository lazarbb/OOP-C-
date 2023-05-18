using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    class PC : Computer
    {
        double speedCPU;
        int memory;
        int memoryRAM;
        int price;
        double dustFactor;

        public PC(double speedCPU, int memory, int memoryRAM, int price, double dustFactor) : base(speedCPU,memory,memoryRAM)
        {
            this.price = price;
            this.dustFactor = dustFactor;
        }

        public PC() : this(4.2, 2, 16, 4000, 15) { }

        public override double Quality()
        {
            return ((speedCPU+memory+memoryRAM)/1000)*dustFactor;
        }
    }
}
