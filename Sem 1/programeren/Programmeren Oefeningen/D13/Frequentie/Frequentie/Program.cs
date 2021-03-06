using System;
using System.Collections.Generic;

namespace Frequentie
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] getallen = GetalVragen();
            Gemiddelde(Som(getallen));
            Frequentie(getallen);
        }

        private static int[] GetalVragen()
        {
            int[] getallen = new int[10];
            int getal = 0;
            string invoer = "";
            bool check = false;
            for (int i = 0; i < getallen.Length; i++)
            {
                while (check == false)
                {
                    Console.Write($"Getal {i + 1}: ");
                    invoer = Console.ReadLine();
                    check = int.TryParse(invoer, out getal);
                }
                check = false;
                getallen[i] = getal;
            }
            return getallen;
        }

        private static int Som(int[] getal)
        {
            int output = 0;
            foreach (int i in getal)
            {
                output += i;
            }
            Console.WriteLine($"Som: {output}");
            return output;
        }

        private static void Gemiddelde(int getal)
        {
            Console.WriteLine($"Gemiddelde: {getal / 10}");
        }

        private static void Frequentie(int[] getallen)
        {
            Console.WriteLine("Frequenties: ");
            bool check = false;
            List<int> distinct = new List<int>();
            foreach (int getal in getallen)
            {
                if (distinct.Count > 0)
                {
                    foreach (int i in distinct)
                    {
                        if (i == getal)
                        {
                            check = true;
                        }
                    }
                }
                if (check == false)
                {
                    distinct.Add(getal);
                }
                else
                {
                    check = false;
                }
            }
            distinct.Sort();
            int[] dubbelGetal = new int[distinct.Count];
            for (int i = 0; i < distinct.Count; i++)
            {
                foreach (int getal in getallen)
                {
                    if (distinct[i] == getal)
                    {
                        dubbelGetal[i]++;
                    }
                }
                Console.WriteLine($"    {distinct[i]} komt {dubbelGetal[i]} voor");
            }
        }
    }
}