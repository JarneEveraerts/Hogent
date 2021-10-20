using System;

namespace D06.rechthoekigedriehoekrechts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte: ");
            int hoogte = int.Parse(Console.ReadLine());

            for (int i = hoogte; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = hoogte; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
