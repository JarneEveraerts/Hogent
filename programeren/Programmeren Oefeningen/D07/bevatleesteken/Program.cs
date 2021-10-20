using System;

namespace bevatleesteken
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lengte,j=0,i=0;
            char Char;
            Console.WriteLine("geef keer een woordje");
            string Invoer = Console.ReadLine();
            Lengte = Invoer.Length;
            foreach (char c in Invoer)
            {
                Char = Invoer[i];
                if (char.IsPunctuation(Char))
                {
                    j++;
                }
                i++;

            }
            if (j>0)
            {
                Console.WriteLine($"deze zin bevat {j} leesttekens");
            }
            else
            {
                Console.WriteLine($"de invoer bevat geen leesttekens");
            }
        }
    }
}
