using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkelbeheer;

namespace Winkelbeheer
{
    public enum ProductType
    {
        Tripel,
        Dubbel,
        Kriek,
        Pils
    }

    internal class Winkel
    {
        public delegate void WinkelDelegate(WinkelEventArgs e); // 2de stap

        public event WinkelDelegate OnStockUpdate;

        public List<Stock> Stock { get; set; } = new();
        public Sales Sales { get; set; } = new();

        public Winkel()
        {
            Stock.Add(new Stock(ProductType.Tripel, this));
            Stock.Add(new Stock(ProductType.Dubbel, this));
            Stock.Add(new Stock(ProductType.Kriek, this));
            Stock.Add(new Stock(ProductType.Pils, this));
        }

        public void VerkoopProduct(Bestelling bestelling)
        {
            OnStockUpdate?.Invoke(new WinkelEventArgs(bestelling));
            //Stock.First(stock => bestelling.Product == stock.Product).UpdateVerkoop(bestelling.Aantal);//het product met de zelfde naam word aangepast
            Sales.AddSale(bestelling);
        }

        public void ShowStock()
        {
            Console.WriteLine("----------");
            foreach (var item in Stock)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------");
        }

        public void Restock()
        {
            foreach (var item in Stock)
            {
                item.Restock();
            }
        }

        /*public void VooraadBijvulling()
        {
            Console.WriteLine("----------");
            foreach (var item in Stock.Where(stock => stock.Aantal < 41))
            {
                Console.WriteLine($"Voorraadbestelling : {item.Product}, {100 - item.Aantal}");
                item.StockAanvullen(100 - item.Aantal);
            }
            Console.WriteLine("----------");
            Console.WriteLine();
            ShowStock();
        }*/
    }

    internal class WinkelEventArgs : EventArgs
    {
        public Bestelling Bestelling { get; set; }

        public WinkelEventArgs(Bestelling bestelling)
        {
            Bestelling = bestelling;
        }
    }
}