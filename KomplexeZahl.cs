using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Klassen_und_Methoden
{
    internal class KomplexeZahl
    {
        private double real;
        public double imaginaer;

        public KomplexeZahl(double real, double imaginaer)
        {
            this.real = real;
            this.imaginaer = imaginaer;
        }

        public KomplexeZahl(KomplexeZahl kz) //Inception Konstruktor
        {
            this.real = kz.real;
            this.imaginaer = kz.imaginaer;
        }

        public override string ToString()
        {
            return $"Real = {real}\nImaginaer = {imaginaer}\n";
        }

        public void Add(KomplexeZahl kz)
        {
            this.real = this.real + kz.real;
            this.imaginaer = this.imaginaer + kz.imaginaer;
        }

        public void Sub(KomplexeZahl kz)
        {
            real = real - kz.real;
            imaginaer = imaginaer - kz.imaginaer;
        }

        public void Mul(KomplexeZahl kz)
        {
            real = real * kz.real;
            imaginaer = imaginaer * kz.imaginaer;
        }
        public static KomplexeZahl Berechnung(string rechenart, KomplexeZahl kz1, KomplexeZahl kz2)
        {
            KomplexeZahl erg_kz = new KomplexeZahl(kz1);
            switch (rechenart)
            {
                case "+":
                    erg_kz.Add(kz2);
                    break;
                    case "-":
                    erg_kz.Sub(kz2);
                    break;
                case "*":
                    erg_kz.Mul(kz2);
                    break;
                default:
                    Console.WriteLine("Fehler");
                    break;
            }
            return erg_kz;
        }
    }
}
