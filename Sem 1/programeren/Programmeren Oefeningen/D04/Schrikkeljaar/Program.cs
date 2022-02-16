using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            double jaar;
            Console.WriteLine("geef u jaar in");
            jaar = double.Parse(Console.ReadLine());
            if (jaar % 4 == 0)
            {
                Console.WriteLine($"schrikkeljaar");

            }
            else
            {
                Console.WriteLine($"geen schrikkeljaar");
            }
        }
    }
}
