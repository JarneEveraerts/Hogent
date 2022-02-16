using System;

namespace D06.toonsomtussengrenzen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de ondergrens: ");
            int ondergrens = int.Parse(Console.ReadLine());

            Console.Write("Geef de bovengrens: ");
            int bovengrens = int.Parse(Console.ReadLine());

            int som = 0;

            for (int i = ondergrens + 1; i < bovengrens-1; i++)
            {
                som += i;

                Console.Write($"{i}+");


                
            }

            int bm1 = bovengrens - 1;
            som += bm1;

            Console.Write($"{bm1}");
            Console.Write($" = {som}");

            Console.ReadKey();
        }
    }
}
