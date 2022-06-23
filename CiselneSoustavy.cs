using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevody
{
    class CiselneSoustavy
    {
        public string BinToDec(int binCis)
        {
            double vysledek = 0;
            for (int i = 0; binCis > 0; i++)
            {
                int cislo = binCis % 10;
                if (cislo == 1)
                {
                    vysledek += Math.Pow(2, i);
                }
                binCis /= 10;
            }
            return vysledek.ToString();
        }

        public string DecToBin(int dec)
        {
            string retezec = "";
            int j = 0;
            while(dec>0)
            {
                if (dec % 2 == 1) retezec = retezec.Insert(0, '1'.ToString());
                else retezec = retezec.Insert(0, '0'.ToString());
                dec /= 2;
                j++;
            }
            return retezec;
        }
        public int HexToDec(string hex)
        {
            int i = hex.Length - 1;
            int mocnina = 0;
            int Dec = 0;
            while (hex.Length > 0)
            {
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    int cislo = int.Parse(hex[i].ToString());
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'A')
                {
                    int cislo = 10;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'B')
                {
                    int cislo = 11;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'C')
                {
                    int cislo = 12;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'D')
                {
                    int cislo = 13;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'E')
                {
                    int cislo = 14;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                else if (hex[i] == 'F')
                {
                    int cislo = 15;
                    int moc = 1;
                    for (int j = mocnina; j > 0; j--)
                    {
                        moc *= 16;
                    }
                    moc *= cislo;
                    Dec += moc;
                }
                i--;
                mocnina++;
                hex = hex.Remove(hex.Length - 1);
            }


            /*if(hexcislo[i]<=9)
            cifra = hexcislo[i]-'0'
            //else
            {
                cifra = hexCislo[i] - 'a' + 10;
            }

            i--;
            mocnina++;
            hex =hex.Remove(hex.Length - 1);*/

            return Dec;
        }
        public string DecToHex(int dec)
        {
            string hex = "";
            int zbytek = 0;
            while(dec>0)
            {
                zbytek = dec % 16;
                if(zbytek>=0&&zbytek<=9)
                {
                   hex= hex.Insert(0, zbytek.ToString());
                }
                else
                {
                    char znakCifry = (char)('A' + zbytek - 10);
                    hex= hex.Insert(0, znakCifry.ToString());

                }

                dec /= 16;
            }
            return hex;
        }
        public string BinToHex(string bin)
        {
            //1248
            string dec = BinToDec(int.Parse(bin));
            string hex = DecToHex(int.Parse(dec));
            return hex;
        }
        public string HexToBin(string hex)
        {
            string dec = HexToDec(hex).ToString();
            string bin = DecToBin(int.Parse(dec));
            return bin;
        }
    }
}
