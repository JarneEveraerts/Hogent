using System;

namespace InkomPrijs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lengte, Leeftijd;
            Console.WriteLine("geef u lengte in cm");
            Lengte = int.Parse(Console.ReadLine());
            Console.WriteLine("geef leeftijd");
            Leeftijd = int.Parse(Console.ReadLine());
            if (Leeftijd>=20 && Lengte<=160)
            {
                Console.WriteLine("u betaald 5euro");
            }
            else
            {
                Console.WriteLine("u betaald 10euro");
            }
        }
    }
}
