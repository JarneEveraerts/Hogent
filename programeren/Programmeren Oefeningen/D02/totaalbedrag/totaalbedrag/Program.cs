using System;

namespace totaalbedrag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef aantal munten van 2 in");
            int Munstuk2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("geef aantal munten van 1 in");
            int Munstuk1 = Convert.ToInt16(Console.ReadLine());
            int Totaal = (Munstuk2 * 2) + Munstuk1;
            Console.WriteLine("uw totaal bedrag is " + Totaal);
        }
    }
}
