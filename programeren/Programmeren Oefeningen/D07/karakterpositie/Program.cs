using System;

namespace karakterpositie
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
            for (int i = 0; i < Lengte; i++)
            {
                Char = Invoer[i];
                Console.WriteLine($"{i+1} = {Char}");
            }
        }
    }
}
