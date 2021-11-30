using System;

namespace Bankrekening
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bankrekening b1 = new Bankrekening();
            Bankrekening b2 = new Bankrekening();

            decimal bedrag = 100m;
            b1.Overschrijven(b2, bedrag);
            Console.WriteLine(b1.Saldo() == -100m); // zou true moeten geven
            Console.WriteLine(b2.Saldo() == 100m);  // zou true moeten geven
        }
    }
}