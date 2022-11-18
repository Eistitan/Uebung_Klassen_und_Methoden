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
        private double imaginaer;


        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginaer
        {
            get { return imaginaer; }
            set { imaginaer = value; }
        }


        public KomplexeZahl(double real, double imaginaer)
        {
            this.real = real;
            this.imaginaer = imaginaer;
        }

        public KomplexeZahl(KomplexeZahl kz) //Inception Konstruktor. Erzeugt echte Kopie. Deep Copy
        {
            this.real = kz.real;
            this.imaginaer = kz.imaginaer;
        }
        //-----------------------------------------------------------------------

        public string Ausgabe()
        {
            return $"({real}, {imaginaer}i)";
        }
        public override string ToString()
        {
            return Ausgabe();
        }
        //-----------------------------------------------------------------------

        public void Add(KomplexeZahl kz)
        {
            real = real + kz.real;
            imaginaer = imaginaer + kz.imaginaer;
        }
        public static KomplexeZahl Add(KomplexeZahl kz1, KomplexeZahl kz2)
        {
            KomplexeZahl erg_kz = new KomplexeZahl(kz1);
            erg_kz.Add(kz2);
            return erg_kz;
        }

        public void Sub(KomplexeZahl kz)
        {
            real = real - kz.real;
            imaginaer = imaginaer - kz.imaginaer;
        }
        public static KomplexeZahl Sub(KomplexeZahl kz1, KomplexeZahl kz2)
        {
            KomplexeZahl erg_kz = new KomplexeZahl(kz1);
            erg_kz.Sub(kz2);
            return erg_kz;
        }

        public void Mul(KomplexeZahl kz)
        {
            real = real * kz.real;
            imaginaer = imaginaer * kz.imaginaer;
        }
        public static KomplexeZahl Mul(KomplexeZahl kz1, KomplexeZahl kz2)
        {
            KomplexeZahl erg_kz = new KomplexeZahl(kz1);
            erg_kz.Mul(kz2);
            return erg_kz;
        }
        //------------------------------------------------------Array
        public static KomplexeZahl[] Array_Ini(int laenge) //ObjectArray initieren
        {
            KomplexeZahl[] array_2 = new KomplexeZahl[laenge]; 
            for (int i = 0; i < laenge; i++)
            {
                array_2[i] = new KomplexeZahl(0, 0);
            }
            return array_2;
        }
        public static KomplexeZahl[] Array_Befuellen(KomplexeZahl[] array_2)
        {
            array_2[0].real = 1;
            array_2[0].imaginaer = 2;

            array_2[1].real = 8;
            array_2[1].imaginaer = 5;

            array_2[2].real = 4;
            array_2[2].imaginaer = 3;

            array_2[3].real = 7;
            array_2[3].imaginaer = 1;

            array_2[4].real = 9;
            array_2[4].imaginaer = 6;

            return array_2;
        }

        public static void Array_Sortieren(KomplexeZahl[] arr_2, bool imagi) //2 Parameter
        {
            bool durchlauf;
            int laenge = arr_2.Length;
            KomplexeZahl[] clone = new KomplexeZahl[5];
            clone = Array_Ini(5);
            if (!imagi)
            {
                do
                {
                    durchlauf = false;
                    for (int i = 0; i < (laenge - 1); i++)
                    {
                        if (arr_2[i].real > arr_2[i + 1].real)
                        {
                            clone[i].real = arr_2[i + 1].real;
                            clone[i + 1].real = arr_2[i].real;
                            arr_2[i].real = clone[i].real;
                            arr_2[i + 1].real = clone[i + 1].real;
                            durchlauf = true;
                        }
                    }
                    laenge--;
                } while (durchlauf);
            }
            else
            {
                do
                {
                    durchlauf = false;
                    for (int i = 0; i < (laenge - 1); i++)
                    {
                        if (arr_2[i].imaginaer > arr_2[i + 1].imaginaer)
                        {
                            clone[i].imaginaer = arr_2[i + 1].imaginaer;
                            clone[i + 1].imaginaer = arr_2[i].imaginaer;
                            arr_2[i].imaginaer = clone[i].imaginaer;
                            arr_2[i + 1].imaginaer = clone[i + 1].imaginaer;
                            durchlauf = true;
                        }
                    }
                    laenge--;
                } while (durchlauf);
            }
            foreach (KomplexeZahl item in arr_2)
            {
                Console.WriteLine(item);
            }
        }

        //public static void Array_Sortieren2(KomplexeZahl[] arr_2, bool imagi) //2 Parameter
        //{
        //    bool durchlauf;
        //    int laenge = arr_2.Length;
        //    KomplexeZahl i_clone = new KomplexeZahl(0,0);
        //    KomplexeZahl i1_clone = new KomplexeZahl(0,0);
        //    if (!imagi)
        //    {
        //        do
        //        {
        //            durchlauf = false;
        //            for (int i = 0; i < (laenge - 1); i++)
        //            {
        //                if (arr_2[i].real > arr_2[i + 1].real)
        //                {
                            
        //                    i1_clone.real = arr_2[i + 1].real;
        //                    i_clone.real = arr_2[i].real;
        //                    arr_2[i].real = i_clone.real;
        //                    arr_2[i + 1].real = i1_clone.real;
        //                    durchlauf = true;
        //                }
        //            }
        //            laenge--;
        //        } while (durchlauf);
        //    }
        //    else
        //    {
        //        do
        //        {
        //            durchlauf = false;
        //            for (int i = 0; i < (laenge - 1); i++)
        //            {
        //                if (arr_2[i].imaginaer > arr_2[i + 1].imaginaer)
        //                {
        //                    i_clone.imaginaer = arr_2[i + 1].imaginaer;
        //                    i1_clone.imaginaer = arr_2[i].imaginaer;
        //                    arr_2[i].imaginaer = i_clone.imaginaer;
        //                    arr_2[i + 1].imaginaer = i1_clone.imaginaer;
        //                    durchlauf = true;
        //                }
        //            }
        //            laenge--;
        //        } while (durchlauf);
        //    }
        //    foreach (KomplexeZahl item in arr_2)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //------------------------------------------------------------------------------------
        //public static KomplexeZahl Berechnung(string rechenart, KomplexeZahl kz1, KomplexeZahl kz2)
        //{
        //    KomplexeZahl erg_kz = new KomplexeZahl(kz1);
        //    switch (rechenart)
        //    {
        //        case "+":
        //            erg_kz.Add(kz2);
        //            break;

        //        case "-":
        //            erg_kz.Sub(kz2);
        //            break;

        //        case "*":
        //            erg_kz.Mul(kz2);
        //            break;

        //        default:
        //            Console.WriteLine("Fehler"); //kz1 wird ausgegeben
        //            break;
        //    }
        //    return erg_kz;
        //}
    }
}
