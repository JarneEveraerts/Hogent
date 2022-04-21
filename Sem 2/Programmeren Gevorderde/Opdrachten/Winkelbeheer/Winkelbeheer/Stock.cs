using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Winkelbeheer
{
    internal class Stock
    {
        public delegate void StockDelegate(StockEventArgs e);

        public event StockDelegate OnStockAanvullen;

        public ProductType Product { get; set; }
        public int Aantal { get; set; }

        public Stock(ProductType product, Winkel winkel)
        {
            winkel.OnStockUpdate += UpdateVerkoop;
            Product = product;
            Aantal = 100;
        }

        public void UpdateVerkoop(WinkelEventArgs e)
        {
            if (this.Product != e.Bestelling.Product) return;
            Aantal -= e.Bestelling.Aantal;
            if (Aantal < 31)
            {
                OnStockAanvullen?.Invoke(new StockEventArgs(this));
            }
        }

        public override string ToString()
        {
            return $"[stock:{Product},{Aantal}]";
        }

        public void Restock()
        {
            Aantal = 100;
        }
    }

    internal class StockEventArgs : EventArgs
    {
        public Stock Stock { get; set; }

        public StockEventArgs(Stock stock)
        {
            Stock = stock;
        }
    }
}