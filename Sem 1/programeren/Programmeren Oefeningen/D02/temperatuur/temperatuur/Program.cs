using System;

namespace temperatuur
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius=0, Farenheit;
            Console.WriteLine("geef u graden farenheit in");
            Farenheit = Convert.ToDouble(Console.ReadLine());
            Celcius = (Farenheit - 32)/ 1.8;
            Console.WriteLine($"het is {Convert.ToString(Celcius)}°C");
        }
    }
}
