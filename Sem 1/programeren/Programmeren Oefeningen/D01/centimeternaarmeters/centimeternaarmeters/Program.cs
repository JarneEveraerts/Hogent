using System;

namespace centimeternaarmeters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lengteInCm = 456;
            Console.Write(lengteInCm);
            Console.Write("cm = ");
            int volledigAantalMeters = lengteInCm / 100;
            int aantalResterendeCm = lengteInCm - (volledigAantalMeters * 100);
            Console.Write(volledigAantalMeters);
            Console.Write("m en ");
            Console.Write(aantalResterendeCm);
            Console.Write("cm");
        }
    }
}