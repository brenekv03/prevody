using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevody
{
    class CiselneSoustavy
    {
        public int BinToDec(string bin)
        {
            int d = bin.Length;
            int mocnina = 1;
            int desCislo = 0;
            for(int i = d-1;i>=0;i--)
            {
                if(bin[i]=='1')
                {
                    desCislo += mocnina;
                }
            }
            return desCislo;
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
            while(hex.Length>0)
            {
                if(hex[i]>='0'&&hex[i]<='9')
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
                else if(hex[i]=='A')
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
                hex =hex.Remove(hex.Length - 1);
            }
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
                else if(zbytek==10)
                {
                    hex = hex.Insert(0, 'A'.ToString());
                }
                else if (zbytek == 11)
                {
                    hex = hex.Insert(0, 'B'.ToString());
                }
                else if (zbytek == 12)
                {
                    hex = hex.Insert(0, 'C'.ToString());
                }
                else if (zbytek == 13)
                {
                    hex = hex.Insert(0, 'D'.ToString());
                }
                else if (zbytek == 14)
                {
                    hex = hex.Insert(0, 'E'.ToString());
                }
                else if (zbytek == 15)
                {
                    hex = hex.Insert(0, 'F'.ToString());
                }
                dec /= 16;
            }
            return hex;
        }
        public string BinToHex(string bin)
        {
            int delka = bin.Length;
            string hex = "";
            for(int i = delka-1;delka>=0;i--)
            {

            }
            return hex;
        }
        public string HexToBin(string hex)
        {
            int delka = hex.Length;
            string bin = "";
            return bin;
        }
    }
}
