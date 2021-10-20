using System;

namespace Totaal_Bedrag
{
    class Program
    {
        static void Main(string[] args)
        {
            int biljettenVan10Euro = 7, biljettenVan5Euro = 6, muntstukkenVan2Euro = 5, muntstukkenVan1Euro = 4 , muntstukkenVan50Cent = 3;
            decimal TotaalBedrag;
            TotaalBedrag = Convert.ToDecimal(10 * biljettenVan10Euro) + Convert.ToDecimal(5 * biljettenVan5Euro) + Convert.ToDecimal(2 * muntstukkenVan2Euro) + Convert.ToDecimal(1 * muntstukkenVan1Euro) + Convert.ToDecimal( 0.5 * muntstukkenVan50Cent);
            Console.Write("u heeft " + TotaalBedrag + ("euro"));
        }
    }
}
