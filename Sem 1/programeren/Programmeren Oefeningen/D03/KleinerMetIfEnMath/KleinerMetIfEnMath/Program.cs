using System;

namespace KleinerMetIfEnMath
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuzeMethode;
            int Getal1=0, Getal2=0;
            Console.WriteLine("Maak een keuze tussen (if) of (math)");
            keuzeMethode = Console.ReadLine();
            Console.WriteLine("geef een geheel getal in");
            Getal1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("geef een geheel getal in");
            Getal2 = Convert.ToInt16(Console.ReadLine());
            if (keuzeMethode == "if")
            {
                if (Getal1 < Getal2)
                {
                    Console.WriteLine($"het kleinste getal is {Getal1}");
                }
                Console.WriteLine($"het kleinste getal is {Getal2}");
            }
            else if(keuzeMethode == "math")
            {
                Console.WriteLine($"het kleinste getal is{Math.Min(Getal1,Getal2)}");
            }
            else
            {
                Console.WriteLine("gelieve een keuze te maken");
            }
        }
    }
}
