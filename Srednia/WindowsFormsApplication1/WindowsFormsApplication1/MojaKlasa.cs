using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    class MojaKlasa
    {
        public double wynik = 0;
        public double wynik_sredniej;
        public double liczba_odchylenie, liczba_rozstep;
        public double min, max;

        public string srednia(double[] tablica)
        {
            for (int i = 0; i <tablica.Length; i++)
            {
                wynik = wynik + tablica[i];
            }
            wynik_sredniej = wynik / tablica.Length;

            return wynik_sredniej.ToString();
        }

        public void odchylenie (double[] tablica)
        {
            double odchylenie;
            for(int i =0; i < tablica.Length; i++)
            {
                wynik = wynik + tablica[i];
            }
            odchylenie = wynik / tablica.Length;
            for (int i = 0; i < tablica.Length; i++)
            {
                liczba_odchylenie = liczba_odchylenie + Math.Pow(tablica[i] - odchylenie, 2);
            }
            liczba_odchylenie = liczba_odchylenie / tablica.Length;
            liczba_odchylenie = Math.Sqrt(liczba_odchylenie);
        }

        public void rozstep (double[] tablica)
        {
            min = tablica[0];
            max = tablica[0];

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }

                if (tablica[i] < min)
                {
                    min = tablica[i];
                }
            }
            liczba_rozstep = max - min;
        }
    }
}
