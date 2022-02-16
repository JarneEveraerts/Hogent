using System;

namespace gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Getal1, Getal2, Getal3,Gemiddelde;
            Console.WriteLine("geef een 3 comma getal in");
            Getal1 = Convert.ToDouble(Console.ReadLine());
            Getal2 = Convert.ToDouble(Console.ReadLine());
            Getal3 = Convert.ToDouble(Console.ReadLine());
            Gemiddelde = (Getal1 + Getal2 + Getal3) / 3;
            Console.WriteLine("uw gemiddelde is " + Gemiddelde);
        }
    }
}
