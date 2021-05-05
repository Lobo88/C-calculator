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
        //formatException dla np Parse 
        private Boolean sprawdz = false;
        Boolean czystyEkran = false;
        String pierwszaLiczba ;
        String drugaLiczba ;
        char znakDzialania ='#';
        char formatDzialania = '#';
        double procentWynik = 0;
        double pierwsza = 0;
        double druga = 0;
        int wynikListy = 0;
        
        public Form1()

        {
            InitializeComponent();
           // Bitmap bit = new Bitmap(@"E:\kalkulato.jpeg");
            // pictureBox1.Image = new Bitmap(@"E:\kalkulato.jpeg");
            // pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            // CheckBox checkBox1 = new CheckBox();
            //  checkBox1.Appearance = Appearance.Button;
            //checkBox1.AutoCheck = true;
            //  comboBox1.Items.AddRange(new CheckBox[] { checkBox1 });

            comboBox1.Items.AddRange(new object[] { "dodawanie", "odejmowanie", "mnozenie", "dzielenie" });
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("dodawanie")) {
                int suma =Convert.ToInt32(pierwszaLiczba)+ Convert.ToInt32( drugaLiczba);
                textBox2.Text = pierwszaLiczba +" + "+ drugaLiczba+ "="+Convert.ToString(suma);
                textBox1.Text = pierwszaLiczba + " + " + drugaLiczba; }
            if (comboBox1.Text.Equals("odejmowanie"))
            { int suma = Convert.ToInt32(pierwszaLiczba) - Convert.ToInt32(drugaLiczba);
                textBox2.Text = pierwszaLiczba + " - " + drugaLiczba + "=" + Convert.ToString(suma);
                textBox1.Text = pierwszaLiczba + " - " + drugaLiczba; }
            if (comboBox1.Text.Equals("mnozenie"))
            {int suma = Convert.ToInt32(pierwszaLiczba) * Convert.ToInt32(drugaLiczba);
                textBox2.Text = pierwszaLiczba + " * " + drugaLiczba + "=" + Convert.ToString(suma);
                textBox1.Text = pierwszaLiczba + " * " + drugaLiczba;}
            if (comboBox1.Text.Equals("dzielenie"))
            {int suma = Convert.ToInt32(pierwszaLiczba) / Convert.ToInt32(drugaLiczba);
                textBox2.Text = pierwszaLiczba + " / " + drugaLiczba + "=" + Convert.ToString(suma);
                textBox1.Text = pierwszaLiczba + " / " + drugaLiczba; }

        }


        public double Dzialanie(double pierwsza, double druga, char znak)
        {
            double wynik=0;
            switch (znak)
            {

                case ('+'):
                    wynik = pierwsza + druga;
                   
                    return wynik; 
                   
                case ('-'):
                    wynik = pierwsza - druga;
                
                    return wynik;
                case ('*'):
                    wynik = pierwsza * druga;
                    return wynik;
                case ('/'):
                    wynik = pierwsza / druga;
                    return wynik;
            }
            return wynik;
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            if (znakDzialania == '#')
            {
                textBox1.Text += "-";
                znakDzialania = '-';
                sprawdz = true;
                textBox2.Text += pierwszaLiczba;
            }
            else
            {
                textBox1.Text += "-";
                textBox2.Text += znakDzialania;

                pierwsza = Convert.ToDouble(pierwszaLiczba);
                druga = Convert.ToDouble(drugaLiczba);
                double wynik = Dzialanie(pierwsza, druga, znakDzialania);
                textBox2.Text += drugaLiczba;
               
                if (znakDzialania == '*' || znakDzialania == '/')
                {
                    textBox2.Text = "(" + textBox2.Text + ")";
                }
                pierwszaLiczba = Convert.ToString(wynik);
                drugaLiczba = "";
                znakDzialania = '-';
                textBox1.Text = pierwszaLiczba + znakDzialania;

            }
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {


            if (znakDzialania == '#')
            {
                textBox1.Text += "+";
                znakDzialania = '+';
                sprawdz = true;
             textBox2.Text = pierwszaLiczba;

            }
            else
            {
               
                textBox1.Text += "+";
              textBox2.Text += znakDzialania;

                pierwsza = Convert.ToDouble(pierwszaLiczba);
                druga = Convert.ToDouble(drugaLiczba);
                double wynik = Dzialanie(pierwsza, druga, znakDzialania);  
                textBox2.Text += drugaLiczba;
                if ( znakDzialania=='*' || znakDzialania == '/')
                {
                    textBox2.Text = "(" + textBox2.Text + ")";
                }
                pierwszaLiczba = Convert.ToString(wynik);
                drugaLiczba = "";
                znakDzialania = '+';
                textBox1.Text = pierwszaLiczba+znakDzialania;
            }


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
            if (znakDzialania.Equals('d'))
            {
                znakDzialania = '#';
            }
            if (znakDzialania.Equals('b'))
            {
                textBox3.Text += textBox2.Text + "="+ Convert.ToString(wynikListy)+" | ";
                textBox2.Text = "";
                wynikListy = 0;
                int rozmiar = dzialanie.Count;
                for (int i =0; i <=rozmiar-1; i ++)
                {
                    dzialanie.RemoveAt(0);
                }
            }

            else
            {
                //textBox2.Text = "";
                Double wynik = 0;

                switch (znakDzialania)
                {

                    case ('+'):

                        textBox2.Text += '+';
                        wynik = double.Parse(pierwszaLiczba) + double.Parse(drugaLiczba);
                        String pokazWynik = Convert.ToString(wynik);
                        textBox1.Text = pokazWynik;
                        sprawdz = false;
                        czystyEkran = true;



                        break;
                    case ('-'):
                        textBox2.Text += '-';
                        wynik = double.Parse(pierwszaLiczba) - double.Parse(drugaLiczba);
                        pokazWynik = Convert.ToString(wynik);
                        textBox1.Text = pokazWynik;
                        sprawdz = false;
                        czystyEkran = true;

                        break;
                    case ('*'):
                        textBox2.Text += '*';
                        wynik = double.Parse(pierwszaLiczba) * double.Parse(drugaLiczba);
                        pokazWynik = Convert.ToString(wynik);
                        textBox1.Text = pokazWynik;
                        sprawdz = false;
                        czystyEkran = true;

                        break;
                    case ('/'):
                        textBox2.Text += '/';
                        wynik = double.Parse(pierwszaLiczba) / double.Parse(drugaLiczba);
                        pokazWynik = Convert.ToString(wynik);
                        textBox1.Text = pokazWynik;
                        sprawdz = false;
                        czystyEkran = true;

                        break;

                }
                textBox2.Text += drugaLiczba;
                pierwszaLiczba = ""; drugaLiczba = "";
                znakDzialania = '#';
                textBox2.Text += "=" + textBox1.Text;
                textBox3.Text += textBox2.Text + "   |   ";
                znakDzialania = '=';


            }
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
            textBox2.Text = "";
            pierwszaLiczba = "";
            drugaLiczba = "";
            znakDzialania = '#';
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
                textBox2.Text += pierwszaLiczba;
            }
            else
            {
                textBox1.Text += "*";
                textBox2.Text += znakDzialania;

                pierwsza = Convert.ToDouble(pierwszaLiczba);
                druga = Convert.ToDouble(drugaLiczba);
                double wynik = Dzialanie(pierwsza, druga, znakDzialania);
                textBox2.Text += drugaLiczba;
                textBox2.Text = "(" + textBox2.Text + ")";
                pierwszaLiczba = Convert.ToString(wynik);
                drugaLiczba = "";
                znakDzialania = '*';
                textBox1.Text = pierwszaLiczba + znakDzialania;

            }
        }

       
        private void button15_Click(object sender, EventArgs e)
        {       //dzielenie
            
                if (znakDzialania == '#')
                {
                    textBox1.Text += "/";
                    znakDzialania = '/';
                    sprawdz = true;
                    textBox2.Text += pierwszaLiczba;
                }
                else
                {
                    textBox1.Text += "/";
                    textBox2.Text += znakDzialania;

                    pierwsza = Convert.ToDouble(pierwszaLiczba);
                    druga = Convert.ToDouble(drugaLiczba);
                    double wynik = Dzialanie(pierwsza, druga, znakDzialania);
                    textBox2.Text += drugaLiczba;
                    textBox2.Text = "(" + textBox2.Text + ")";
                    pierwszaLiczba = Convert.ToString(wynik);
                    drugaLiczba = "";
                    znakDzialania = '/';
                    textBox1.Text = pierwszaLiczba + znakDzialania;

                }
            }


        private void zero_Click(object sender, EventArgs e)
        {
            try {
                if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
                if (znakDzialania.Equals('/'))
                {
                    throw new ArgumentException(textBox3.Text += String.Format(""));
                }

                if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
                textBox1.Text += "0";
                if (sprawdz == false) { pierwszaLiczba += 0; czystyEkran = false; }
                else { drugaLiczba += 0; }
           }catch { textBox3.Text += String.Format("nie dzielimy przez zero"); }
        }

      


        private void button7_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "9";
            if (sprawdz == false) { pierwszaLiczba += 9; czystyEkran = false; }
            else { drugaLiczba += 9; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "8";
            if (sprawdz == false) { pierwszaLiczba += 8; czystyEkran = false; }
            else { drugaLiczba += 8; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "7";
            if (sprawdz == false) { pierwszaLiczba +=7; czystyEkran = false; }
            else { drugaLiczba += 7; }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "6";
            if (sprawdz == false) { pierwszaLiczba += 6; czystyEkran = false; }
            else { drugaLiczba += 6; }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "5";
            if (sprawdz == false) { pierwszaLiczba += 5; czystyEkran = false; }
            else { drugaLiczba += 5; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "4";
            if (sprawdz == false) { pierwszaLiczba += 4; czystyEkran = false; }
            else { drugaLiczba += 4; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; } 
            textBox1.Text += "3";
            if (sprawdz == false) { pierwszaLiczba += 3; czystyEkran = false; }
            else { drugaLiczba += 3; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
            textBox1.Text += "2";
            if (sprawdz == false) { pierwszaLiczba += 2; czystyEkran = false; }
            else { drugaLiczba += 2; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znakDzialania.Equals('=')) { textBox2.Text = ""; znakDzialania = '#'; }
            if (czystyEkran == true) { textBox1.Text = ""; czystyEkran = false; }
               textBox1.Text += "1";
            if (sprawdz == false) { pierwszaLiczba+= 1; czystyEkran = false; }
            else { drugaLiczba += 1; }
        }
        private void button10_Click(object sender, EventArgs e)
        {//przelacz na binarne 
            label1.Visible = true;
            panel1binarne.Visible = true;
            panel1szesnastkowe.Visible = false;
            panel1Zwykly.Visible = false;

        }
        private void button11_Click(object sender, EventArgs e)
        {//przelacz na szesnastkowe
            label1.Visible = false;
            panel1binarne.Visible = false;
            panel1szesnastkowe.Visible = true;
            panel1Zwykly.Visible = false;
        }

        private void zaokPoPrzecinku_Click(object sender, EventArgs e)
        {
            double liczba = double.Parse(textBox1.Text);
            double zaok =Math.Round(liczba,1, MidpointRounding.ToEven);
            textBox2.Text = textBox1.Text + " = " + Convert.ToString(zaok);

        }

        private void eDoPoteg_Click(object sender, EventArgs e)
        {
            double liczba = double.Parse(textBox1.Text);
            double pote = Math.Exp(liczba);
            textBox2.Text = textBox1.Text + " = " + Convert.ToString(pote);
        }

        private void zaDoDziesietnych_Click(object sender, EventArgs e)
        {
            double liczba = double.Parse(textBox1.Text);
            double zaok = Math.Round(liczba);
            textBox2.Text = textBox1.Text + " = " + Convert.ToString(zaok);
        }

        private void potega_Click(object sender, EventArgs e)
        {
            double potega;
            double liczba1 = 0;
            double liczba2 = 0;

            if (znakDzialania.Equals('l'))
            {
                liczba1 = double.Parse(drugaLiczba);
                liczba2 = double.Parse(textBox1.Text);
                potega = Math.Pow(liczba1, liczba2);
                textBox2.Text += " do potegi : " + textBox1.Text + " = " + Convert.ToString(potega);
                textBox1.Text = "";

                pierwszaLiczba = "";
                znakDzialania = '#';
            }

            else
            {
                znakDzialania = 'l';
                drugaLiczba = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(drugaLiczba);
                textBox3.Text = "do jakiej potegi chcesz podniesc liczbe?  ";
             
            }
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            double liczba = double.Parse(textBox1.Text);
            double zaok = Math.Sqrt(liczba);
            textBox2.Text = "pierwiastek z : "+ textBox1.Text + " = " + Convert.ToString(zaok);
        }

        private void sinDlaKat_Click(object sender, EventArgs e)
        {
            double liczba = double.Parse(textBox1.Text);
            double stopnie = Math.PI * liczba / 180.0;
            double sin = Math.Round(Math.Sin(stopnie),2);
            textBox2.Text = "sinus dla kata : "+textBox1.Text + " = " + Convert.ToString(sin);
        }

        private void katDlaSin_Click(object sender, EventArgs e)
        {
            double logarytm;
            double liczba1=0;
            double liczba2=0;

            if (znakDzialania.Equals('l'))
            {
                liczba1 = double.Parse(drugaLiczba);
                liczba2= double.Parse(textBox1.Text);
                logarytm = Math.Round(Math.Log(liczba1, liczba2),2);
                textBox2.Text += " log " + textBox1.Text + " = " + Convert.ToString(logarytm) ;
                textBox1.Text = "";

                pierwszaLiczba = "";
                znakDzialania = '#';
            }

            else
            {
                znakDzialania = 'l';
                drugaLiczba = textBox1.Text;
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(drugaLiczba);
                textBox3.Text = "podaj podstawe logarytmu "; 
            }
        }


        List<dzialanie> dzialanie = new List<dzialanie>();


        private void dzielPrzez2_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            String z;
            znakDzialania = 'b';
           
            Operator dz = Operator.dizelenie;
            char znak = (char)dz;
            textBox1.Text =Convert.ToString( znak )+2;
            textBox2.Text += Convert.ToString(znak)+2;
            dzialanie.Add(new dzialanie(dz,2));
            foreach (dzialanie dzialanie in dzialanie)
            {
                if (Convert.ToChar(dzialanie.znak).Equals('*'))
                { wynik = wynik * 2; }
                else if (Convert.ToChar(dzialanie.znak).Equals('/'))
                { wynik = wynik / 2; }
                else
                {
                    z = Convert.ToChar(dzialanie.znak) + Convert.ToString(dzialanie.liczba);

                    wynik = wynik + int.Parse(z);
                }
                wynikListy = wynik;
            }
        }

        private void razy2_Click(object sender, EventArgs e)
        {
            int wynik=0;
            String z;

            znakDzialania = 'b';
           
              Operator dz = Operator.mnozenie;
            char znak = (char)dz;
            textBox1.Text = Convert.ToString(znak) + 2;
            textBox2.Text += Convert.ToString(znak) + 2;
            dzialanie.Add(new dzialanie(dz,2));

            foreach (dzialanie dzialanie in dzialanie)
            {
                if (Convert.ToChar(dzialanie.znak).Equals('*'))
                { wynik = wynik * 2; }
               else  if (Convert.ToChar(dzialanie.znak).Equals('/'))
                { wynik = wynik / 2; }
                else
                {
                    z = Convert.ToChar(dzialanie.znak) + Convert.ToString(dzialanie.liczba);

                    wynik = wynik + int.Parse(z);
                }
                wynikListy = wynik;
            }


          
        }

        private void plus5_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            String z  ;
            znakDzialania = 'b';
            Operator dz = Operator.plus;
            char znak = (char)dz;
            textBox1.Text = Convert.ToString(znak) + 5;
            textBox2.Text += Convert.ToString(znak) + 5;
            dzialanie.Add(new dzialanie( dz,5));
            foreach (dzialanie dzialanie in dzialanie)
            {
                if (Convert.ToChar(dzialanie.znak).Equals('*'))
                { wynik = wynik * 2; }
                else if (Convert.ToChar(dzialanie.znak).Equals('/'))
                { wynik = wynik / 2; }
                else
                {
                    z = Convert.ToChar(dzialanie.znak) + Convert.ToString(dzialanie.liczba);

                    wynik = wynik + int.Parse(z);
                }
                wynikListy = wynik;


            }
            wynik = 0;
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            int wynik = 0;
            String z;
            znakDzialania = 'b';
          
            Operator dz = Operator.minus;
            char znak = (char)dz;
            textBox1.Text = Convert.ToString(znak) + 1;
            textBox2.Text += Convert.ToString(znak) + 1;
            dzialanie.Add(new dzialanie(dz,1));
            foreach (dzialanie dzialanie in dzialanie)
            {
                if (Convert.ToChar(dzialanie.znak).Equals('*'))
                { wynik = wynik * 2; }
                else if (Convert.ToChar(dzialanie.znak).Equals('/'))
                { wynik = wynik / 2; }
                else
                {
                    z = Convert.ToChar(dzialanie.znak) + Convert.ToString(dzialanie.liczba);

                    wynik = wynik + int.Parse(z);
                }
                wynikListy = wynik;
            }
        }

      
        ///////////////////////////okno2//////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        /// textbox 4 glowny wiekszy
        /// textbox 5 mniejszy/ wpisujemy teraz 
        /// textbox 6 historia
        /// 
        String PierwszaLiczbaOkno2;
        String DrugaLiczbaOkno2;
        char flagaDlaLicz = '#';
        char formatLiczb ='#';
        String bit = "0";
        int iloscBitow =0 ;
        private char[] tablicaHex;
        private double[] tablicaHex2;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1Zwykly_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1binarne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kalkZwykly_Click(object sender, EventArgs e)
        {
            panel1binarne.Visible = false; panel1szesnastkowe.Visible = false;
            panel1Zwykly.Visible = true;
        }

        private void kalkHex_Click(object sender, EventArgs e)
        {
            panel1binarne.Visible = false; panel1szesnastkowe.Visible = true;
        }

        private void wyczyscOkno2_Click(object sender, EventArgs e)
        {
            label1.Text = "wybierz opcje dziesi lub dwoj";
            label1.Visible = true;
            textBox5.Text = "";
            textBox4.Text = "";
            flagaDlaLicz = '#';
            iloscBitow = 0;
            formatLiczb = '#';
            PierwszaLiczbaOkno2 = "";
            DrugaLiczbaOkno2 = "";
        }

        private void wsteczOkno2_Click(object sender, EventArgs e)
        {
            int dlugosc = textBox5.Text.Length;
            textBox5.Text = textBox5.Text.Substring(0, dlugosc - 1);
        }

        private void rowna2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            

            if (formatLiczb.Equals('d'))
            {
               
                switch (flagaDlaLicz)
                {

                    case ('+'):
                        int wynik = int.Parse(PierwszaLiczbaOkno2) +int.Parse(DrugaLiczbaOkno2);
                        textBox4.Text +=DrugaLiczbaOkno2 + "=" +Convert.ToString( wynik);
                        break;
                    case ('-'):
                        int wynik2 = int.Parse(PierwszaLiczbaOkno2) - int.Parse(DrugaLiczbaOkno2);
                        textBox4.Text += DrugaLiczbaOkno2 + "=" + Convert.ToString(wynik2);
                        break;
                    case ('*'):
                        int wynik3 = int.Parse(PierwszaLiczbaOkno2) * int.Parse(DrugaLiczbaOkno2);
                        textBox4.Text += DrugaLiczbaOkno2 + "=" + Convert.ToString(wynik3);
                        break;
                    case ('/'):
                        int wynik4 = int.Parse(PierwszaLiczbaOkno2) / int.Parse(DrugaLiczbaOkno2);
                        textBox4.Text += DrugaLiczbaOkno2 + "=" + Convert.ToString(wynik4);
                        break;
                }
            }
            else if (formatLiczb.Equals('2'))
            {
                int licz1 = Convert.ToInt32(PierwszaLiczbaOkno2, 2);
                int licz2 = Convert.ToInt32(DrugaLiczbaOkno2, 2);
                switch (flagaDlaLicz)
                {
                    case ('+'):
                        int wynik = licz1 + licz2;
                        textBox4.Text = PierwszaLiczbaOkno2 + flagaDlaLicz +
                            DrugaLiczbaOkno2 + "=";

                        int[] tab = new int[iloscBitow];
                        tab =liczNaDwojkowy(Convert.ToString(  wynik));
                        
                        for (int j = iloscBitow + 1; j >= 0; j--)
                        {
                            textBox4.Text += Convert.ToString( tab[j]);
                        }
                        break;

                    case ('-'):
                        int wynik2 = licz1 - licz2;
                        textBox4.Text = PierwszaLiczbaOkno2 + flagaDlaLicz +
                            DrugaLiczbaOkno2 + "=";

                        int[] tab2 = new int[iloscBitow];
                        tab = liczNaDwojkowy(Convert.ToString(wynik2));

                        for (int j = iloscBitow + 1; j >= 0; j--)
                        {
                            textBox4.Text += Convert.ToString(tab[j]);
                        }
                        break;
                    case ('*'):
                        int wynik3 = licz1 * licz2;
                        textBox4.Text = PierwszaLiczbaOkno2 + flagaDlaLicz +
                            DrugaLiczbaOkno2 + "=";

                        int[] tab3 = new int[iloscBitow];
                        tab = liczNaDwojkowy(Convert.ToString(wynik3));

                        for (int j = iloscBitow + 1; j >= 0; j--)
                        {
                            textBox4.Text += Convert.ToString(tab[j]);
                        }
                        break;
                    case ('/'):
                        int wynik4 = licz1 / licz2;
                        textBox4.Text = PierwszaLiczbaOkno2 + flagaDlaLicz +
                            DrugaLiczbaOkno2 + "=";

                        int[] tab4 = new int[iloscBitow];
                        tab = liczNaDwojkowy(Convert.ToString(wynik4));

                        for (int j = iloscBitow + 1; j >= 0; j--)
                        {
                            textBox4.Text += Convert.ToString(tab[j]);
                        }
                        break;
                }
            }
            textBox6.Text += textBox4.Text+ "  |";
        }

        private void dziel2_Click(object sender, EventArgs e)
        {
           // label1.Visible = true;
            if (flagaDlaLicz.Equals('#'))
            {
                PierwszaLiczbaOkno2 = textBox5.Text;
                textBox5.Text += "/";
                textBox4.Text = textBox5.Text;
                flagaDlaLicz = '/';

            }//else 
        }

        private void mnoz2_Click(object sender, EventArgs e)
        {
            //label1.Visible = true;
            if (flagaDlaLicz.Equals('#'))
            {
                PierwszaLiczbaOkno2 = textBox5.Text;
                textBox5.Text += "*";
                textBox4.Text = textBox5.Text;
                flagaDlaLicz = '*';

            }//else 
        }

        private void odejmijOkno2_Click(object sender, EventArgs e)
        {
           //  label1.Visible = true;
         
            if (flagaDlaLicz.Equals('#'))
            {
                PierwszaLiczbaOkno2 = textBox5.Text;
                textBox5.Text += "-";
                textBox4.Text = textBox5.Text;
                flagaDlaLicz = '-';

            }//else 
        }

        private void dodajOkno2_Click(object sender, EventArgs e)
        {
           // label1.Visible = true;
            if (flagaDlaLicz.Equals('#'))
            { PierwszaLiczbaOkno2 = textBox5.Text;
               textBox5.Text += "+";
                textBox4.Text = textBox5.Text;
                flagaDlaLicz = '+';

            }//else 



        }

        private void button5okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("5", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 5;
                textBox5.Text += "5";

            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        
        }

        private void dwojkowe_Click(object sender, EventArgs e)
        {
            iloscBitow = Convert.ToInt16(bit);

            if (iloscBitow == 0)
            {
                label1.Text = "wprowadz ilosc bitow.Zatwierdz: dwojkowy";

            }
            else
            {
                label1.Visible = false;
                textBox5.Text = "";
                formatLiczb = '2';
                
            }
        }

        private void Dziesietne_Click(object sender, EventArgs e)
        {
            iloscBitow = 1;
            label1.Visible = false;
            formatLiczb = 'd';

            
        }
        public char WpiszCyfre (string cyfra ,char znak)
        {
            
            if (flagaDlaLicz.Equals('#'))
            {
                textBox5.Text += cyfra;
                
            }
            else
            {
                 textBox5.Text += cyfra;  DrugaLiczbaOkno2 += cyfra;
            }
            return znak;
        }
        private void button0okno2_Click(object sender, EventArgs e)
        {
             if (iloscBitow == 0)
            {
                bit += 2;

            }
             else 
            WpiszCyfre("0", znakDzialania);
       
            
        }

        private void button9okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("9", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 9;
                textBox5.Text += "9";
               
            }

            else if (formatLiczb.Equals('2')&& iloscBitow !=0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button8okno2_Click(object sender, EventArgs e)
        {

            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("8", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 8;
                textBox5.Text += "8";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button7okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("7", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 7;
                textBox5.Text += "7";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            
                {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button6okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("6", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 6;
                textBox5.Text += "6";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button4okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("4", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 4;
                textBox5.Text += "4";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button3okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("3", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 3;
                textBox5.Text += "3";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button2okno2_Click(object sender, EventArgs e)
        {
            if (formatLiczb.Equals('d') && iloscBitow != 0)
            {
                WpiszCyfre("2", znakDzialania);
            }
            else if (iloscBitow == 0)
            {
                bit += 2;
                textBox5.Text += "2";
            }

            else if (formatLiczb.Equals('2') && iloscBitow != 0)
            {
                label1.Visible = true;
                label1.Text = "zla liczba, wybierz 0 badz 1";
            }
        }

        private void button1okno2_Click(object sender, EventArgs e)
        {
             if (iloscBitow == 0)
            {
                bit += 2;
                textBox5.Text += "1";
            }
            else {


                WpiszCyfre("1", znakDzialania);
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void przeliczNaDwojkowy_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text;

                int i = 0;
                int[] tab = new int[32];
                int liczbaDoPrzeliczenia = Convert.ToInt16(textBox4.Text);
            textBox4.Text = "";

                while (liczbaDoPrzeliczenia != 0)
                {
                    tab[i++] = liczbaDoPrzeliczenia % 2;
                    liczbaDoPrzeliczenia /= 2;
                }
        
            for (int j = i - 1; j >= 0; j--)
            {
                textBox4.Text += tab[j];
            }
            textBox6.Text += textBox5.Text + "(10)=" + textBox4.Text + "(2) | ";
        }

        public int []  liczNaDwojkowy(string liczba)
        {
            int i = 0;
            int[] tab = new int[32];
            int liczbaDoPrzeliczenia = Convert.ToInt16(liczba);
            while (liczbaDoPrzeliczenia != 0)
            {
                tab[i++] = liczbaDoPrzeliczenia % 2;
                liczbaDoPrzeliczenia /= 2;
            }
            return tab;
        }

        private void przeliczNaDziesietne_Click(object sender, EventArgs e)
        {

           int liczba= Convert.ToInt32(textBox5.Text, 2);
            textBox4.Text = Convert.ToString( liczba);
            textBox6.Text += textBox5.Text+"(2)="+textBox4.Text+ "(10) | ";
            }

        public int liczNaDziesietne (String liczba)
        {
            int liczba2 = Convert.ToInt32(liczba, 2);
            return liczba2;

        }

        //////////////////////////////////////okno3///////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        /// textbox 9 glowny wiekszy
        /// textbox 8 mniejszy/ wpisujemy teraz 
        /// textbox 7 historia
       
        private void hexOkno3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            formatDzialania = 'h';
        }

        private void decimalOkno3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            formatDzialania = 'd';
        }

        private void F_Click(object sender, EventArgs e)
        {
            textBox8.Text += "F";
        }

        private void E_Click(object sender, EventArgs e)
        {
            textBox8.Text += "E";
        }

        private void D_Click(object sender, EventArgs e)
        {
            textBox8.Text += "D";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox8.Text += "C";
        }

        private void B_Click(object sender, EventArgs e)
        {
            textBox8.Text += "B";
        }

        private void A_Click(object sender, EventArgs e)
        {
            textBox8.Text += "A";
        }

        private void button0okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "0";
        }

        private void button9okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "9";
        }

        private void button8okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "8";
        }

        private void button7okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "7";
        }

        private void button6okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "6";
        }

        private void button5okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "5";
        }

        private void button4okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "4";
        }

        private void button3okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "3";
        }

        private void button2okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "2";
        }

        private void button1okno3_Click(object sender, EventArgs e)
        {
            textBox8.Text += "1";
        }

        private void kalkulatorDwojOkno3_Click(object sender, EventArgs e)
        {
            panel1binarne.Visible = true; panel1szesnastkowe.Visible = false;
            label1.Visible = true;
        }

        private void kalkZwyklyOkno3_Click(object sender, EventArgs e)
        {
            panel1binarne.Visible = false;  panel1szesnastkowe.Visible = false;
            panel1Zwykly.Visible = true;
        }

        private void wyczyscOkno3_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox7.Text += textBox9.Text;
            textBox9.Text = "";
            label2.Visible = true;
        }

        private void wsteczOkno3_Click(object sender, EventArgs e)
        {
            int dlugosc = textBox8.Text.Length;
           textBox8.Text = textBox8.Text.Substring(0, dlugosc - 1);

        }
        private void rowna3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (formatDzialania == 'h')
            {
                naDecZHex(pierwszaLiczba);
                drugaLiczba = pierwszaLiczba;
                naDecZHex(textBox8.Text);
                int Fvalue = Convert.ToInt16(pierwszaLiczba);
                int Svalue = Convert.ToInt16(drugaLiczba);
                int result=SumHexChar(znakDzialania, Fvalue, Svalue);
               
                  
                int hex = 16;
                String s = "";
                for (int liczba = result; liczba > 0; liczba /= hex)
                {
                    int reszta = liczba % hex;
                    s = reszta < 10 ? reszta + s : (char)('A' - 10 + reszta) + s;
                }

                String xwi = Convert.ToString(s);
               
                textBox9.Text += textBox8.Text +" = " + xwi+ "(16)" ;
                textBox8.Text = "";
                textBox7.Text += drugaLiczba + znakDzialania+ pierwszaLiczba + "=" + result + "(10)  | ";


            }

            
        }
        public int SumHexChar(char sign, int first, int second)
        {
            int result=0;
           
            switch (sign)
            {
                case '+':
                    result = first + second;
                    return result;
                case '-':
                    result = second-first;
                    return result;
                case '*':
                    result = second * first;
                    return result;
                case '/':
                    result = second / first;
                    return result;
            }
            return result;
        }

        private void dziel3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox9.Text += textBox8.Text + "/";
            pierwszaLiczba = textBox8.Text;
            textBox8.Text = "";
            znakDzialania = '/';
        }

        private void mnoz3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox9.Text += textBox8.Text + "*";
            pierwszaLiczba = textBox8.Text;
            textBox8.Text = "";
            znakDzialania = '*';
        }

        private void odejmijOkno3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox9.Text += textBox8.Text + "-";
            pierwszaLiczba = textBox8.Text;
            textBox8.Text = "";
            znakDzialania = '-';
        }

        private void dodajOkno3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox9.Text +=textBox8.Text+ "+";
            pierwszaLiczba = textBox8.Text;
            textBox8.Text = "";
            znakDzialania = '+';

        }

        private void PrzeliczNaHex_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(textBox8.Text);// 68; //  74382; //  14380;//1438;//  
            int hex = 16;
            
                String s = "";
                for (int liczba = l; liczba> 0; liczba /= hex)
                {
                    int reszta = liczba % hex;
                    s = reszta < 10 ? reszta + s : (char)('A' - 10 + reszta) + s;
                }
            textBox9.Text += textBox8.Text + "(10) =" + Convert.ToString(s) + "(16) | ";

        }
       
        private void przeliczNaDec_Click(object sender, EventArgs e)
        {
            formatDzialania = 'd';
            String doZamiany = textBox8.Text;
            naDecZHex(doZamiany);

        }

        public void naDecZHex(String hex)
        {
            int ile = hex.Length;
           
            double wynik=0;
            tablicaHex = new char[ile];
            tablicaHex2 = new double[ile];

            // textBox9.Text += ile;

            for (int i = 0; i < ile; i++)
            {
                tablicaHex[i] = Convert.ToChar( hex.Substring(i, 1));

            }
            for (int i = 0; i < ile; i++)
            {
                tablicaHex2[i] = przelicznikZdeNaHex(tablicaHex[i]);
                tablicaHex2[i] = tablicaHex2[i] * Math.Pow(16,ile-1-i);
              //  textBox9.Text += "      " +tablicaHex2[i];
                wynik += tablicaHex2[i];
            }
            if (formatDzialania == 'h')
            {
                pierwszaLiczba = Convert.ToString(wynik);

            }
            else
            {
                textBox9.Text += textBox8.Text + "(16) =" + Convert.ToString(wynik) + "(10) | ";
            }
           
        }

        public int przelicznikZdeNaHex (char znak)
        {
            int liczba = 0;

            switch (znak)
            {
                case 'A':
                    liczba = 10;
                    break;
                case 'B':
                    liczba = 11;
                    break;
                case 'C':
                    liczba = 12;
                    break;
                case 'D':
                    liczba = 13;
                    break;
                case 'E':
                    liczba = 14;
                    break;
                case 'F':
                    liczba = 15;
                    break;
                case '0':
                    liczba = 0;
                    break;
                case '1':
                    liczba = 1;
                    break;
                case '2':
                    liczba = 2;
                    break;
                case '3':
                    liczba = 3;
                    break;
                case '4':
                    liczba = 4;
                    break;
                case '5':
                    liczba = 5;
                    break;
                case '6':
                    liczba = 6;
                    break;
                case '7':
                    liczba = 7;
                    break;
                case '8':
                    liczba = 8;
                    break;
                case '9':
                    liczba = 9;
                    break;
                

            }

                    return liczba;
            }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1Zwykly.Visible = true;
        }

        
    }

    
}
