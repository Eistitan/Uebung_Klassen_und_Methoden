using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Klassen_und_Methoden
{
    internal class Ob_Archiv
    {
        public static void Abfrage()
        {
            Console.WriteLine("Sortieren nach (r)eellen oder (i)maginären Zahlen?");
            string? auswahl =Console.ReadLine().ToLower();
            KomplexeZahl[] array_1 = new KomplexeZahl[5];

            array_1 = KomplexeZahl.Array_Befuellen(KomplexeZahl.Array_Ini(5));

            switch (auswahl)
            {
                case "r":
                    KomplexeZahl.Array_Sortieren(array_1, false);
                    break;
                case "i":
                    KomplexeZahl.Array_Sortieren(array_1, true);

                    break;
                default:
                    Console.WriteLine("Null Exception!");
                    break;
            }
        }
    }
}
