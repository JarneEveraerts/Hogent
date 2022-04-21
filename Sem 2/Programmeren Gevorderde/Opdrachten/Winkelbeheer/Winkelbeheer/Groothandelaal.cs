using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkelbeheer
{
    internal class Groothandelaar
    {
        public ProductType Product { get; set; }
        public int Aantal { get; set; }
        public List<string> Bestellingen { get; set; } = new();

        public Groothandelaar(List<Stock> stock)
        {
            foreach (Stock s in stock)
            {
                s.OnStockAanvullen += AddBestelling;
            }
        }

        public void AddBestelling(StockEventArgs e)
        {
            Product = e.Stock.Product;
            Aantal = 100 - e.Stock.Aantal;
            Bestellingen.Add($"Voorraadbestelling : {Product}, {Aantal}");
        }

        public void ShowBestellingen()
        {
            Console.WriteLine("----------");
            foreach (var VARIABLE in Bestellingen)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("----------");
        }
    }
}