using System;

namespace klinkerenmedeklinkers
{
    class Program
    {
        static void Main(string[] args)
        {
            string Klinkers = "aeiou", Medeklinkers = "bcdfghjklmnpqrstvwxyz", Invoer;
            int i = 0, j = 0, k = 0,Klinker=0,Medeklinker=0;
            char Kar1,Kar2,Kar3;
            Console.WriteLine("geef keer een zinneke in");
            Invoer = Console.ReadLine().ToLower();
            foreach (char c in Invoer)
            {
                Kar1 = Invoer[i];
                i++;
                foreach (char d in Klinkers)
                {
                    Kar2 = Klinkers[j];
                    j++;
                    if (Kar1==Kar2)
                    {
                        Klinker++;
                    }
                }
                j = 0;
                foreach (char e in Medeklinkers)
                {
                    Kar3 = Medeklinkers[k];
                    k++;
                    if (Kar1==Kar3)
                    {
                        Medeklinker++;
                    }
                }
                k = 0;
            }
            Console.WriteLine($"de zin bevat {Klinker} klinkers en {Medeklinker} medeklinkers");
        }
    }
}
