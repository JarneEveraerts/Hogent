using SportsStore.Data;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets; // LINQ = extension methods!!! Dit betekent: using toevoegen of je ziet niet dat deze mogelijk zijn met Intellisense

namespace SportsStore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Category> categories = DataSourceProvider.Categories.ToList();
            List<Customer> customers = DataSourceProvider.Customers.ToList();
            List<Product> products = DataSourceProvider.Products.ToList();

            #region 1. Toon de gemiddelde prijs van de producten

            var gemiddelde = products
                .Select(p => p.Price)
                .Average(); // LINQ
            Console.WriteLine($"De gemiddelde prijs van de producten is { gemiddelde:0.00}");

            #endregion 1. Toon de gemiddelde prijs van de producten

            #region 2. Toon hoeveel categorieen en hoeveel customers er zijn

            var aantalCategorieen = categories
                .Select(c => c.CategoryId)
                .Count(); // LINQ
            var aantalKlanten = customers
                .Select(c => c.CustomerName)
                .Count(); // LINQ
            Console.WriteLine($"Er zijn {aantalCategorieen} categorieen.");
            Console.WriteLine($"Er zijn {aantalKlanten} customers.");

            #endregion 2. Toon hoeveel categorieen en hoeveel customers er zijn

            #region 3. Hoeveel karakters telt de langste productnaam?

            var langsteNaamLengte = products
                .Max(p => p.Name.Length); // LINQ
            Console.WriteLine($"De langste productnaam is {langsteNaamLengte} karakters lang.");

            #endregion 3. Hoeveel karakters telt de langste productnaam?

            #region 4. Toon de naam van het product met de langste productnaam

            var productnaam = products
                .OrderByDescending(p => p.Name)
                .First().Name; // LINQ
            Console.WriteLine($"De langste productnaam is {productnaam}.");

            #endregion 4. Toon de naam van het product met de langste productnaam

            #region 5. Toon alle customers gesorteerd op naam, en vervolgens dalend op voornaam

            var customersSorted = customers
                .OrderBy(c => c.CustomerName)
            .ThenByDescending(c => c.FirstName); // LINQ
            PrintCustomers("Klanten gesorteerd op naam, en dan dalend op voornaam:", customersSorted);

            #endregion 5. Toon alle customers gesorteerd op naam, en vervolgens dalend op voornaam

            #region 6. Toon alle producten die meer dan 92.5 dollar kosten, dalend op prijs

            var expensiveProducts = products
                .Where(p => p.Price > 92.5m); // LINQ
            // M modifier, staat voor M(oney)
            // double: modifier D/d daardoor al benomen
            // decimal: modifier M/m omdat D/d al benomen was; decimals worden veel gebruikt als comma-getallen voor bankieren - geen afrondingsfouten, maar afgekapte komma-getallen
            PrintProducts("Producten die meer dan 92.5 dollar kosten", expensiveProducts);

            #endregion 6. Toon alle producten die meer dan 92.5 dollar kosten, dalend op prijs

            #region 7. Toon de categorieen die meer dan twee producten bevatten

            var myCategories = categories
                .Where(c => c.Products.Count() > 2); // LINQ
            PrintCategories("Categorieën met meer dan twee producten", myCategories);

            #endregion 7. Toon de categorieen die meer dan twee producten bevatten

            #region 8. Maak een lijst van strings die alle productnamen bevat

            // Projectie: dus een Select
            var productNamen = products
                .Select(p => p.Name); // LINQ
            PrintStrings("Namen van producten", productNamen);

            #endregion 8. Maak een lijst van strings die alle productnamen bevat

            #region 9. Maak een lijst van namen van steden waar customers wonen (zonder dubbels)

            var steden = customers
                .Select(c => c.City.Name)
                .Distinct(); // LINQ
            PrintStrings("Namen van steden waar klanten wonen", steden);

            #endregion 9. Maak een lijst van namen van steden waar customers wonen (zonder dubbels)

            #region 10. Geef de namen van de categorieën met enkel producten die de letter 'o' in de naam hebben (voor alle producten in de categorie moet gelden dat er een o in de naam voorkomt)

            // All: voor alle producten moet gelden dat er een o in de naam voorkomt
            // Any: als er minstens een product met een o in de naam
            // Wordt niet zoveel gebruikt in de praktijk
            var oCategories = categories
                .Where(c => c.Products
                    .All(c => c.Name.Contains("o")))
                .Select(c => c.Name); // LINQ
            PrintStrings("Categorieën waarbij alle producten de letter 'o' bevatten", oCategories);

            #endregion 10. Geef de namen van de categorieën met enkel producten die de letter 'o' in de naam hebben (voor alle producten in de categorie moet gelden dat er een o in de naam voorkomt)
        }

        #region Print helpmethodes

        private static void PrintCustomers(string message, IEnumerable<Customer> customers)
        {
            Console.WriteLine(message);
            foreach (Customer c in customers)
                Console.WriteLine($"{ c.Name} {c.FirstName}");
            Console.WriteLine();
        }

        private static void PrintProducts(string message, IEnumerable<Product> products)
        {
            Console.WriteLine(message);
            foreach (Product p in products)
                Console.WriteLine($"{ p.Name}, prijs: { p.Price}");
            Console.WriteLine();
        }

        private static void PrintCategories(string message, IEnumerable<Category> categories)
        {
            Console.WriteLine(message);
            foreach (Category c in categories)
                Console.WriteLine(c.Name);
            Console.WriteLine();
        }

        private static void PrintStrings(string message, IEnumerable<string> strings)
        {
            Console.WriteLine(message);
            foreach (string s in strings)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        private static void PrintProduct(string message, Product product)
        {
            Console.WriteLine(message);
            if (product == null)
                Console.WriteLine("Product is null");
            else
                Console.WriteLine($"{ product.Name}, prijs: {product.Price}");

            Console.WriteLine();
        }

        #endregion Print helpmethodes
    }
}