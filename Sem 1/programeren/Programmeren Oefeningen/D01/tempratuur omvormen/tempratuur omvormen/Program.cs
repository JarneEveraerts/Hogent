using System;

namespace tempratuur_omvormen
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius,Farenheit;
            Console.WriteLine("geef temperatuur in celcius in");
            Celcius = Convert.ToDouble(Console.ReadLine());
            Farenheit = Celcius * 9 / 5 + 32;
            Console.WriteLine(Farenheit);

        }
    }
}
