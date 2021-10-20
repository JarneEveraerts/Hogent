using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Uitkomst = 0,Ingave;
            Console.WriteLine("geef een getal in (-1 stopt het programma)");
            Ingave = int.Parse(Console.ReadLine());
            do
            {
                Uitkomst = Uitkomst + Ingave;
                Console.WriteLine("geef een getal in (-1 stopt het programma)");
                Ingave = int.Parse(Console.ReadLine());
            } while (Ingave != -1);
            Console.WriteLine($"de som van alle getalle is {Uitkomst}");
        }
    }
}
