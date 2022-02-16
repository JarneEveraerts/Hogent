using System;

namespace Toelage
{
    class Program
    {
        static void Main(string[] args)
        {
            double JaarnInkomst, Kind,Premie;
            Console.WriteLine("geef u jaarinkomen");
            JaarnInkomst = double.Parse(Console.ReadLine());
            Console.WriteLine("geef aantal kinderen in");
            Kind = double.Parse(Console.ReadLine());
            if (JaarnInkomst > 20 || Kind <= 3)
            {
                Premie = JaarnInkomst * 0.03;
                Console.WriteLine(Premie);
            }
            else
            {
                Console.WriteLine("u krijgt gene prim");
            }
        }
    }
}
