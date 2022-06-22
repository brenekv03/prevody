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
                //if(hexcislo[i]<=9)
                cifra = hexcislo[i]-'0'
                //else
                {
                    cifra = hexCislo[i] - 'a' + 10;
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
            int delka = bin.Length;
            string hex = "";
            for(int i = delka-1;delka>0;i--)
            {
                string sub = bin.Substring(i - 3);
                int cifra = 0;
                if (sub[0] == '1') cifra += 8;
                if (sub[1] == '1') cifra += 4;
                if (sub[2] == '1') cifra += 2;
                if (sub[3] == '1') cifra += 1;
                if (cifra >= 0 && cifra <= 9)
                {
                    hex = hex.Insert(0, cifra.ToString());
                }
                else if (cifra == 10)
                {
                    hex = hex.Insert(0, 'A'.ToString());
                }
                else if (cifra == 11)
                {
                    hex = hex.Insert(0, 'B'.ToString());
                }
                else if (cifra == 12)
                {
                    hex = hex.Insert(0, 'C'.ToString());
                }
                else if (cifra == 13)
                {
                    hex = hex.Insert(0, 'D'.ToString());
                }
                else if (cifra == 14)
                {
                    hex = hex.Insert(0, 'E'.ToString());
                }
                else if (cifra == 15)
                {
                    hex = hex.Insert(0, 'F'.ToString());
                }
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
