using System;

namespace Muntstukken
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int muntstukkenVan2Euro = 0;
            Console.Write("Aantal muntstukken van 2 euro?: ");
            muntstukkenVan2Euro = int.Parse(Console.ReadLine());
            int muntstukkenVan1Euro = 0;
            Console.Write("Aantal muntstukken van 1 euro?: ");
            muntstukkenVan1Euro = int.Parse(Console.ReadLine());
            int muntstukkenVan50Cent=0;
            Console.Write("Aantal muntstukken van 50 eurocent?: ");
            muntstukkenVan50Cent = int.Parse(Console.ReadLine());
            double totaalBedrag = Convert.ToDouble((muntstukkenVan2Euro * 2)+ muntstukkenVan1Euro + (muntstukkenVan50Cent *0.5));
            string formuleAlsTekst = $"{muntstukkenVan2Euro} x 2 + {muntstukkenVan1Euro} x 1 + {muntstukkenVan50Cent} x 0.5";
            Console.WriteLine($"{formuleAlsTekst} = {totaalBedrag} euro");
        }
    }
}