using System;
using System.Collections.Generic;
using System.Text;

namespace testzoric
{
    class SolarPanel
    {
        private double width;
        private double height;
        private double efficiency; // U rasponu[0. 1 −1. 0]

        public SolarPanel(double width, double height, double efficiency)
        {
            this.width = width;
            this.height = height;
            this.efficiency = efficiency;
            if (this.efficiency < 0.1) this.efficiency = 0.1;
            if (this.efficiency > 1.0) this.efficiency = 1.0;
        }

        public SolarPanel() : this(5, 5, 0.8) { }//zoric ovako zeli

        public double Width { get{return width; } }//koristiti ovaj zapis za gettere
        public double Height { get { return height; } }
        public double Efficiency {//on ima i getter i setter
            get { return efficiency; }
            set { efficiency = value; }
        }

        public virtual double CalculateYearlyProduction()
        {
            return width * height * efficiency * 1300;
        }

        public static bool operator ==(SolarPanel s1, SolarPanel s2)
        {
            return (s1.efficiency == s2.efficiency) && (s1.width == s2.width) && (s1.height == s2.height);
        }

        public static bool operator !=(SolarPanel s1, SolarPanel s2)
        {
            return !(s1 == s2);
        }
    }
}
