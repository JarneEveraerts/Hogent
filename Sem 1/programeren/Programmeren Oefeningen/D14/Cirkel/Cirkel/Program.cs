using System;

namespace Cirkel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            cirkel.SetStraal(3.45);
            Console.WriteLine($"een cirkel met straal {cirkel.GetStraal()} cm heeft een oppervlakte van {cirkel.Oppervlakte()} cm² ");
        }
    }
}