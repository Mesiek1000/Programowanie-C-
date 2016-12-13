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
        public int wielkosc_tablicy;
        public int liczby = 0;


        double[] tablica;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MojaKlasa srednia = new MojaKlasa();
            srednia.srednia(tablica);
            label8.Text = srednia.wynik_sredniej.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox1.Enabled = true;
            button1.Enabled = true;
            textBox2.Text = String.Empty;
            textBox2.Enabled = true;
            button5.Enabled = true;
            label8.Text = "brak wyniku";
            label9.Text = "brak wyniku";
            label10.Text = "brak wyniku";
            label11.Text = "0/0";
            listBox1.Items.Clear();
            liczby = 0;
            wielkosc_tablicy = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tablica[liczby] = Int64.Parse(textBox2.Text);
            ++liczby;
            if (wielkosc_tablicy == liczby)
            {
                textBox2.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Podałeś już wystarczająco dużo liczb (" + wielkosc_tablicy +")!\nJeśli chcesz wprowadzić więcej liczb należy uruchomić program ponownie i zadeklarować większą tablice.");
                for (int i = 0; i < tablica.Length; i++)
                {
                    listBox1.Items.Add(tablica[i] + "\n");
                }
                
            }
            textBox2.Text = "";
            label11.Text = liczby + "/" + wielkosc_tablicy;






        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wielkosc_tablicy = int.Parse(textBox1.Text);
            tablica = new double[wielkosc_tablicy];
            textBox1.Text = "Zatwierdziłeś " + wielkosc_tablicy;
            textBox1.Enabled = false;
            button1.Enabled = false;
            label11.Text = liczby + "/" + wielkosc_tablicy;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MojaKlasa odchylenie = new MojaKlasa();
            odchylenie.odchylenie(tablica);
            label9.Text = odchylenie.liczba_odchylenie.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MojaKlasa rozstep = new MojaKlasa();
            rozstep.rozstep(tablica);
            label10.Text = rozstep.liczba_rozstep.ToString();
        }
    }
}
