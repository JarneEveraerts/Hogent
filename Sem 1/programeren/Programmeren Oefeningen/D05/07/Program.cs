using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, Ingave, Getal;
            Console.WriteLine("geef een getal in (2X het zelfde getal na elkaar stopt het programma)");
            Ingave = int.Parse(Console.ReadLine());
            do
            {
                Getal = Ingave;
                i++;
                Console.WriteLine("geef een getal in (2X het zelfde getal na elkaar stopt het programma)");
                Ingave = int.Parse(Console.ReadLine());
            } while (Ingave!=Getal);
            Console.WriteLine($"u heeft {i} getallen ingevoerd");
        }
    }
}
