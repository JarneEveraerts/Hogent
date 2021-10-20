using System;

namespace aantalkeer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            Console.WriteLine("geef keer een zinneke");
            string Invoer = Console.ReadLine();
            char C;
            foreach (char c in Invoer)
            {
                C = Invoer[i];
                i++;
                if (C == 'e'||C=='E')
                {
                    j++;
                }
            }
            Console.WriteLine($"het woord bevatte {j} keer e");
        }
    }
}
