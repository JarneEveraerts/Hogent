using System;

namespace PrijsAppels
{
    class Program
    {
        static void Main(string[] args)
        {
            double Prijs, Kilos;
            Console.WriteLine("Hoeveel kilos appels wilt u");
            Kilos = double.Parse(Console.ReadLine());
            if (Kilos>=20)
            {
                Prijs = Kilos * 2;
                Console.WriteLine($"u betaald {Prijs}€");
            }
            else if (Kilos>=10)
            {
                Prijs = Kilos * 2.5;
                Console.WriteLine($"u betaald {Prijs}€");
            }
            else
            {
                Prijs = Kilos * 3;
                Console.WriteLine($"u betaald {Prijs}€");
            }

        }
    }
}
