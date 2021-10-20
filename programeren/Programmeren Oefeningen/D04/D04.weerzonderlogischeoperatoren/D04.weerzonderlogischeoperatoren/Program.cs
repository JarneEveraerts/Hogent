using System;

namespace D04.weerzonderlogischeoperatoren
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

            if (regen == "ja")
            {
                if (zon == "ja")
                {
                    Console.Write("Regenboog");
                }
                else if (zon == "nee")
                {
                    Console.Write("Slecht weer");
                }

            }
            else if (regen == "nee")
            {
                if (zon == "ja")
                {
                    Console.Write("Mooi weer");
                }
                else if (zon == "nee")
                {
                    Console.Write("Saaie dag");
                }
            }
            

            Console.ReadKey();
        }
    }
}
