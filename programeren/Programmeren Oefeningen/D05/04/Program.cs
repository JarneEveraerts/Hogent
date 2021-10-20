using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, Ingave;
            double Uitkomst = 0;
            Console.WriteLine("geef een getal in (-1 stopt het programma)");
            Ingave = int.Parse(Console.ReadLine());
            do
            {
                i++;
                Uitkomst = Uitkomst + Ingave;
                Console.WriteLine("geef een getal in (-1 stopt het programma)");
                Ingave = int.Parse(Console.ReadLine());
            } while (Ingave != -1);
            Console.WriteLine($"het gemiddelde van alle getalle is {Uitkomst/i}");
        }
    }
}
