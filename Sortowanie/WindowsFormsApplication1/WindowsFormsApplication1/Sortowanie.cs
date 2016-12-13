using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    class Sortowanie
    {
        
        public void babelki(double[] tablica, ref ListBox listbox2)
        {
            double temp = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = i; j < tablica.Length; j++)
                {
                    if (tablica[j] < tablica[i])
                    {
                        temp = tablica[i];
                        tablica[i] = tablica[j];
                        tablica[j] = temp;
                        
                    }
                }
                listbox2.Items.Add(tablica[i] + "\n");
            }

        }

       

        public void SelectionSort(double[] tablica)
        {

                int smallestIndex, index, minIndex;
                double temp;
            for (index = 0; index < tablica.Length - 1; index++)
            {
                smallestIndex = index;
                for (minIndex = index; minIndex < tablica.Length; minIndex++)
                {
                    if (tablica[minIndex] < tablica[smallestIndex])
                        smallestIndex = minIndex;
                    temp = tablica[smallestIndex];
                    tablica[smallestIndex] = tablica[index];
                    tablica[index] = temp;
                }
            }

        }


        public void Quicksort(double[] tablica, int left, int right)
        {
            int i = left;
            int j = right;
            double x = tablica[(left + right) / 2];
            do
            {
                while (tablica[i] < x)
                    i++;

                while (tablica[j] > x)
                    j--;

                if (i <= j)
                {
                    double zastepcze;
                    zastepcze = tablica[i];
                    tablica[i] = tablica[j];
                    tablica[j] = zastepcze;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Quicksort(tablica, left, j);

            if (right > i) Quicksort(tablica, i, right);

        }




    }
}