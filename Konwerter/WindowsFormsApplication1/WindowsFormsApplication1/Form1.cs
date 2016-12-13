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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KlasaObliczen PrzyciskPierwszy = new KlasaObliczen();
            if (KlasaObliczen.CzyLiczba(textBox1.Text))
            {
               textBox3.Text = PrzyciskPierwszy.ObliczenieDecHex(int.Parse(textBox1.Text));
                textBox2.Text = PrzyciskPierwszy.ObliczenieDecToBin(int.Parse(textBox1.Text));
            }
            else
            {
                textBox3.Text = "Błąd";
                textBox2.Text = "Błąd";
            }
            
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KlasaObliczen PrzyciskDrugi = new KlasaObliczen();
            if (KlasaObliczen.CzyLiczbaBin(textBox2.Text))
            {
            textBox1.Text = PrzyciskDrugi.ObliczenieBinToDec(textBox2.Text);
            textBox3.Text = PrzyciskDrugi.ObliczenieDecHex(int.Parse(textBox1.Text));
            }
            else
            {
                textBox3.Text = "Błąd";
                textBox1.Text = "Błąd";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*KlasaObliczen Czyszczenie = new KlasaObliczen();
            textBox1.Text = Czyszczenie.CzyszczenieOkien();
            textBox2.Text = Czyszczenie.CzyszczenieOkien();
            textBox3.Text = Czyszczenie.CzyszczenieOkien();*/

            textBox1.Text = KlasaObliczen.CzyszczenieOkien(); // nie musze tworzyc obiektu 
            textBox2.Text = KlasaObliczen.CzyszczenieOkien();
            textBox3.Text = KlasaObliczen.CzyszczenieOkien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KlasaObliczen PrzyciskTrzeci = new KlasaObliczen();
            if (KlasaObliczen.CzyLiczbaHex(textBox3.Text))
            {
            textBox1.Text = PrzyciskTrzeci.ObliczenieHexToDec(textBox3.Text);
            textBox2.Text = PrzyciskTrzeci.ObliczenieDecToBin(int.Parse(textBox1.Text));
            }
            else
            {
                textBox2.Text = "Błąd";
                textBox1.Text = "Błąd";
            }
        }
    }
}
