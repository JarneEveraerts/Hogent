using System;

namespace leeftijdvolgendjaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef uw naam");
            string Naam1 = Console.ReadLine();
            Console.WriteLine("geef uw leeftijd");
            int Leeftijd = Convert.ToInt16(Console.ReadLine()) + 1;
            Console.WriteLine("oei oei " + Naam1 + ", je bent volgend jaar " + Leeftijd);
        }
    }
}
