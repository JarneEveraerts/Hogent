using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkelbeheer;

namespace Winkelbeheer
{
    internal class Sales
    {
        public List<Bestelling> Bestelling { get; set; } = new();

        public void AddSale(Bestelling bestelling)
        {
            Bestelling.Add(bestelling);
        }

        public void Rapport()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Sales - rapport");
            foreach (var bestellingen in Bestelling.GroupBy(bestelling => bestelling.Adres))
            {
                Console.WriteLine(bestellingen.Key);
                foreach (var producten in bestellingen.GroupBy(bestelling => bestelling.Product))
                {
                    Console.WriteLine($"    {producten.Key} , {producten.Aggregate(0, (total, next) => total += next.Aantal)}");
                }
            }

            Console.WriteLine("----------");
        }
    }
}