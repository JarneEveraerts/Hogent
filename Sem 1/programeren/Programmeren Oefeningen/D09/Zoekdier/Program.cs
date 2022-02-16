using System;

namespace Zoekdier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };
            Console.WriteLine("geef een dier");
            string invoer = Console.ReadLine();
            bool Check = false;

                for (int i=0; i<boerderijDieren.Length;i++)
                {
                    if (boerderijDieren[i] == invoer)
                    {
                        Check = true;
                    Console.WriteLine("dit is een dier");
                    break;

                    }

                }
            
        }
    }
}
