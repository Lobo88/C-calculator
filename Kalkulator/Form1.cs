using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private Boolean sprawdz = false;
        Boolean czystyEkran = false;
        String pierwszaLiczba ;
        String drugaLiczba ;
        char znakDzialania ='#';
        double procentWynik = 0;
        String wyswietl;
        double sumaDzialania = 0;

        public Form1()
        {
            InitializeComponent();
            wyswietl = pierwszaLiczba;

        }

     

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void kropka_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            if (sprawdz == false)
            {
                pierwszaLiczba += ",";
            }
            else { drugaLiczba += ","; }
        }
        private void wynik_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Double wynik = 0;
            textBox2.Text += textBox1.Text;
            textBox3.Text += textBox1.Text;
            switch (znakDzialania)
            {
               
                case ('+'):
                    wynik = double.Parse(pierwszaLiczba) + double.Parse(drugaLiczba);
                    String pokazWynik = Convert.ToString(wynik);
                    textBox1.Text = pokazWynik;
                    sprawdz = false;
                    czystyEkran = true;
                    

                    break;
                case ('-'):
                     wynik = int.Parse(pierwszaLiczba) - int.Parse(drugaLiczba);
                    pokazWynik = Convert.ToString(wynik);
                    textBox1.Text = pokazWynik; sprawdz = false;
                  
                    break;
                case ('*'):
                    wynik = int.Parse(pierwszaLiczba) * int.Parse(drugaLiczba);
                    pokazWynik = Convert.ToString(wynik);
                    textBox1.Text = pokazWynik; sprawdz = false;
                    czystyEkran = true;
                    break;
                case ('/'):
                    wynik = int.Parse(pierwszaLiczba) / int.Parse(drugaLiczba);
                    pokazWynik = Convert.ToString(wynik);
                    textBox1.Text = pokazWynik; sprawdz = false;
                    czystyEkran = true;
                    break;
                
            }
                    pierwszaLiczba = ""; drugaLiczba = "";
                    znakDzialania= '#';
            textBox2.Text += "=" + textBox1.Text;
            textBox3.Text += "=" + textBox1.Text+"   |   ";



        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void historia_Click(object sender, EventArgs e)
        {
          
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pierwszaLiczba = "";
            drugaLiczba = "";
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            int dlugosc = pierwszaLiczba.Length;
            String zn =Convert.ToString(znakDzialania);
            if (zn== "#")

            {
                pierwszaLiczba = pierwszaLiczba.Substring(0, dlugosc -1);
                textBox1.Text = textBox1.Text.Substring(0, dlugosc - 1);
            }
            else {
                int dlugosc2 = textBox1.Text.Length;
                int dlugosc3 = drugaLiczba.Length;
                drugaLiczba = drugaLiczba.Substring(0, dlugosc3- 1);
                textBox1.Text = textBox1.Text.Substring(0, dlugosc2 - 1);
            }
        }

        

        private void procent_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            procentWynik = (Convert.ToDouble(pierwszaLiczba)/100)*Convert.ToDouble(drugaLiczba);
            drugaLiczba = Convert.ToString(procentWynik);
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if (znakDzialania == '#')
            {
                textBox1.Text += "*";
                znakDzialania = '*';
                sprawdz = true;
                wyswietl = pierwszaLiczba;

            }
            else
            {

                Double wynik = 0;
                wynik = double.Parse(pierwszaLiczba) * double.Parse(drugaLiczba);
                wyswietl += znakDzialania + drugaLiczba;
                String pokazWynik = Convert.ToString(wynik);
                znakDzialania = '*';
                textBox2.Text = wyswietl;
                textBox1.Text += znakDzialania;
                pierwszaLiczba = pokazWynik;
                drugaLiczba = "";

            }
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            if (znakDzialania == '#')
            {
                textBox1.Text += "-";
                znakDzialania = '-';
                sprawdz = true;
                wyswietl = pierwszaLiczba;

            }
            else
            {
             
                Double wynik = 0;
                wynik = double.Parse(pierwszaLiczba) +  double.Parse(drugaLiczba);
                sumaDzialania = wynik;
                wyswietl += znakDzialania + drugaLiczba;
                String pokazWynik = Convert.ToString(sumaDzialania);
                znakDzialania = '-';
                textBox2.Text = wyswietl;
                textBox1.Text += znakDzialania;
                pierwszaLiczba = pokazWynik;
                drugaLiczba = "";

            }
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            

            if (znakDzialania == '#')
            {
                textBox1.Text += "+";
                znakDzialania = '+';
                sprawdz = true;
                wyswietl = pierwszaLiczba;
                
            }
            else {
          
                Double wynik = 0;
                wynik= double.Parse(pierwszaLiczba) + double.Parse(drugaLiczba);
                sumaDzialania = wynik;
               
                wyswietl +=znakDzialania+ drugaLiczba;
                String pokazWynik = Convert.ToString(wynik);
                znakDzialania = '+';
                textBox2.Text = wyswietl;
                textBox1.Text += znakDzialania;
                pierwszaLiczba = pokazWynik;
                drugaLiczba = "";
                
            }
            
            
        }
        private void button15_Click(object sender, EventArgs e)
        {       //dzielenie
            if (znakDzialania == '#')
            {
                textBox1.Text += "/";
                znakDzialania = '/';
                sprawdz = true;
                wyswietl = pierwszaLiczba;

            }
            else
            {

                Double wynik = 0;
                wynik = double.Parse(pierwszaLiczba) / double.Parse(drugaLiczba);
                wyswietl += znakDzialania + drugaLiczba;
                String pokazWynik = Convert.ToString(wynik);
                znakDzialania = '/';
                textBox2.Text = wyswietl;
                textBox1.Text += znakDzialania;
                pierwszaLiczba = pokazWynik;
                drugaLiczba = "";

            }
        }


        private void zero_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "0";
            if (sprawdz == false) { pierwszaLiczba += 0; czystyEkran = false; }
            else { drugaLiczba += 0; }
        }

      


        private void button7_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "9";
            if (sprawdz == false) { pierwszaLiczba += 9; czystyEkran = false; }
            else { drugaLiczba += 9; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "8";
            if (sprawdz == false) { pierwszaLiczba += 8; czystyEkran = false; }
            else { drugaLiczba += 8; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "7";
            if (sprawdz == false) { pierwszaLiczba +=7; czystyEkran = false; }
            else { drugaLiczba += 7; }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "6";
            if (sprawdz == false) { pierwszaLiczba += 6; czystyEkran = false; }
            else { drugaLiczba += 6; }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "5";
            if (sprawdz == false) { pierwszaLiczba += 5; czystyEkran = false; }
            else { drugaLiczba += 5; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "4";
            if (sprawdz == false) { pierwszaLiczba += 4; czystyEkran = false; }
            else { drugaLiczba += 4; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; } 
            textBox1.Text += "3";
            if (sprawdz == false) { pierwszaLiczba += 3; czystyEkran = false; }
            else { drugaLiczba += 3; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "2";
            if (sprawdz == false) { pierwszaLiczba += 2; czystyEkran = false; }
            else { drugaLiczba += 2; }
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
               textBox1.Text += "1";
            if (sprawdz == false) { pierwszaLiczba+= 1; czystyEkran = false; }
            else { drugaLiczba += 1; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
