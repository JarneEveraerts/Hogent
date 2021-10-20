using System;

namespace Leeftijd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef uw naam");
            string Naam1 = Console.ReadLine();
            Console.WriteLine("geef uw naam");
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Goeiendag "+Naam1+", je bent dus " + leeftijd + "jaar" );
        }
    }
}
