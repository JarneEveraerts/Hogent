using System;

namespace Toonscore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            int i = 0;
            Console.WriteLine("welk vak");
            string invoer =Console.ReadLine().ToLower();
            foreach  (string s in vakken)
            {
                if (invoer == vakken[i].ToLower())
                {
                    Console.WriteLine($"{scores[i]}/100");
                }
                i++;
            }
        }
    }
}
