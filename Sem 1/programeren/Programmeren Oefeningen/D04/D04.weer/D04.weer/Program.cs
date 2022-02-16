using System;

namespace D04.weer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            //bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            //bool hetRegent = (regen == "ja");

            if (regen == "ja" && zon == "ja")
            {
                Console.WriteLine("Regenboog");
            }
            else if (regen == "ja" && zon == "nee")
            {
                Console.WriteLine("Slecht weer");
            }
            else if (regen == "nee" && zon == "ja")
            {
                Console.WriteLine("Mooi weer");
            }
            else if (regen == "nee" && zon == "nee")
            {
                Console.WriteLine("Saaie dag");
            }

            Console.ReadKey();
        }
    }
}
