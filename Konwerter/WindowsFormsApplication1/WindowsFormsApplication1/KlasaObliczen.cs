using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class KlasaObliczen
    {
        public string ObliczenieDecHex(int wartosc)
        {

            int reszta;
            string wynikHEX = "";

            if (wartosc == 0)
            {
                wynikHEX = "0";
            }
            while (wartosc != 0)
            {
                reszta = wartosc % 16;

                if (reszta < 10)
                    wynikHEX = wartosc % 16 + wynikHEX;
                else
                {
                    string hexa = "";
                    switch (reszta)
                    {
                        case 10:
                            hexa = ("A");
                            break;
                        case 11:
                            hexa = ("B");
                            break;
                        case 12:
                            hexa = ("C");
                            break;
                        case 13:
                            hexa = ("D");
                            break;
                        case 14:
                            hexa = ("E");
                            break;
                        case 15:
                            hexa = ("F");
                            break;

                    }
                    wynikHEX = hexa + wynikHEX;
                }
                wartosc /= 16;
            }
            return wynikHEX;
        }




        public string ObliczenieDecToBin(int wartosc)
        {
            string binary = "";
            string wynikBIN = "";

            if (wartosc == 0)
            {
                wynikBIN = "0";
            }

            while (wartosc > 0)
            {
                if (wartosc % 2 == 1)
                {
                    binary += "1";
                }
                else
                {
                    binary += "0";
                }
                wartosc = wartosc / 2;
            }
            for (int i = 0; i < binary.Length; i++)
            {
                wynikBIN += binary[binary.Length - 1 - i];
            }

            return wynikBIN;
        }


        public string ObliczenieBinToDec(string wartosc)
        {
            int wartoscDEC = 0;

            for (int i = 0; i < wartosc.Length; i++)
            {
                wartoscDEC = wartoscDEC * 2;
                if (wartosc[i] == '1')
                {
                    wartoscDEC += 1;
                }
            }
            return wartoscDEC.ToString();
        }


        public string ObliczenieHexToDec(string wartosc)
        {
            int iZwracana = 0;
            for (int i = 0; i < wartosc.Length; i++)
            {
                int iDodawana;

                switch (wartosc[i])
                {
                    case '0':
                        iDodawana = 0;
                        break;
                    case '1':
                        iDodawana = 1;
                        break;
                    case '2':
                        iDodawana = 2;
                        break;
                    case '3':
                        iDodawana = 3;
                        break;
                    case '4':
                        iDodawana = 4;
                        break;
                    case '5':
                        iDodawana = 5;
                        break;
                    case '6':
                        iDodawana = 6;
                        break;
                    case '7':
                        iDodawana = 7;
                        break;
                    case '8':
                        iDodawana = 8;
                        break;
                    case '9':
                        iDodawana = 9;
                        break;
                    case 'A':
                        iDodawana = 10;
                        break;
                    case 'B':
                        iDodawana = 11;
                        break;
                    case 'C':
                        iDodawana = 12;
                        break;
                    case 'D':
                        iDodawana = 13;
                        break;
                    case 'E':
                        iDodawana = 14;
                        break;
                    case 'F':
                        iDodawana = 15;
                        break;
                    default:
                        iDodawana = 0;
                        break;
                }

                for (int j = wartosc.Length - 1 - i; j > 0; j--)
                {
                    iDodawana = iDodawana * 16;
                }
                iZwracana += iDodawana;
            }
            string sRobocza = iZwracana.ToString(), sZwracana = "";
            for (int i = sRobocza.Length - 1; i >= 0; i--)
            {
                sZwracana += sRobocza[i];
            }

            string robocza = "";
            for (int i = sZwracana.Length - 1; i >= 0; i--)
            {
                robocza += sZwracana[i];
            }

            return robocza;
        }



        public static string CzyszczenieOkien()
        {
            return "";
        }

        public static bool CzyLiczba(string wynik)
        {
            bool odpowiedz = true;
            for (int i = 0; i < wynik.Length; i++)
            {
                switch (wynik[i])
                {
                    case '0':
                        break;
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    default:
                        odpowiedz = false;
                        break;
                }
            }
            return odpowiedz;

        }


        public static bool CzyLiczbaBin(string wynik)
        {
            bool odpowiedz = true;
            for (int i = 0; i < wynik.Length; i++)
            {
                switch (wynik[i])
                {
                    case '0':
                        break;
                    case '1':
                        break;
                    default:
                        odpowiedz = false;
                        break;
                }
            }
            return odpowiedz;

        }


        public static bool CzyLiczbaHex(string wynik)
        {
            bool odpowiedz = true;
            for (int i = 0; i < wynik.Length; i++)
            {
                switch (wynik[i])
                {
                    case '0':
                        {
                            break;
                        }
                    case '1':
                        {
                            break;
                        }
                    case '2':
                        {
                            break;
                        }
                    case '3':
                        {
                            break;
                        }
                    case '4':
                        {
                            break;
                        }
                    case '5':
                        {
                            break;
                        }
                    case '6':
                        {
                            break;
                        }
                    case '7':
                        {
                            break;
                        }
                    case '8':
                        {
                            break;
                        }
                    case '9':
                        {
                            break;
                        }
                    case 'A':
                        {
                            break;
                        }
                    case 'B':
                        {
                            break;
                        }
                    case 'C':
                        {
                            break;
                        }
                    case 'D':
                        {
                            break;
                        }
                    case 'E':
                        {
                            break;
                        }
                    case 'F':
                        {
                            break;
                        }
                    default:
                        {
                            odpowiedz = false;
                            break;
                        }
                }

            }
            return odpowiedz;



        }

    }
}