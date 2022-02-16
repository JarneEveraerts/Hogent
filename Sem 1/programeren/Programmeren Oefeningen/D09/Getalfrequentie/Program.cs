using System;

namespace Getalfrequentie
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] getallen = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int[] aantalGetallen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0};
            Console.WriteLine("geef getal in 0-10(stop to stop)");
            string invoer = Console.ReadLine().ToLower().Trim();
            while (invoer!="stop")
            {
                for (int i = 0; i < getallen.Length; i++)
                {
                    if (invoer==getallen[i])
                    {
                        aantalGetallen[i]++;
                    }
                    
                }
                Console.WriteLine("geef getal in 0-10(stop to stop");
                invoer = Console.ReadLine().ToLower().Trim();
            }
            for (int i = 0; i < getallen.Length; i++)
            {
                if (0 < aantalGetallen[i])
                {
                    Console.WriteLine($"{getallen[i]} komt {aantalGetallen[i]} voor");
                }
            }
        }
    }
}