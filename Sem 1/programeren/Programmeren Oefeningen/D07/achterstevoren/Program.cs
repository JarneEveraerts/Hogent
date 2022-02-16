using System;

namespace achterstevoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lengte;
            char Char;
            Console.WriteLine("geef keer een woordje");
            string Invoer = Console.ReadLine();
            Lengte = Invoer.Length;
            for (int i = Lengte-1; i >-1; i--)
            {
                Char = Invoer[i];
                Console.Write($"{Char}");
            }
        }
    }
}
