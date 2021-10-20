using System;

namespace Absolute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in");
            double Getal = Convert.ToDouble(Console.ReadLine());
            Getal = Math.Abs(Getal);
            Console.WriteLine($"De absolute waarde van uw getal is {Getal}");
        }
    }
}
