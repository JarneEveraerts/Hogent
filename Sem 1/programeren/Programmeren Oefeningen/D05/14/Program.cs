using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal maanden groei?: ");
            string AantalMaanden = Console.ReadLine();

            int maanden,i=1;
            bool invoerOk = int.TryParse(AantalMaanden, out maanden);

            if (invoerOk && maanden >= 1) 
            {
                int fibo1 = 0;
                int fibo2 = 1;
                int fibo3 = 0;
                while (i-1 < maanden)
                {
                    fibo3 = fibo1 + fibo2;
                    Console.WriteLine($"na {i} maanden wensen we als uitput {fibo2}");
                    fibo1 = fibo2;
                    fibo2 = fibo3;
                    i++;
                }


                Console.Write($"Aantal knooppunten: {fibo2s}");
            }
        }
    }
}
