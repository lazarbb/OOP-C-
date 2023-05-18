using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace generalnaProba
{
    class River
    {
        double level;
        Random generator;

        public River(string name, Random generator)
        {
            this.generator=generator;
            Level = generator.NextDouble()*50+0.1;

            using (StreamWriter writer=new StreamWriter("lazar.txt", true))
            {
                writer.WriteLine($"{name},{level}cm");
            }
        }

        public string Name { get; set; }
        public double Level { get { return level; } set { level = value; } }
    }
}
