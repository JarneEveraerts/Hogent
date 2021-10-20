using System;

namespace Frietjes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef uw naam");
            string Naam1 = Console.ReadLine();
            Console.WriteLine("geef nog een naam");
            string Naam2 = Console.ReadLine();
            Console.WriteLine("geef uw naam");
            string Gerecht = Console.ReadLine();
            Console.WriteLine($"{Naam1} en {Naam2} eten graag {Gerecht}.");
        }
    }
}
