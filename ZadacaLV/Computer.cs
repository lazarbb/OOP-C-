using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    public class Computer
    {
        public Computer(double speedCPU, int memory, int memoryRAM)
        {
            SpeedCPU = speedCPU;
            Memory = memory;
            MemoryRAM = memoryRAM;
        }
        public double SpeedCPU { get; private set; }
        public int Memory { get; private set; }
        public int MemoryRAM { get; private set; }

        public Computer() : this(4.2,2,16){}

        public virtual double Quality()
        {
            return (SpeedCPU + Memory + MemoryRAM) / 1000;
        }
      
    }
}
