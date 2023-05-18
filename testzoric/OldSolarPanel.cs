using System;
using System.Collections.Generic;
using System.Text;

namespace testzoric
{
    class OldSolarPanel : SolarPanel
    {
        private double ageFactor;
        private double age;

        public OldSolarPanel(double ageFactor, double age, double width, double height, double effciency):base(width,height,effciency)
        {
            this.ageFactor = ageFactor;
            this.age = age;
            if (this.ageFactor < 0.0) this.ageFactor = 0.0;//radimo po logici iz 1. zadatka
            if (this.ageFactor > 0.1) this.ageFactor = 0.1;
        }

        public void IncrementAge()
        {
            age++;
        }

        public override double CalculateYearlyProduction()
        {
            double currentEfficiency = Efficiency - (age * ageFactor);
            if (currentEfficiency < 0.02) throw new FactorException(currentEfficiency, $"The panel is too old.");
            return Width * Height * currentEfficiency * 1300;
        }
    }
}
