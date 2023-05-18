using System;
using System.Collections.Generic;
using System.Text;

namespace ZadacaLV
{
    interface IAdmin
    {
        public void RemoveSponsors(List<string> list)
        {
            list.RemoveAt(0);
        }

        public string FindSponsor(List<string> list)
        {
            
        }
    }
}
