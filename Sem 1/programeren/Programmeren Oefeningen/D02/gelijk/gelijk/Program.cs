using System;

namespace gelijk
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal1, Getal2;
            Console.WriteLine("geef 2 volledige cijfers in");
            Getal1 =Convert.ToInt16(Console.ReadLine());
            Getal2 = Convert.ToInt16(Console.ReadLine());
            if (Getal1 == Getal2)
            {
                Console.WriteLine("u heeft 2 dezelfde getalle");
            }
            else
            {
                Console.WriteLine("uw getallen zijn niet gelijk");
            }
        }
    }
}
