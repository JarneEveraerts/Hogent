using System;

namespace Fibanachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[10];

            fibonacci[0] = 1;
            fibonacci[1] = 1;

            // overige elementen gelijkstellen aan som van de vorige twee ...
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            foreach (int getal in fibonacci)
            {
                Console.Write(getal + " ");
            }
        }
    }
}
