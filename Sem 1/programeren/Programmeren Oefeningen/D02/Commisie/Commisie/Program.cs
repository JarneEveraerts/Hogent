using System;

namespace Commisie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            String Naam, Commisie;
            double  Aantal, Gekregen;
            
            Console.WriteLine("geef uw naam in");
            Naam =Console.ReadLine();

            Console.WriteLine("geef uw aantal verkochte goederen in in");
            Aantal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("geef uw gekregen geld in");
            Gekregen = Convert.ToDouble( Console.ReadLine());
            Commisie = (Gekregen * 0.15).ToString("C");
            Console.WriteLine($"{Naam.ToUpper()} heeft {Aantal.ToString()} stukken verkocht en heeft hiervoor {Gekregen.ToString("C")}");
            Console.WriteLine($"{Naam.ToUpper()} heeft hiervoor {Commisie} commisie gekregen");


        }
    }
}
