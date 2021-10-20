using System;

namespace GetalRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Keuze = 0, Getal;
            Getal = random.Next(10);
            Console.WriteLine("geef een geheel getal in");
            Keuze = Convert.ToInt16(Console.ReadLine());
            while (Keuze != Getal)
            {
                if (Keuze < Getal)
                {
                    Console.WriteLine("het getal is groter");
                }
                else
                {
                    Console.WriteLine("het getal is kleiner");
                }
                Keuze = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("proficiat u heeft het getal geraden");
                
        }
    }
}
