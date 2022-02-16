using System;

namespace quotient
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deeltal, Deler, Uitkomst;
            Console.WriteLine("geef uw deeltal in");
            Deeltal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("geef uw deler in");
            Deler = Convert.ToDouble(Console.ReadLine());
            if (Deler == 0)
            {
                Console.WriteLine("U kan NIET delen door 0");
            }
            else
            {
                Uitkomst = Deeltal / Deler;
                Console.WriteLine($"Quotient = {Uitkomst}");
            }

        }
    }
}
