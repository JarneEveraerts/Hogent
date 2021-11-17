using System;

namespace KeuzeKleur
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "rood", "groen", "blauw", "geel" };
            string antwoord = vraagKeuze(kleuren);
            Console.WriteLine(antwoord);
        }
        static string vraagKeuze(string[] kleuren)
        {
            Console.WriteLine("kies een kleur(rood,groen,blauw,geel");
            string input = Console.ReadLine().ToLower();
            bool keuze = false;
            while (keuze==false)
            {
                foreach (string s in kleuren)
                {
                    if (s == input)
                    {
                        keuze = true;
                    }
                }
                if (keuze==false)
                {
                    Console.WriteLine("kies een kleur(rood,groen,blauw,geel");
                    input = Console.ReadLine().ToLower();
                }
            }
            return input;
        }
    }
}
