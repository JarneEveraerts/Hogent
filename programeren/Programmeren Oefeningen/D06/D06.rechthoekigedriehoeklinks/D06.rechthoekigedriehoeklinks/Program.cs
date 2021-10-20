using System;

namespace D06.rechthoekigedriehoeklinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte: ");
            int hoogte = int.Parse(Console.ReadLine());


            for (int i = hoogte; i >= 1; i--)
            {
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
