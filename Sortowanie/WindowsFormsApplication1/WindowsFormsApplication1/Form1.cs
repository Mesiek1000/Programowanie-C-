using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // zmienne //
        public int wielkosc_tablicy;
        public int liczby = 0;

        double[] tablica;
        // koniec zmienne //

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Sortowanie selectSor = new Sortowanie();
            //selectSor.SelectionSort(tablica);
            selectSor.Quicksort(tablica, 0, tablica.Length-1);

            for (int i = 0; i < tablica.Length; i++)
            {
                listBox2.Items.Add(tablica[i]);
            }





        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            wielkosc_tablicy = int.Parse(textBox1.Text);
            tablica = new double[wielkosc_tablicy];
            textBox1.Text = "Zatwierdziłeś " + wielkosc_tablicy;
            textBox1.Enabled = false;
            button5.Enabled = false;
            label5.Text = liczby + "/" + wielkosc_tablicy;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tablica[liczby] = Int64.Parse(textBox4.Text);
            ++liczby;
            if (wielkosc_tablicy == liczby)
            {
                textBox4.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show("Podałeś już wystarczająco dużo liczb (" + wielkosc_tablicy + ")\nJeśli chcesz wprowadzić więcej liczb należy kliknąć przycisk >>RESET<< i zadeklarować większą tablice.");
                for (int i = 0; i < tablica.Length; i++)
                {
                    listBox1.Items.Add(tablica[i] + "\n");
                }
            }
            label5.Text = liczby + "/" + wielkosc_tablicy;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox1.Enabled = true;
            button5.Enabled = true;
            textBox4.Text = String.Empty;
            textBox4.Enabled = true;
            button4.Enabled = true;
            label5.Text = "0/0";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            wielkosc_tablicy = 0;
            liczby = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Sortowanie babelki = new Sortowanie();
            babelki.babelki(tablica, ref listBox2);
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Sortowanie selectionsort = new Sortowanie();
            selectionsort.SelectionSort(tablica);
            string sorted = "";


                foreach (double item in tablica)
            {
                sorted = item.ToString();   
                listBox2.Items.Add(sorted);
            }
           // listBox2.Items.Add(sorted);


        }
    }
}
