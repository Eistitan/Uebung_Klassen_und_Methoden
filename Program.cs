namespace Uebung_Klassen_und_Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KomplexeZahl k1 = new(10, 5);
            KomplexeZahl k2 = new(2, 15);
            Console.Write("Rechenart:");
            string rechenart = Console.ReadLine();
            KomplexeZahl k3=KomplexeZahl.Berechnung(rechenart,k1, k2);
            Console.WriteLine(k3);
        }
    }
}