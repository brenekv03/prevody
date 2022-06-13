using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevody
{
    class CiselneSoustavy
    {
        public string BinToDec(int bin)
        {
            double celek=0;
            for(int i = 0;bin>0;i++)
            {
                int cislo = bin % 10;
                if(cislo==1)
                {
                    celek += Math.Pow(2, i);
                }
                bin /= 10;
            }
            return celek.ToString();
        }
    }
}
