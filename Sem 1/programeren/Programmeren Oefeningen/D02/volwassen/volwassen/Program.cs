using System;

namespace volwassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef u leeftijd in");
            int Leeftijd = Convert.ToInt16(Console.ReadLine());
            if (Leeftijd >= 18)
            {
                Console.WriteLine("u bent volwassen");
            }
            else
            {
                Console.WriteLine("u bent minderjarig");
            }
        }
    }
}
