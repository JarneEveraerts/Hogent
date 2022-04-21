using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkelbeheer;

Winkel w = new Winkel();
Groothandelaar g = new Groothandelaar(w.Stock);
w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Dorpstraat 5, Lievegem"));
w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 25, "Dorpstraat 5, Lievegem"));
w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 55, "Dorpstraat 5, Lievegem"));
w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Kerkstraat 155, Zele"));
w.Sales.Rapport();
Console.WriteLine();
w.ShowStock();
Console.WriteLine();
g.ShowBestellingen();
Console.WriteLine();
w.Restock();
w.ShowStock();

//w.VooraadBijvulling();