using System;

namespace zoekennavorige
{
    class Program
    {
        static void Main(string[] args)
        {
            string Invoer, Keuze,Default;
            int LengteKeuze,i=0;
            Console.WriteLine("geef een zinneke");
            Invoer = Console.ReadLine().ToLower();
            Default = Invoer;
            Console.WriteLine("zoekterm");
            Keuze = Console.ReadLine().ToLower();
            LengteKeuze = Keuze.Length;
            if (Keuze!="")
            {
                while (Invoer.Contains(Keuze))
                {
                    Invoer = Invoer.Remove(Invoer.IndexOf(Keuze), LengteKeuze);
                    i++;
                }
            }
            Console.WriteLine($"{Default} bevat {Keuze} {i} keer");
            

        }
    }
}
