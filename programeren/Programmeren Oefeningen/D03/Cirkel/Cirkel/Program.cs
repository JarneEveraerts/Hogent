using System;

namespace Cirkel
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Straal, Oppervlak, Omtrek;
            Console.WriteLine("geef de straal van de cirkel in cm");
            Straal = Convert.ToDouble(Console.ReadLine());
            Oppervlak = Math.PI * Math.Pow(Straal, 2);
            Omtrek = 2 * Straal * Math.PI;
            Console.WriteLine($"een cirkel met straal {Straal,6:f3}cm heeft een oppervlak van {Oppervlak,6:f3}cm en een omtrek van {Omtrek,6:f3}cm.");
        }
    }
}
