using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class SolarPanel
    {
        protected double width;
        protected double height;
        protected double efficiency;

        public SolarPanel(double width, double height, double efficiency)
        {
            this.width = width;
            this.height = height;
            this.efficiency = efficiency;
        }

        public SolarPanel()
        {
            this.width = 1;
            this.height = 1;
            this.efficiency = 0.5;
        }

        public override string ToString()
        {
            return $"{width}, {height}, {efficiency}";
        }

        public virtual double CalculateAnnualEfficiency()
        {
            return width * height * efficiency * 1300;
        }
    }
}
