using System;

namespace Artikel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BTW btw = new BTW();
            btw.SetExclusief(100);
            btw.SetBtw(21);
            Console.WriteLine($"het koopje van {btw.GetExclusief()}€ met een btw van {btw.GetBtw()}% kost {btw.InclusiefBtw()}€");
        }
    }
}