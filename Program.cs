﻿namespace Uebung_Klassen_und_Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KomplexeZahl k1 = new(10, 5);
            KomplexeZahl k2 = new(2, 15);

            //Console.Write("Rechenart:");
            //string? rechenart = Console.ReadLine();
            //KomplexeZahl k3=KomplexeZahl.Berechnung(rechenart,k1, k2);
            // Console.WriteLine(k3);
            //KomplexeZahl k4 = KomplexeZahl.Add(k1, k2);
            //Console.WriteLine(k4);
            //--------------------------------------
            //KomplexeZahl[] array_2 = new KomplexeZahl[5];
            //array_1 = KomplexeZahl.Array_Befuellen(KomplexeZahl.Array_Ini());
            //KomplexeZahl.Array_Sortieren(array_1, false);

            Ob_Archiv.Abfrage();

        }
    }
}