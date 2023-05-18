using System;
using System.Collections.Generic;
using System.Text;

namespace testzoric
{
    class Utilities
    {
        public static bool AreUnique(SolarPanel[] panels)
        {
            int br = 0;
            for(int i = 0; i < panels.Length; i++)
            {
                for(int j = i + 1; j < panels.Length; j++)
                {
                    if (panels[i] == panels[j])
                        br++;
                }
            }
            if (br > 0) return false;
            return true;
        }
    }
}
