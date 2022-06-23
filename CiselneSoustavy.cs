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
            int delka = bin.Length;
            string hex="";
            while (delka % 4!= 0)
            {
                bin = bin.Insert(0, "0");
                delka++;
            }
            while(delka>0)
            {
                string substr = bin.Substring(0, 4);
                bin = bin.Remove(0, 4);
                delka -= 4;
                switch(substr)
                {
                    case "0000":
                        {
                            hex = hex.Insert(hex.Length, "0");
                        }
                        break;
                    case "0001":
                        {
                            hex = hex.Insert(hex.Length, "1");
                        }break;
                    case "0010":
                        {
                            hex = hex.Insert(hex.Length, "2");
                        }
                        break;
                    case "0011":
                        {
                            hex = hex.Insert(hex.Length, "3");
                        }
                        break;
                    case "0100":
                        {
                            hex = hex.Insert(hex.Length, "4");
                        }
                        break;
                    case "0101":
                        {
                            hex = hex.Insert(hex.Length, "5");
                        }
                        break;
                    case "0110":
                        {
                            hex = hex.Insert(hex.Length, "6");
                        }
                        break;
                    case "0111":
                        {
                            hex = hex.Insert(hex.Length, "7");
                        }
                        break;
                    case "1000":
                        {
                            hex = hex.Insert(hex.Length, "8");
                        }
                        break;
                    case "1001":
                        {
                            hex = hex.Insert(hex.Length, "9");
                        }
                        break;
                    case "1010":
                        {
                            hex = hex.Insert(hex.Length, "A");
                        }
                        break;
                    case "1011":
                        {
                            hex = hex.Insert(hex.Length, "B");
                        }
                        break;
                    case "1100":
                        {
                            hex = hex.Insert(hex.Length, "C");
                        }
                        break;
                    case "1101":
                        {
                            hex = hex.Insert(hex.Length, "D");
                        }
                        break;
                    case "1110":
                        {
                            hex = hex.Insert(hex.Length, "E");
                        }
                        break;
                    case "1111":
                        {
                            hex = hex.Insert(hex.Length, "F");
                        }
                        break;
                }
            }
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
