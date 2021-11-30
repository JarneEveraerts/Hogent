using System;

namespace Afstandtussenpunten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Punt punt1 = new Punt();
            Punt punt2 = new Punt();
            Punt afstand = new Punt();
            punt1.SetPunt(4, 6);
            punt2.SetPunt(7, 2);
            Console.WriteLine(afstand.GetAfstandTussen(punt1.GetPunt(), punt2.GetPunt()));
        }
    }
}