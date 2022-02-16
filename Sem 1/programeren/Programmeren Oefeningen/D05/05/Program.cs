using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, Ingave,Grootste=0;
            Console.WriteLine("geef een getal in (-1 stopt het programma)");
            Ingave = int.Parse(Console.ReadLine());
            do
            {
                if (Ingave>Grootste)
                {
                    Grootste = Ingave;
                    i = 0;
                }
                else if (Ingave == Grootste)
                {
                    i++;
                }
                Console.WriteLine("geef een getal in (-1 stopt het programma)");
                Ingave = int.Parse(Console.ReadLine());
            } while (Ingave != -1);
            Console.WriteLine($"het Grootste getal is {Grootste} en dit kwam {i} keer voor");
        }
    }
}
